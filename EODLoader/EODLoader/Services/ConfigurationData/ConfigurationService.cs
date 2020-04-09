using EODLoader.Logs;
using EODLoader.Services.ConfigurationData.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace EODLoader.Services.ConfigurationData
{
    public class ConfigurationService : IConfigurationService
    {
        private string _filePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\EODLoader\Config.xml";
        private string _fileDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\EODLoader";

        public ConfigurationService()
        {
            CheckConfigurationFile();
        }

        public ConfigurationModel GetConfiguration()
        {
            CheckConfigurationFile();

            ConfigurationModel _configurationModel = null;

            XmlSerializer serializer = new XmlSerializer(typeof(ConfigurationModel));

            using (StreamReader reader = new StreamReader(_filePath))
            {
                _configurationModel = (ConfigurationModel)serializer.Deserialize(reader);
                reader.Close();
            }

            return _configurationModel;
        }

        public void Save(ConfigurationModel configurationModel)
        {
            try
            {
                XmlSerializer writer =
                    new XmlSerializer(typeof(ConfigurationModel));

                using (FileStream file = File.Create(_filePath))
                {
                    writer.Serialize(file, configurationModel);
                    file.Close();
                }

            }
            catch (Exception ex)
            {
                Logger.LogError(ex, ex.StackTrace);
            }
        }

        private void CheckConfigurationFile()
        {
            if (!File.Exists(_filePath))
            {
                CreateEmptyConfigurationFile();
            }
            else
            {
                try
                {
                    ConfigurationModel _configurationModel = null;

                    XmlSerializer serializer = new XmlSerializer(typeof(ConfigurationModel));

                    using (StreamReader reader = new StreamReader(_filePath))
                    {
                        _configurationModel = (ConfigurationModel)serializer.Deserialize(reader);
                        reader.Close();
                    }
                }
                catch (Exception ex)
                {
                    Logger.LogError(ex, ex.StackTrace);
                }
            }
        }

        private void CreateEmptyConfigurationFile()
        {
            try
            {
                ConfigurationModel configurationModel = new ConfigurationModel();

                configurationModel.LogFilePath = _fileDirectory + @"\Logs";

                XmlSerializer writer =
                new XmlSerializer(typeof(ConfigurationModel));

                if (!Directory.Exists(_fileDirectory))
                {
                    Directory.CreateDirectory(_fileDirectory);
                }

                if (!Directory.Exists(configurationModel.LogFilePath))
                {
                    Directory.CreateDirectory(configurationModel.LogFilePath);
                }

                using (FileStream file = File.Create(_filePath))
                {
                    writer.Serialize(file, configurationModel);
                    file.Close();
                };
            }
            catch (Exception ex)
            {
                Logger.LogError(ex, ex.StackTrace);
            }
        }
    }
}
