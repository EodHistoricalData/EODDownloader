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
        private string _filePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "//EODLoader//Config.xml";
        private string _fileDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "//EODLoader";

        public ConfigurationService()
        {
            CheckConfigurationFile();
        }

        public ConfigurationModel GetConfiguration()
        {
            CheckConfigurationFile();

            ConfigurationModel _configurationModel = null;

            XmlSerializer serializer = new XmlSerializer(typeof(ConfigurationModel));

            StreamReader reader = new StreamReader(_filePath);
            _configurationModel = (ConfigurationModel)serializer.Deserialize(reader);
            reader.Close();

            return _configurationModel;
        }

        public void Save(ConfigurationModel configurationModel)
        {
            XmlSerializer writer =
            new XmlSerializer(typeof(ConfigurationModel));

            FileStream file = File.Create(_filePath);

            writer.Serialize(file, configurationModel);
            file.Close();
        }

        private void CheckConfigurationFile()
        {
            if (!File.Exists(_filePath))
            {
                CreateEmptyConfigurationFile();
            }
        }

        private void CreateEmptyConfigurationFile()
        {
            ConfigurationModel configurationModel = new ConfigurationModel();

            XmlSerializer writer =
            new XmlSerializer(typeof(ConfigurationModel));

            if (!Directory.Exists(_fileDirectory))
            {
                Directory.CreateDirectory(_fileDirectory);
            }

            FileStream file = File.Create(_filePath);

            writer.Serialize(file, configurationModel);
            file.Close();
        }
    }
}
