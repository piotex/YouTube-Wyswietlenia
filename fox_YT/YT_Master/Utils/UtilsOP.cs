using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace YT_Master.Utils
{
    public static class UtilsOP
    {
        public static void SaveToTmpFile(ref string data)
        {
            using (StreamWriter writer = new StreamWriter(@"..\..\..\..\YT_Master\Files\tmp.txt"))
            {
                writer.Write(data); 
            }
        }
    }
}
