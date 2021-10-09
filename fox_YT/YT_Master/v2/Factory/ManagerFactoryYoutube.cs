using System;
using System.Collections.Generic;
using System.Text;
using YT_Master.v2.Firefox.YoutubeSources;
using YT_Master.v2.Interfaces;

namespace YT_Master.v2.Factory
{
    public class ManagerFactoryYoutube
    {
        private Dictionary<EnumYoutubeSourceType, IYoutubeSource> ytSources = new Dictionary<EnumYoutubeSourceType, IYoutubeSource>() 
        {
            { EnumYoutubeSourceType.Direct, new YoutubeSourceDirect() },
        };

        public void WatchVideo(EnumYoutubeSourceType source)
        {
            ytSources[source].WatchVideo();
        }
    }
}
