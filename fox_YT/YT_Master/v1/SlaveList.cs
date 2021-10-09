using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Xml;

namespace YT_Master
{
    public class SlaveList : Slave
    {
        private string URL_path_List = @"..\..\..\URL_List.xml";
        private string url_other;  
        private string url_my;
        private int count;

        public SlaveList()
        {
            List<List<string>> url_list = get_url(URL_path_List);
            Init();

            url_other = url_list[0][0];
            url_my    = url_list[1][0];
            count     = int.Parse(url_list[0][1]);
        }
        public void Watch()
        {
            for (int i = 0; i < 100; i++)
            {
                Work();
            }
        }
        public void Work()
        {
            int time_my    = getRandomNumberOfSeconds(60, 207 * count);  // srednio przypada 207s na jeden odcinek
            int time_other = getRandomNumberOfSeconds(60, 207 * count);  // srednio przypada 207s na jeden odcinek

            Console.WriteLine(DateTime.Now + " ------------------------------");
            Console.WriteLine("SlaveList:: Other_time: " +   (time_other/60).ToString()+" min");
            Console.WriteLine("SlaveList:: My_time:    " +  (time_my/60).ToString()   +" min");

            Work_tmp(time_other, url_other);
            Work_tmp(time_my   , url_my);

            Console.WriteLine("SlaveList::New Firefox -----------------------");
            watcher.driver.Close();
            Init();
        }

    }
}
