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
            Console.WriteLine("\n\n----------------------");
            Console.WriteLine(eeee.Message);
            Console.WriteLine("----------------------\n\n");
        }

        public bool Navigate(string url)
        {
            double wait_time = 5;
            try
            {
                driver.Navigate().GoToUrl(url);
                Thread.Sleep(500);                                                                                          //wprowadzilem male opuznienie zeby miec pewnosc zaladowania sie okna z komunikatem o zgodzie na Cookies 
                                                                                                                            //TODO - check that page is ready - stackowerflow search!
                //driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(wait_time);
            }
            catch (Exception ee)
            {
                ConsolePlotError(ee, "YoutubeGeneralOperationsFirefoxBot : Navigate(string url)");
                return false;
            }
            return true;
        }
    }
}
