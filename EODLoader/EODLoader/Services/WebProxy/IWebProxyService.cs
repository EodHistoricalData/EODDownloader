using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace EODLoader.Services.Proxy
{
    public interface IWebProxyService
    {
        bool CheckConnection();
        IWebProxy GetWebProxy();
    }
}
