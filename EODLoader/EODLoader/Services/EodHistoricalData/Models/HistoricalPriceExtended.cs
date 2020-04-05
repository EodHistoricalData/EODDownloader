using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EODLoader.Services.EodHistoricalData.Models
{
    public class HistoricalPriceExtended : HistoricalPrice
    {
        public double AdjustedHigh { get; set; }
        public double AdjustedLow { get; set; }
        public double AdjustedOpen { get; set; }
    }
}
