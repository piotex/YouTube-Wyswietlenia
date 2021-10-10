using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace YT_Master.v2.Firefox
{
    public class YoutubeGeneralOperationsFirefoxBot : FirefoxBot
    {

        public void ConsolePlotError(Exception eeee, string place = "")
        {
            Console.WriteLine("----------------------");
            Console.WriteLine(place);
            Console.WriteLine("- - - - - -");
            Console.WriteLine(eeee.Message);
            Console.WriteLine("----------------------");
        }

        public bool Navigate(string url)
        {
            try
            {
                driver.Navigate().GoToUrl(url);
                                                                                                                            //TODO - check that page is ready - stackowerflow search!
                //Utils.UtilsOP.SaveToTmpFile(ref driver.FindElement(By.TagName("body")).GetAttribute("innerHTML"));
            }
            catch (Exception ee)
            {
                ConsolePlotError(ee, "YoutubeGeneralOperationsFirefoxBot : Navigate(string url)");
                return false;
            }
            return true;
        }
        public virtual bool ClickConditionsAcceptation()
        {
            try
            {
                System.Collections.ObjectModel.ReadOnlyCollection<IWebElement> objcts = driver.FindElementsById("button");
                for (int i = objcts.Count - 1; i >= 0; i--)
                {
                    if (objcts[i].Text == "ZGADZAM SIĘ")
                    {
                        objcts[i].Click();
                        return true;
                    }
                }
                objcts[objcts.Count-2].Click();
            }
            catch (Exception ee)
            {
                ConsolePlotError(ee, "YoutubeGeneralOperationsFirefoxBot : ClickConditionsAcceptation()");
                return false;
            }
            return true;
        }
        public bool ClickVideoPlay()
        {
            try
            {
                System.Collections.ObjectModel.ReadOnlyCollection<IWebElement> objcts = driver.FindElementsByClassName("ytp-large-play-button");
                objcts[0].Click();
            }
            catch (Exception ee)
            {
                //ConsolePlotError(ee, "YoutubeGeneralOperationsFirefoxBot : ClickVideoPlay()");
                return false;
            }
            return true;
        }




    }
}
