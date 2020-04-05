using EODLoader.Services.EodHistoricalData;
using EODLoader.Services.Proxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EODLoader.Forms
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //try
            //{
            //    IEodHistoricalDataService eodServise = new EodHistoricalDataService();

            //    var result = eodServise.GetHistoricalPrices("AI.PA", new DateTime(2020, 03, 01), new DateTime(2020, 04, 01), "d");
            //}
            //catch (Exception e)
            //{

            //    throw;
            //}


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
