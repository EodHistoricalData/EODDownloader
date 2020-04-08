using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace EODLoader.Services.ConfigurationData.Model
{
    [Serializable]
    public class ConfigurationModel
    {
        public string Token { get; set; } = "OeAFFmMliFG5orCUuwAKQ8l4WWFQ67YX";

        public string ProxyWebAddress { get; set; } = string.Empty;

        public string ProxyUserName { get; set; } = string.Empty;

        public string ProxyPassword { get; set; } = string.Empty;

        public bool ProxyIsUsed { get; set; } = false;

        public bool ProxyCredentialsIsUsed { get; set; } = false;

        public string LogFilePath { get; set; } = string.Empty;

        public string LastSymbolFilePath { get; set; } = string.Empty;

        public string LastDownloadDirectoryPath { get; set; } = string.Empty;

        public bool AutoUpdateIsUsed { get; set; } = true;

        public int NumberOfThread { get; set; } = 5;

        public string AutoUpdateUrl { get; set; } = "https://eodhistoricaldata.com/EODLoaderUpdate.xml";

        public string TestToken { get; set; } = "OeAFFmMliFG5orCUuwAKQ8l4WWFQ67YX";
    }
}
