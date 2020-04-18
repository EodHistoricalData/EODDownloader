using EODLoader.Services.ConfigurationData.Model;

namespace EODLoader.Services.ConfigurationData
{
    public interface IConfigurationService
    {
        ConfigurationModel GetConfiguration();
        void Save(ConfigurationModel configurationModel);
    }
}
