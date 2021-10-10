using System;
using System.Collections.Generic;
using System.Text;

namespace YT_Master.v2.Firefox.YoutubeSources.Others
{
    public class YoutubeSourceGermanRap : YoutubeSource
    {
        public YoutubeSourceGermanRap()
        {
            Url = GetUrl(@"..\..\..\..\YT_Master\Files\Links\Others\YouTubeVideoGermanRap.txt") + new Random().Next(1,70);
        }
    }
}
