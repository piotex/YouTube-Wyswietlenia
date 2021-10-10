using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace YT_Master.v2.Firefox.YoutubeSources.Others
{
    public class YoutubeSourceMostPopular : YoutubeSource
    {
        public YoutubeSourceMostPopular()
        {
            Url = GetUrl(@"..\..\..\..\YT_Master\Files\Links\Others\YouTubeVideoMostPopular.txt");
        }
        public override void WatchVideo()
        {
            Navigate(Url);
            ClickConditionsAcceptation();
            ClickVideo();
            ClickVideoPlay();                                       //added to be sure that video will be played - tu sie przydalo!!!
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
                    objcts[objcts.Count - 2].Click();
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
