using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using System.Xml;

namespace YT_Master
{
    public class Slave
    {
        private string url_error = @"https://www.youtube.com/watch?v=5BZLz21ZS_Y";    // initial - error
        private int ms_to_sec = 1000;

        protected FirefoxWatcher watcher;

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
        public void Work_tmp(int time, string url)
        {
            watcher.Navigate(url);
            watcher.ClickButton_PlayVideo();
            Thread.Sleep(time * ms_to_sec);
        }
        public void Init()
        {
            watcher = new FirefoxWatcher();
            watcher.Navigate(url_error);
            watcher.ClickButton_ZgadzamSie();
            watcher.ClickButton_PersonalizacjaCookies();
        }
    }
}
