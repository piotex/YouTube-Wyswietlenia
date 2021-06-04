using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace fox.My_code.db
{
    [XmlRoot("FoxUsers")]
    public class FoxUsers
    {
        [XmlElement("FoxUser")]
        public List<FoxUser> ListOfFoxUsers { get; set; }
    }
}
