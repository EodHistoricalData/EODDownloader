using EODLoader.Services.EodHistoricalData.Models;
using System;
using System.Threading.Tasks;

namespace EODLoader.Services.EodHistoricalData
{
    public interface IEodHistoricalDataService
    {
        Task<HistoricalResult> GetHistoricalPrices(string symbol, DateTime? startDate, DateTime? endDate, string period, bool isUpdate);
        bool ValidateToken(string token);
    }
}
