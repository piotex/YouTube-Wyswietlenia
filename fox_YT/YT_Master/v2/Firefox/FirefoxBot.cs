using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace YT_Master.v2.Firefox
{
    public class FirefoxBot
    {
        public FirefoxDriver driver;
        protected string Url;

        public FirefoxBot()
        {
            FirefoxDriverService service = FirefoxDriverService.CreateDefaultService(".", "geckodriver.exe");
            service.FirefoxBinaryPath = @"C:\Program Files\Mozilla Firefox\firefox.exe -private ";
            driver = new FirefoxDriver(service);

            Url = GetUrl();
        }

        protected string GetUrl(string path = @"..\..\..\..\YT_Master\Files\YouTubeVideoLink.txt")
        {
            return System.IO.File.ReadAllText(path);
        }
    }
}
