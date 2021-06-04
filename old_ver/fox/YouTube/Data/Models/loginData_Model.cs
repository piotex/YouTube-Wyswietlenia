using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace fox.YouTube.Data.Models
{
    [XmlRoot("YouTubeUser")]
    public class loginData_Model
    {
        [XmlElement("Id")]
        public string Id { get; set; }
        [XmlElement("Login")]
        public string Login { get; set; }
        [XmlElement("Pwd")]
        public string Pwd { get; set; }
    }
}
