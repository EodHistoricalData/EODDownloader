namespace EODLoader.Services.EodHistoricalData.Models
{
    public class HistoricalPriceExtended
    {
        public string Date { get; set; }
        public double? Open { get; set; }
        public double? High { get; set; }
        public double? Low { get; set; }
        public double? Close { get; set; }
        public long? Volume { get; set; }
        public double? AdjustedOpen { get; set; }
        public double? AdjustedHigh { get; set; }
        public double? AdjustedLow { get; set; }
        public double? AdjustedClose { get; set; }

    }
}
