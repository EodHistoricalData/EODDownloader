using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace EODLoader.Services.Proxy
{
    public class WebProxyService : IWebProxyService
    {
        private string _webAddress { get; }
        private string _userName { get; }
        private string _userPassword { get; }
        private bool _proxyCredentialsIsUsed { get; }
        private bool _proxyIsUsed { get; }

        public WebProxyService()
        {
            _webAddress = Properties.Settings.Default.proxyWebAddress;
            _userName = Properties.Settings.Default.proxyUserName;
            _userPassword = Properties.Settings.Default.proxyPassword;
            _proxyCredentialsIsUsed = Properties.Settings.Default.proxyCredentialsIsUsed;
            _proxyIsUsed = Properties.Settings.Default.proxyIsUsed;
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

                HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create("https://ya.ru/");
                webRequest.Proxy = proxy;
                WebResponse response = webRequest.GetResponse();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }

        public IWebProxy GetWebProxy()
        {
            if (_proxyIsUsed)
            {
                IWebProxy proxy = new WebProxy(_webAddress);
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
