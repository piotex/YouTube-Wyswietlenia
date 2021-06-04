using Gecko;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fox.My_code.browser.basics.classes
{
    public abstract class Firefox_Client : Firefox_Base
    {
        private bool ready ;
        protected string navigation_path;
        protected string login_path;

        public Firefox_Client()
        {
            ready = false;
            DocumentCompleted += documentCompleted;
            CreateWindow += browser_CreateWindow;

        }
        private void browser_CreateWindow(object sender, GeckoCreateWindowEventArgs e)
        {
            // tu mozna kontrolowac nowowyskakujaca strone
            Rectangle rect = System.Windows.Forms.Screen.GetWorkingArea(this);
            e.InitialWidth = rect.Width;
            e.InitialHeight = rect.Height;

        }
        protected void documentCompleted(object sender, EventArgs e)
        {
            ready = true;
        }
        protected int IsCompleted()
        {
            while (!ready)
            {
                System.Windows.Forms.Application.DoEvents();
            }
            ready = false;
            return 1;
        }

        protected int Navigate_Client(string path)
        {
            Navigate(path);
            IsCompleted();
            return 1;
        }
    }
}
