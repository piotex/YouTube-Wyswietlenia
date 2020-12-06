using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace fox.My_code.db
{
    public class FoxXmlData
    {
        public void Read()
        {
			string path = @"C:\Users\pkubo\OneDrive\Desktop\fox\fox\Xml_Data\main_data.xml";

            XmlSerializer serializer = new XmlSerializer(typeof(FoxUsers));
            using (FileStream fileStream = new FileStream(path, FileMode.Open))
            {
                FoxUsers result = (FoxUsers)serializer.Deserialize(fileStream);
            }
        }
    }
}
