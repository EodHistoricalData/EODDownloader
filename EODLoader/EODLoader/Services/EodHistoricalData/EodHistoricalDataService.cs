﻿using EODLoader.Logs;
using EODLoader.Services.ConfigurationData;
using EODLoader.Services.ConfigurationData.Model;
using EODLoader.Services.EodHistoricalData.Models;
using EODLoader.Services.Proxy;
using EODLoader.Services.Utils;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace EODLoader.Services.EodHistoricalData
{
    public class EodHistoricalDataService : IEodHistoricalDataService
    {
        const string HistoricalDataUrl = "https://eodhistoricaldata.com/api/eod/";
        private IConfigurationService _configurationService { get; set; }
        private ConfigurationModel _configuration { get; set; }

        public EodHistoricalDataService()
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            _configurationService = new ConfigurationService();
            _configuration = _configurationService.GetConfiguration();
        }

        public bool ValidateToken(string token)
        {
            string testUrl = $"https://eodhistoricaldata.com/api/eod/AAPL.US?api_token={token}&period=d";

            IWebProxyService webProxyService = new WebProxyService();

            bool proxyIsUsed = _configuration.ProxyIsUsed;
            var client = new RestClient(testUrl);

            if (proxyIsUsed)
            {
                client.Proxy = webProxyService.GetWebProxy();
            }

            var request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);

            if (response.StatusCode == HttpStatusCode.OK)
            {
                return true;
            }

            return false;
        }

        public async Task<HistoricalResult> GetHistoricalPrices(string symbol, DateTime? startDate, DateTime? endDate, string per, bool isUpdate)
        {
            try
            {
                IUtilsService utils = new UtilsService();

                string checkPath = $@"{_configuration.LastDownloadDirectoryPath}\{symbol}.csv";

                if (isUpdate != false)
                {
                    isUpdate = utils.RewriteDateBeforeLoad(checkPath, ref startDate, ref endDate);
                }

                var result = new HistoricalResult
                {
                    Symbol = symbol
                };

                string period = string.Empty;
                if (!string.IsNullOrEmpty(per))
                {
                    per = per.ToLower();
                    period = $"&period={per[0]}";
                }

                string dateParameters = GetDateParametersAsString(startDate, endDate);
                var token = _configuration.Token;

                var url = $"{HistoricalDataUrl}{symbol}?{dateParameters}&api_token={token}{period}&fmt=json";

                IWebProxyService webProxyService = new WebProxyService();

                bool proxyIsUsed = _configuration.ProxyIsUsed;
                var client = new RestClient(url);

                if (proxyIsUsed)
                {
                    client.Proxy = webProxyService.GetWebProxy();
                }

                var request = new RestRequest(Method.GET);

                var bodyJson = JsonConvert.SerializeObject(new { source = "eodloader" }, Formatting.Indented);
                request.AddParameter("application/json", bodyJson, ParameterType.RequestBody);

                IRestResponse response = await client.ExecuteAsync(request);
                if (response.StatusCode == 0)
                {
                    Logger.LogError("Unable to connect to remote server");
                    var error = new HistoricalResult
                    {
                        Symbol = symbol,
                        Description = "Unable to connect to remote server"
                    };
                    error.Status = proxyIsUsed ? Common.StatusEnum.ErrorProxy : Common.StatusEnum.Error;
                    return error;
                }

                if (response.StatusCode == HttpStatusCode.OK)
                {
                    if (symbol.EndsWith(".BOND"))
                    {
                        var historicalBondPrices = JsonConvert.DeserializeObject<List<HistoricalBondPrice>>(response.Content);
                        var historicalBondPricesExt = await CalcHistoricalBondPrices(historicalBondPrices);

                        string path = $@"{_configuration.LastDownloadDirectoryPath}\{symbol}.csv";

                        await utils.CreateCVSFile(historicalBondPricesExt, path, isUpdate);
                    }
                    else
                    {
                        var historicalPrices = JsonConvert.DeserializeObject<List<HistoricalPrice>>(response.Content);
                        var historicalPricesExt = await CalcHistoricalPrices(historicalPrices);

                        string path = $@"{_configuration.LastDownloadDirectoryPath}\{symbol}.csv";

                        await utils.CreateCVSFile(historicalPricesExt, path, isUpdate);
                    }

                    return new HistoricalResult
                    {
                        Symbol = symbol,
                        Status = Common.StatusEnum.Ok,
                        Description = $"{((int)response.StatusCode).ToString()} {response.StatusDescription}"
                    };
                }
                else
                {
                    return new HistoricalResult
                    {
                        Symbol = symbol,
                        Status = Common.StatusEnum.Error,
                        Description = $"{((int)response.StatusCode).ToString()} {response.StatusDescription}"
                    };
                }
            }
            catch (Exception ex)
            {
                Logger.LogError(ex, ex.StackTrace);
                return new HistoricalResult
                {
                    Symbol = symbol,
                    Status = Common.StatusEnum.Error,
                    Description = "Error. View logs!"
                };
            }
        }

        private async Task<List<HistoricalPriceExtended>> CalcHistoricalPrices(IEnumerable<HistoricalPrice> historicalPrices)
        {
            try
            {
                var result = new List<HistoricalPriceExtended>();
                foreach (var item in historicalPrices)
                {
                    double k = 0;
                    if (item.AdjustedClose != null && item.Close != null && item.Close != 0)
                    {
                        k = item.AdjustedClose.Value / item.Close.Value;
                    }
                    var historicalPrice = new HistoricalPriceExtended
                    {
                        Date = item.Date.ToString("yyyy-MM-dd"),
                        Volume = item.Volume,
                        AdjustedHigh = item.High != null ? item.High * k : null,
                        AdjustedLow = item.Low != null ? item.Low * k : null,
                        AdjustedOpen = item.Open != null ? item.Open * k : null,
                        AdjustedClose = item.Close != null ? item.Close * k : null,
                        High = item.High != null ? item.High : null,
                        Low = item.Low != null ? item.Low : null,
                        Open = item.Open != null ? item.Open : null,
                        Close = item.Close !=null ? item.Close : null
                    };
                    result.Add(historicalPrice);
                }

                return result;
            }
            catch (Exception ex)
            {
                Logger.LogError(ex, ex.StackTrace);
                throw;
            }
        }

        private async Task<List<HistoricalBondPriceExtended>> CalcHistoricalBondPrices(IEnumerable<HistoricalBondPrice> items)
        {
            try
            {
                var result = new List<HistoricalBondPriceExtended>();
                foreach (var item in items)
                {
                    var historicalPrice = new HistoricalBondPriceExtended
                    {
                        Date = item.Date.ToString("yyyy-MM-dd"),
                        Volume = item.Volume,
                        Price = item.Price != null ? item.Price : null,
                        Yield = item.Yield != null ? item.Yield : null
                    };
                    result.Add(historicalPrice);
                }

                return result;
            }
            catch (Exception ex)
            {
                Logger.LogError(ex, ex.StackTrace);
                throw;
            }
        }

        private string GetDateParametersAsString(DateTime? startDate, DateTime? endDate)
        {
            StringBuilder sb = new StringBuilder();
            if (startDate.HasValue)
                sb.Append($"from={startDate.Value.ToString("yyyy-MM-dd")}");
            if (endDate.HasValue)
            {
                if (startDate.HasValue)
                    sb.Append("&");
                sb.Append($"to={endDate.Value.ToString("yyyy-MM-dd")}");
            }

            return sb.ToString();
        }
    }
}
