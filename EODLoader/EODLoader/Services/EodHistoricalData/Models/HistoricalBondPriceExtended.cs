namespace EODLoader.Services.EodHistoricalData.Models
{
    public class HistoricalBondPriceExtended
    {
        public string Date { get; set; }
        public long? Volume { get; set; }
        public double? Price { get; set; }
        public double? Yield { get; set; }
    }
}
