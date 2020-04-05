using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using EODLoader.Services.EodHistoricalData.Models;
using EODLoader.Services.Proxy;
using EODLoader.Services.Utils;
using Newtonsoft.Json;
using RestSharp;

namespace EODLoader.Services.EodHistoricalData
{
    public class EodHistoricalDataService : IEodHistoricalDataService
    {
        const string HistoricalDataUrl = "https://eodhistoricaldata.com/api/eod/";

        public EodHistoricalDataService() { }

        public HistoricalResult GetHistoricalPrices(string symbol, DateTime? startDate, DateTime? endDate, string per)
        {
            try
            {
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
                var token = Properties.Settings.Default.Token;

                var url = $"{HistoricalDataUrl}{symbol}?{dateParameters}&api_token={token}{period}&fmt=json";

                IWebProxyService webProxyService = new WebProxyService();

                bool proxyIsUsed = Properties.Settings.Default.proxyIsUsed;
                var client = new RestClient(url);

                if (proxyIsUsed)
                {
                    client.Proxy = webProxyService.GetWebProxy();
                }

                var request = new RestRequest(Method.GET);
                IRestResponse response = client.Execute(request);
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    var historicalPrices = JsonConvert.DeserializeObject<List<HistoricalPrice>>(response.Content);
                    var historicalPricesExt = CalcHistoricalPrices(historicalPrices);

                    IUtilsService utils = new UtilsService();
                    string path = $@"{Properties.Settings.Default.lastDownloadDirectoryPath}\{symbol}.csv";

                    utils.CreateCVSFile(historicalPricesExt, path);

                    return new HistoricalResult
                    {
                        Symbol = symbol,
                        Status = Common.StatusEnum.Ok
                    };
                }
                else
                {
                    return new HistoricalResult
                    {
                        Symbol = symbol,
                        Status = Common.StatusEnum.Error,
                        ErrorDescription = response.StatusDescription
                    };
                }
            }
            catch (Exception e)
            {
                //TODO: add log
                return new HistoricalResult
                {
                    Symbol = symbol,
                    Status = Common.StatusEnum.Error,
                    ErrorDescription = "Error. View logs!"
                };
            }
        }

        private List<HistoricalPriceExtended> CalcHistoricalPrices(IEnumerable<HistoricalPrice> historicalPrices)
        {
            var result = new List<HistoricalPriceExtended>();
            foreach (var item in historicalPrices)
            {
                double k = 0;
                if (item.Close != 0)
                {
                    k = item.AdjustedClose / item.Close;
                }
                var historicalPrice = new HistoricalPriceExtended
                {
                    Date = item.Date,
                    Volume = item.Volume,
                    AdjustedHigh = item.High * k,
                    AdjustedLow = item.Low * k,
                    AdjustedOpen = item.Open * k,
                    AdjustedClose = item.Close,
                    High = item.High,
                    Low = item.Low,
                    Open = item.Open,
                    Close = item.Close
                };
                result.Add(historicalPrice);
            }

            return result;
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
