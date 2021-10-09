using System;
using System.Collections.Generic;
using System.Text;
using YT_Master.v2.Interfaces;

namespace YT_Master.v2.Firefox.YoutubeSources
{
    public class YoutubeSourceFacebook : YoutubeSource
    {
        public YoutubeSourceFacebook()
        {
            Url = GetUrl(@"..\..\..\..\YT_Master\Files\Links\Outside\YouTubeVideoFacebookLink.txt");
        }
    }
}
