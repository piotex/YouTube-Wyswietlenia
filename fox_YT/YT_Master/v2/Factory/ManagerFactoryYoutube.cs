using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using YT_Master.v2.Firefox.YoutubeSources;
using YT_Master.v2.Firefox.YoutubeSources.Others;
using YT_Master.v2.Firefox.YoutubeSources.Specyfic;
using YT_Master.v2.Interfaces;

namespace YT_Master.v2.Factory
{
    public class ManagerFactoryYoutube
    {
        private int index;
        private List<int> watchingTimes;
        public ManagerFactoryYoutube()
        {
            index = 0;
            watchingTimes = getWatchTimeList(@"..\..\..\..\YT_Master\Files\WatchingTimes.txt");
        }
        public void StartWatchingVideo()
        {
            //foreach (EnumYoutubeSourceType source in Enum.GetValues(typeof(EnumYoutubeSourceType)))
            {
                Thread thread = new Thread(() => WatchVideo(EnumYoutubeSourceType.Google));
                //Thread thread = new Thread(() => WatchVideo(source));
                //thread.Name = source.ToString();
                thread.Start();
            }
        }
        public void WatchVideo(EnumYoutubeSourceType source)
        {
            while (true)
            {
                int sleepTime = getSleepTime();
                IYoutubeSource isource = getNewIYoutubeSource(source);
                Console.WriteLine(Thread.CurrentThread.Name + " _sleep_: " + sleepTime / 1000 + "s");

                isource.StartFirefox();
                isource.WatchVideo();
                Thread.Sleep(sleepTime);
                isource.KillFirefox();
            }
        }
        

        private int getSleepTime()
        {
            lock (watchingTimes)
            {
                int tmp = watchingTimes[index] * 1000;
                if (index > watchingTimes.Count - 1)
                    Thread.CurrentThread.Abort();
                else
                    index++;
                return tmp;
            }
        }
        private IYoutubeSource getNewIYoutubeSource(EnumYoutubeSourceType type)
        {
            switch (type)
            {
                case EnumYoutubeSourceType.ChannelPage:
                    return new YoutubeSourceChannelPage();
                case EnumYoutubeSourceType.Direct:
                    return new YoutubeSourceDirect();
                case EnumYoutubeSourceType.Facebook:
                    return new YoutubeSourceFacebook();
                case EnumYoutubeSourceType.Google:
                    return new YoutubeSourceGoogle();
                case EnumYoutubeSourceType.YTSearch:
                    return new YoutubeSourceYTSearch();
                case EnumYoutubeSourceType.GermanRap:
                    return new YoutubeSourceGermanRap();
                default:
                    return new YoutubeSourceYTSearch();
            }
        }
        private List<int> getWatchTimeList(string path)
        {
            string tmp1 = System.IO.File.ReadAllText(path);
            string[] tmp2 = tmp1.Split("\r\n");
            List<string> tmp3 = new List<string>(tmp2);
            tmp3.RemoveAt(tmp3.Count-1);
            return tmp3.Select(s => int.Parse(s)).ToList();
        }
    }
}
