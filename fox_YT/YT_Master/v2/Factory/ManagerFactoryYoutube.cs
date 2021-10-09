using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using YT_Master.v2.Firefox.YoutubeSources;
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
            watchingTimes = new List<int>
            {
                110,
                115,
                13,
                112,
                130,
                144,
                122
            };
        }
        public void StartWatchingVideo()
        {
            foreach (EnumYoutubeSourceType source in Enum.GetValues(typeof(EnumYoutubeSourceType)))
            {
                Thread thread = new Thread(() => WatchVideo(source));
                thread.Name = source.ToString();
                thread.Start();
            }
        }
        public void WatchVideo(EnumYoutubeSourceType source)
        {
            int sleepTime = getSleepTime();
            IYoutubeSource isource = getNewIYoutubeSource(source);
            Console.WriteLine(Thread.CurrentThread.Name + " _sleep_: " + sleepTime/1000 + "s");

            isource.StartFirefox();
            isource.WatchVideo();
            Thread.Sleep(sleepTime);
            isource.KillFirefox();
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
                default:
                    return new YoutubeSourceYTSearch();
            }
        }
    }
}
