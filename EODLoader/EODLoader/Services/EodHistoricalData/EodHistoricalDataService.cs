using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EODLoader.Services.EodHistoricalData.Models;
using Newtonsoft.Json;
using RestSharp;

namespace EODLoader.Services.EodHistoricalData
{
    public class EodHistoricalDataService : IEodHistoricalDataService
    {
        const string HistoricalDataUrl = "https://eodhistoricaldata.com/api/eod/"; 
        const string Token = "5e87334a377b54.22292136";

        public EodHistoricalDataService()
        {
        }

        public List<HistoricalPrice> GetHistoricalPrices(string symbol, DateTime? startDate, DateTime? endDate, string per)
        {
            string dateParameters = GetDateParametersAsString(startDate, endDate);
            string period = !string.IsNullOrEmpty(per) ? $"&period={per}" : string.Empty;

            var url = $"{HistoricalDataUrl}{symbol}?{dateParameters}&api_token={Token}{period}&fmt=json";

            var client = new RestClient(url);
            var request = new RestRequest(Method.GET);

            IRestResponse response = client.Execute(request);

            var result = JsonConvert.DeserializeObject<List<HistoricalPrice>>(response.Content);

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
