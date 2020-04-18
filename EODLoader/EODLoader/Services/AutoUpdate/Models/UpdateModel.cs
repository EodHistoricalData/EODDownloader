using System.Xml.Serialization;

namespace EODLoader.Services.AutoUpdate.Models
{
    [XmlRoot("item")]
    public class UpdateModel
    {
        [XmlElement("url")]
        public string DownloadURL { get; set; }

        [XmlElement("version")]
        public string CurrentVersion { get; set; }
    }
}
