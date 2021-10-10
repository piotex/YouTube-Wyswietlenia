using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using YT_Master.v2.Interfaces;

namespace YT_Master.v2.Firefox.YoutubeSources
{
    public class YoutubeSourceGoogle : YoutubeSource
    {
        public YoutubeSourceGoogle()
        {
            Url = GetUrl(@"..\..\..\..\YT_Master\Files\Links\Outside\YouTubeVideoGoogleLink.txt");
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
                System.Collections.ObjectModel.ReadOnlyCollection<IWebElement> objcts = driver.FindElementsByClassName("yuRUbf");

                for (int i = 0; i < objcts.Count; i++)
                {
                    try
                    {
                        Console.WriteLine(objcts[i].Text);
                    }
                    catch (Exception)
                    {
                    }
                }
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
                    if (objcts[i].Text == "Zgadzam się")
                    {
                        objcts[i].Click();
                        return true;
                    }
                    objcts[objcts.Count-2].Click();
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
