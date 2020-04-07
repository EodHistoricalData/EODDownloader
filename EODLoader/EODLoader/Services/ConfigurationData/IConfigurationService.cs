using EODLoader.Services.ConfigurationData.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EODLoader.Services.ConfigurationData
{
    public interface IConfigurationService
    {
        ConfigurationModel GetConfiguration();
        void Save(ConfigurationModel configurationModel);
    }
}
