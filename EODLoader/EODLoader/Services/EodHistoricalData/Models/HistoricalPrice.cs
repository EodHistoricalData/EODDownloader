using Newtonsoft.Json;
using System;

namespace EODLoader.Services.EodHistoricalData.Models
{
    public class HistoricalPrice : HistoricalBasePrice
    {
        [JsonProperty("open")]
        public double? Open { get; set; }

        [JsonProperty("high")]
        public double? High { get; set; }

        [JsonProperty("low")]
        public double? Low { get; set; }

        [JsonProperty("close")]
        public double? Close { get; set; }

        [JsonProperty("adjusted_close")]
        public double? AdjustedClose { get; set; }
    }
}
