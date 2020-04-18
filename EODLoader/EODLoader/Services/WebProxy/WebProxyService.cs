using EODLoader.Logs;
using EODLoader.Services.ConfigurationData;
using EODLoader.Services.ConfigurationData.Model;
using System;
using System.Net;

namespace EODLoader.Services.Proxy
{
    public class WebProxyService : IWebProxyService
    {
        private string _webAddress { get; }
        private string _userName { get; }
        private string _userPassword { get; }
        private bool _proxyCredentialsIsUsed { get; }
        private bool _proxyIsUsed { get; }

        private IConfigurationService _configurationService { get; set; }
        private ConfigurationModel _configuration { get; set; }

        public WebProxyService()
        {
            _configurationService = new ConfigurationService();
            _configuration = _configurationService.GetConfiguration();
            _webAddress = _configuration.ProxyWebAddress;
            _userName = _configuration.ProxyUserName;
            _userPassword = _configuration.ProxyPassword;
            _proxyCredentialsIsUsed = _configuration.ProxyCredentialsIsUsed;
            _proxyIsUsed = _configuration.ProxyIsUsed;
        }

        public WebProxyService(string webAddress, string userName,
                               string userPassword, bool proxyCredentialIsUsed,
                               bool proxyIsUsed)
        {
            _webAddress = webAddress;
            _userName = userName;
            _userPassword = userPassword;
            _proxyCredentialsIsUsed = proxyCredentialIsUsed;
            _proxyIsUsed = proxyIsUsed;
        }

        public bool CheckConnection()
        {
            try
            {
                IWebProxy proxy = GetWebProxy();

                if (proxy == null)
                {
                    return false;
                }

                HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create("https://eodhistoricaldata.com");
                webRequest.Proxy = proxy;
                WebResponse response = webRequest.GetResponse();

                return true;
            }
            catch (Exception ex)
            {
                Logger.LogError(ex, ex.StackTrace);
                return false;
            }

        }

        public WebProxy GetWebProxy()
        {
            if (_proxyIsUsed)
            {
                WebProxy proxy = new WebProxy(_webAddress);
                if (_proxyCredentialsIsUsed)
                {
                    proxy.Credentials = new NetworkCredential(_userName, _userPassword);
                }
                return proxy;
            }
            return null;
        }
    }
}
