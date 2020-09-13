using Newtonsoft.Json;
using System;

namespace EODLoader.Services.EodHistoricalData.Models
{
    public abstract class HistoricalBasePrice
    {
        [JsonProperty("date")]
        public DateTime Date { get; set; }

        [JsonProperty("volume")]
        public long? Volume { get; set; }
    }
}
