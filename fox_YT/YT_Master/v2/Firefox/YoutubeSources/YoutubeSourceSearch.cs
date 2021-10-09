using System;
using System.Collections.Generic;
using System.Text;
using YT_Master.v2.Interfaces;

namespace YT_Master.v2.Firefox.YoutubeSources
{
    public class YoutubeSourceSearch : YoutubeSource
    {
        public YoutubeSourceSearch()
        {
            Url = GetUrl(@"..\..\..\..\YT_Master\Files\Links\YouTubeVideoSearchLink.txt");
        }
    }
}
