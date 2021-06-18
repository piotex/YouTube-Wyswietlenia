using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using System.Xml;

namespace YT_Master
{
    public class Slave
    {
        //C:\Users\Piotr\Documents\GitHub\YouTubeMaster\fox_YT\YT_Master\URL_List.xml

        protected FirefoxWatcher watcher;
        //protected string parameters;
        //protected System.Diagnostics.Process process;
        //--------------------------------------------------------------//

        public string PatchToExe;

        public int getRandomNumberOfSeconds(int min_time_s = 1*60, int max_time_s = 45*60)
        {
            return new Random().Next(min_time_s, max_time_s);
        }

        //todo - zamienic typ na Dictionary<enum,string>
        public List<List<string>> get_url(string path)
        {
            List<List<string>> tmp = new List<List<string>>();
            XmlDocument doc = new XmlDocument();
            doc.Load(path);

            for (int i = 0; i < doc.DocumentElement.ChildNodes.Count; i++)
            {
                tmp.Add(new List<string>());
                XmlNode parent_node = doc.DocumentElement.ChildNodes[i];
                for (int j = 0; j < parent_node.ChildNodes.Count; j++)
                {
                    XmlNode child_node = parent_node.ChildNodes[j];
                    tmp[i].Add(child_node.InnerText);
                }
            }
            return tmp;
        }




        /*
        public virtual void Work(int time_to_live_s)
        {
            Start();
            Thread.Sleep(time_to_live_s * 1000);
            Stop();
        }
        public virtual void Start()
        {
            Console.WriteLine("_Start: Slave: " + PatchToExe);
            process = System.Diagnostics.Process.Start(PatchToExe, parameters);
        }

        public virtual void Stop()
        {
            Console.WriteLine("_Stop Processes");

            process.Kill();

            Process[] AllProcesses = Process.GetProcesses();
            foreach (var process in AllProcesses)
            {
                if (process.MainWindowTitle != "")
                {
                    string s = process.ProcessName.ToLower();
                    if ( s == "firefox")                                                //  s == "iexplore" || s == "iexplorer" || s == "chrome" ||
                        process.Kill();
                }
            }
        }
        */


    }
}
