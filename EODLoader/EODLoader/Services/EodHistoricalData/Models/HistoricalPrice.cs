using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EODLoader.Services.EodHistoricalData.Models
{
    public class HistoricalPrice
    {
        [JsonProperty("date")]
        public DateTime Date { get; set; }

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

        [JsonProperty("volume")]
        public long? Volume { get; set; }
    }
}
