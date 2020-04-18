using System.Net;

namespace EODLoader.Services.Proxy
{
    public interface IWebProxyService
    {
        bool CheckConnection();
        IWebProxy GetWebProxy();
    }
}
