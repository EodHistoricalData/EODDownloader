using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EODLoader.Services.AutoUpdate
{
    public interface IAutoUpdateService
    {
        string CheckForUpdate();
        Task Start(string downloadUrl);
    }
}
