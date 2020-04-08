using EODLoader.Services.AutoUpdate.Models;
using EODLoader.Services.ConfigurationData;
using EODLoader.Services.ConfigurationData.Model;
using EODLoader.Services.Proxy;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;


namespace EODLoader.Services.AutoUpdate
{
    public class AutoUpdateService : IAutoUpdateService
    {
        private readonly string _autoUpdateUrl;
        private IWebProxyService _webProxyService;
        private IWebProxy _webProxy;
        private IConfigurationService _configurationService { get; set; }
        private ConfigurationModel _configuration { get; set; }

        public AutoUpdateService()
        {
            _configurationService = new ConfigurationService();
            _configuration = _configurationService.GetConfiguration();
            _webProxyService = new WebProxyService();
            _autoUpdateUrl = _configuration.AutoUpdateUrl;
            _webProxy = _webProxyService.GetWebProxy();
        }

        public bool Start()
        {
            string downloadUrl = CheckForUpdate();

            if (downloadUrl != null)
            {
                Update(downloadUrl);
                return true;
            }
            return false;
        }

        private string GetXMLString()
        {
            WebClient client = new WebClient();
            client.Proxy = _webProxy;

            return client.DownloadString("https://eodhistoricaldata.com/EODLoaderUpdate.xml");
        }

        private string CheckForUpdate()
        {
            string xml = GetXMLString();

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(UpdateModel));
            XmlTextReader xmlTextReader = new XmlTextReader(new StringReader(xml)) { XmlResolver = null };

            var result = (UpdateModel)xmlSerializer.Deserialize(xmlTextReader);

            Version currentVersion = Assembly.GetExecutingAssembly().GetName().Version;

            Version resultVersion = Version.Parse(result.CurrentVersion);

            if (resultVersion > currentVersion)
            {
                return result.DownloadURL;
            }

            return null;
        }

        private void Update(string downloadUrl)
        {
            WebClient client = new WebClient();
            client.Proxy = _webProxy;

            client.DownloadFile(downloadUrl, "updateSetup.msi");

            Process.Start("updateSetup.msi");
        }

    }
}
