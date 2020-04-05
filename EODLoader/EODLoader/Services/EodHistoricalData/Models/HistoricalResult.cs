using EODLoader.Common;

namespace EODLoader.Services.EodHistoricalData.Models
{
    public class HistoricalResult
    {
        public string Symbol { get; set; }
        public StatusEnum Status { get; set; }
        public string ErrorDescription { get; set; }
    }
}
