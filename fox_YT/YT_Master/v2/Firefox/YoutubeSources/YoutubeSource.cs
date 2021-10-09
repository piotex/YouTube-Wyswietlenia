using System;
using System.Collections.Generic;
using System.Text;
using YT_Master.v2.Interfaces;

namespace YT_Master.v2.Firefox.YoutubeSources
{
    public class YoutubeSource : YoutubeGeneralOperationsFirefoxBot, IYoutubeSource
    {
        public void WatchVideo()
        {
            Navigate(Url);
            ClickConditionsAcceptation();
            ClickVideoPlay();                                       //added to be sure that video will be played
        }

        public void StartFirefox()
        {
            StartBotFirefox();
        }
    }
}
