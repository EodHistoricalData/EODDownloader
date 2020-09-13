using Newtonsoft.Json;
using System;

namespace EODLoader.Services.EodHistoricalData.Models
{
    public class HistoricalBondPrice : HistoricalBasePrice
    {
        [JsonProperty("price")]
        public double? Price { get; set; }

        [JsonProperty("yield")]
        public double? Yield { get; set; }
    }
}
