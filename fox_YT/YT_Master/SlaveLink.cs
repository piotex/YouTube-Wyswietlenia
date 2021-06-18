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
        private string url_error = @"https://www.youtube.com/watch?v=5BZLz21ZS_Y";    // initial - error
        private int ms_to_sec = 1000;
        private List<List<string>> url_list_my;
        private List<List<string>> url_list_other;

        public SlaveLink()
        {
            url_list_my    = get_url(URL_path_Link_my);
            url_list_other = get_url(URL_path_Link_other);
            watcher = new FirefoxWatcher();
            watcher.Navigate(url_error);
            watcher.ClickButton_ZgadzamSie();
        }
        public void Watch()
        {
            for (int i = 0; i < 100; i++)
            {
                for (int j = 0; j < url_list_my.Count; j++)
                {
                    Work(j);
                }
            }
        }
        public void Work(int index)
        {
            int time_my    = getRandomNumberOfSeconds(60, int.Parse(url_list_my[index][1]));
            int time_other = getRandomNumberOfSeconds(60, int.Parse(url_list_other[index][1]));

            Console.WriteLine(DateTime.Now + " ------------------------------");
            Console.WriteLine("SlaveLink:: Other_time: " + (time_other / 60).ToString() + "min " + (time_other % 60).ToString() + "sec ");
            Console.WriteLine("SlaveLink:: My_time:    " + (time_my / 60).ToString()    + "min " + (time_my % 60).ToString()    + "sec ");

            Work_tmp(time_other, url_list_my[index][0]);
            Work_tmp(time_my,    url_list_other[index][0]);
        }
        public void Work_tmp(int time_sec, string url)
        {
            watcher.Navigate(url);
            watcher.ClickButton_PlayVideo();
            Thread.Sleep(time_sec * ms_to_sec);
        }

        private void update_List_other(ref List<List<string>> url_list_other)
        {
            int max_rand_number = 44;
            for (int i = 0; i < url_list_other.Count; i++)
            {
                url_list_other[i][0] += new Random().Next(1, max_rand_number);
            }
        }

    }
}
