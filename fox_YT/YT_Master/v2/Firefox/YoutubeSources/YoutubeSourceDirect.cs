using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using YT_Master.v2.Firefox.YoutubeOperations;
using YT_Master.v2.Interfaces;

namespace YT_Master.v2.Firefox.YoutubeSources
{
    public class YoutubeSourceDirect : YoutubeOperationDirect, IYoutubeSource
    {
        public void WatchVideo()
        {
            Navigate(Url);
            ClickConditionsAcceptation();
            ClickVideoPlay();                                       //added to be sure that video will be played
        }
    }
}
