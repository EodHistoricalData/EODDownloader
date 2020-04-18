using EODLoader.Services.AutoUpdate.Models;
using EODLoader.Services.ConfigurationData;
using EODLoader.Services.ConfigurationData.Model;
using EODLoader.Services.Proxy;
using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Reflection;
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
        private IWebProxy _webProxy;
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


        public async Task Start(string downloadUrl)
        {

            Update(downloadUrl);

        }

        private string GetXMLString()
        {
            WebClient client = new WebClient();
            client.Proxy = _webProxy;

            return client.DownloadString("https://eodhistoricaldata.com/EODLoaderUpdate.xml");
        }

        public string CheckForUpdate()
        {
<<<<<<< HEAD
            try
            {
                string xml = GetXMLString();

                if (xml == null)
                {
                    return null;
                }
=======
            string xml = GetXMLString();

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(UpdateModel));
            XmlTextReader xmlTextReader = new XmlTextReader(new StringReader(xml)) { XmlResolver = null };
>>>>>>> parent of aebf7c5... added loger and change config

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
                Application.Exit();
            }
            catch (Exception ex)
            {
                Logger.LogError(ex, ex.StackTrace);
            }
        }

    }
}
