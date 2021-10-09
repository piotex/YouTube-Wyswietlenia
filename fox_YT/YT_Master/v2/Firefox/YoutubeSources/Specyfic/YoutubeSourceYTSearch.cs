using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using YT_Master.v2.Interfaces;

namespace YT_Master.v2.Firefox.YoutubeSources
{
    public class YoutubeSourceYTSearch : YoutubeSource
    {
        public YoutubeSourceYTSearch()
        {
            Url = GetUrl(@"..\..\..\..\YT_Master\Files\Links\Specyfic\YouTubeVideoYTSearchLink.txt");
        }

        public override void WatchVideo()
        {
            Navigate(Url);
            ClickConditionsAcceptation();
            ClickVideo();
            ClickVideoPlay();                                       //added to be sure that video will be played
        }

        private bool ClickVideo()
        {
            try
            {
                System.Collections.ObjectModel.ReadOnlyCollection<IWebElement> objcts = driver.FindElementsByClassName("ytd-video-renderer");
                objcts[0].Click();
            }
            catch (Exception ee)
            {
                ConsolePlotError(ee, "YoutubeSourceYTSearch : ClickVideo()");
                return false;
            }
            return true;
        }
    }
}
