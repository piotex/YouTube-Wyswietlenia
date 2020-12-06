using fox.My_code.browser;
using fox.My_code.browser.basics.classes;
using Gecko.DOM;
using Gecko.WebIDL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fox.My_code.ySense
{
    public class ySense_client : Firefox_Client
    {
        public ySense_client()
        {
            navigation_path = @"https://www.ysense.com";
            login_path = @"https://www.ysense.com/login";

        }

        public override int doSth()
        {
            string body = Document.Body.InnerHtml;

            return 1;
        }

        public override int LogIn()
        {
            Navigate_Client(login_path);
            string body = Document.Body.InnerHtml;

            GeckoInputElement username_TextBox = new GeckoInputElement(Document.GetElementById("username").DomObject);
            username_TextBox.Value = "piotex";
            GeckoInputElement pwd_TextBox = new GeckoInputElement(Document.GetElementById("password").DomObject);
            pwd_TextBox.Value = "start12345";

            IsCompleted();

            GeckoButtonElement button = new GeckoButtonElement(Document.GetElementsByClassName("sbutton large")[0].DomObject);
            if(button != null)
                button.Click();

            MessageBox.Show("Loaded");
            return 1;
        }

        public override int Navigate_toMain()
        {
            Navigate_Client(navigation_path);
            return 1;
        }
    }
}
