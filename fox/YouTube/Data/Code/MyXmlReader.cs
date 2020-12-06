using fox.My_code.db;
using fox.YouTube.Data.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace fox.YouTube.Data.Code
{
    public class MyXmlReader<T>
    {
        public static T Read(string path)
        {
            //string path = @"C:\Users\pkubo\OneDrive\Desktop\YouTubeMaster\fox\XML\loginData.xml";


            XmlSerializer serializer = new XmlSerializer(typeof(T));
            using (FileStream fileStream = new FileStream(path, FileMode.Open))
            {
                return (T)serializer.Deserialize(fileStream);
            }
        }
    }
}
