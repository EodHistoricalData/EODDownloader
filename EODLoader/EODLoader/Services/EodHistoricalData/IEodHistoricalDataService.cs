using EODLoader.Services.EodHistoricalData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EODLoader.Services.EodHistoricalData
{
    public interface IEodHistoricalDataService
    {
        HistoricalResult GetHistoricalPrices(string symbol, DateTime? startDate, DateTime? endDate, string period);
    }
}
