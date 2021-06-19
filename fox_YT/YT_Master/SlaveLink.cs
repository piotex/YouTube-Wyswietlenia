using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace YT_Master
{
    public class SlaveLink : Slave
    {
        private string URL_path_Link_my    = @"..\..\..\URL_Link_my.xml";
        private string URL_path_Link_other = @"..\..\..\URL_Link_other.xml";
        private List<List<string>> url_list_my;
        private List<List<string>> url_list_other;

        public SlaveLink()
        {
            url_list_my    = get_url(URL_path_Link_my);
            url_list_other = get_url(URL_path_Link_other);
            Init();
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
            for (int j = 0; j < url_list_my.Count; j++)
            {
                int time_my = getRandomNumberOfSeconds(60, int.Parse(url_list_my[j][1]));
                int time_other = getRandomNumberOfSeconds(60, int.Parse(url_list_other[j][1]));

                Console.WriteLine(DateTime.Now + " ------------------------------");
                Console.WriteLine("SlaveLink:: Other_time: " + (time_other / 60).ToString() + "min " + (time_other % 60).ToString() + "sec ");
                Console.WriteLine("SlaveLink:: My_time:    " + (time_my / 60).ToString() + "min " + (time_my % 60).ToString() + "sec ");

                Work_tmp(time_my, url_list_my[j][0]);
                Work_tmp(time_other, url_list_other[j][0]);

                if ((j) % 3 == 2)                                                                                                   // co trzeci klip zresetuj przegladarke
                {
                    Console.WriteLine("SlaveLink::New Firefox -----------------------");
                    watcher.driver.Close();
                    Init();
                }
            }
        }
    }
}
