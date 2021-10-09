using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using YT_Master.v2.Interfaces;

namespace YT_Master.v2.Firefox.YoutubeSources
{
    public class YoutubeSourceDirect : YoutubeSource
    {
        public YoutubeSourceDirect()
        {
            Url = GetUrl(@"..\..\..\..\YT_Master\Files\Links\Outside\YouTubeVideoDirectLink.txt");
        }
    }
}
