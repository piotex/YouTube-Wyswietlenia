using Gecko;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fox
{
    public partial class Form_Slave : Form
    {
        public int x;    //can be private too
        public string y; //can be private too

        public Form_Slave(string url, string email, string pwd)
        {
            //GeckoWebBrowser browser = new GeckoWebBrowser();
            //browser.FrameEventsPropagateToMainWindow = false;
            //browser.Location = new System.Drawing.Point(0, 0);
            //browser.Name = "FoX";
            //browser.Size = new System.Drawing.Size(1920, 1080);
            //browser.TabIndex = 0;
            ////browser.UseHttpActivityObserver = false;
            //Controls.Add(browser);
            //browser.Navigate(@"https://www.youtube.com/watch?v=se1zpkvDVAs");

            WebBrowser browser = new WebBrowser();
            browser.Location = new System.Drawing.Point(0, 0);
            browser.Size = new System.Drawing.Size(1920, 1080); 
            Controls.Add(browser);
            browser.Navigate(url);
        }

        //define some function which changes defined global values
    }
}
