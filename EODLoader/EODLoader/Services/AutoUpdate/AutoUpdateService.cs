using EODLoader.Forms;
using EODLoader.Logs;
using EODLoader.Services.AutoUpdate.Models;
using EODLoader.Services.ConfigurationData;
using EODLoader.Services.ConfigurationData.Model;
using EODLoader.Services.Proxy;
using Serilog;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;


namespace EODLoader.Services.AutoUpdate
{
    public class AutoUpdateService : IAutoUpdateService
    {
        private readonly string _autoUpdateUrl;
        private IWebProxyService _webProxyService;
        private WebProxy _webProxy;
        private IConfigurationService _configurationService { get; set; }
        private ConfigurationModel _configuration { get; set; }

        private string setupPath = $@"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}\EODLoader\updateSetup.msi";

        public AutoUpdateService()
        {
            _configurationService = new ConfigurationService();
            _configuration = _configurationService.GetConfiguration();
            _webProxyService = new WebProxyService();
            _autoUpdateUrl = _configuration.AutoUpdateUrl;
            _webProxy = _webProxyService.GetWebProxy();
        }

        
        public async Task<bool> Start()
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
            try
            {
                WebClient client = new WebClient();
                client.Proxy = _webProxy;
                return client.DownloadString("https://eodhistoricaldata.com/EODLoaderUpdate.xml");
            }
            catch (Exception ex)
            {
                Logger.LogError(ex, ex.StackTrace);
                if (_configuration.ProxyIsUsed == true)
                {
                    _configuration.ProxyIsUsed = false;
                    _configurationService.Save(_configuration);
                }
                return null;
            }
        }

        private string CheckForUpdate()
        {
            try
            {
                string xml = GetXMLString();

                if (xml == null)
                {
                    return null;
                }

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
            catch (Exception ex)
            {
                Logger.LogError(ex, ex.StackTrace);

                return null;
            }
        }

        private void Update(string downloadUrl)
        {
            WebClient client = new WebClient();
            client.Proxy = _webProxy;

            byte[] sutupBytes = client.DownloadData(downloadUrl);

            try
            {
                using (var fs = new FileStream(setupPath, FileMode.Create, FileAccess.Write))
                {
                    fs.Write(sutupBytes, 0, sutupBytes.Length);
                }

                Process.Start(setupPath);
            }
            catch (Exception ex)
            {
                Logger.LogError(ex, ex.StackTrace);
            }
        }

    }
}
