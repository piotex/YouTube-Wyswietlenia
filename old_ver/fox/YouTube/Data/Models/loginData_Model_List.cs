using fox.My_code.db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace fox.YouTube.Data.Models
{
    [XmlRoot("YouTubeUser_List")]
    public class loginData_Model_List
    {
        [XmlElement("YouTubeUser")]
        public List<loginData_Model> YouTubeProfile_list { get; set; }
    }

}
