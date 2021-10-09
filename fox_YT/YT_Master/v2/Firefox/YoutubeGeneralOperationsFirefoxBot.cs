using System;
using System.Collections.Generic;
using System.Text;

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
    }
}
