using EODLoader.Services.ConfigurationData;
using EODLoader.Services.ConfigurationData.Model;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace EODLoader.Logs
{
    public static class Logger
    {
        private static readonly ILogger _errorLogger;
        private static IConfigurationService _configurationService { get; set; }
        private static ConfigurationModel _configuration { get; set; }


        static Logger()
        {
            _configurationService = new ConfigurationService();

            _configuration = _configurationService.GetConfiguration();

            _errorLogger = new LoggerConfiguration()
                .WriteTo.File(_configuration.LogFilePath +@"\log-.txt", rollingInterval: RollingInterval.Day)
                .CreateLogger();
        }

        public static void LogError(string error)
        {
            _errorLogger.Error($"\n{error}");
        }

        public static void LogError(Exception ex, string error)
        {
            _errorLogger.Error(ex, $"\n{error}");
        }
    }
}
