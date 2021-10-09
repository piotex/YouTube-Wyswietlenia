using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace YT_Master.v2.Firefox.YoutubeSources.Specyfic
{
    public class YoutubeSourceChannelPage : YoutubeSource
    {
        public YoutubeSourceChannelPage()
        {
            Url = GetUrl(@"..\..\..\..\YT_Master\Files\Links\Specyfic\YouTubeVideoChannelPageLink.txt");
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
                System.Collections.ObjectModel.ReadOnlyCollection<IWebElement> objcts = driver.FindElementsByClassName("ytd-grid-video-renderer");
                objcts[0].Click();
            }
            catch (Exception ee)
            {
                //ConsolePlotError(ee, "YoutubeSourceChannelPage : ClickVideo()");
                return false;
            }
            return true;
        }
        public override bool ClickConditionsAcceptation()
        {
            try
            {
                System.Collections.ObjectModel.ReadOnlyCollection<IWebElement> objcts = driver.FindElementsByTagName("button");
                for (int i = objcts.Count - 1; i >= 0; i--)
                {
                    if (objcts[i].Text == "ZGADZAM SIĘ")
                    {
                        objcts[i].Click();
                        return true;
                    }
                }
            }
            catch (Exception ee)
            {
                ConsolePlotError(ee, "YoutubeSourceChannelPage : ClickConditionsAcceptation()");
                return false;
            }
            return true;
        }
    }
}
