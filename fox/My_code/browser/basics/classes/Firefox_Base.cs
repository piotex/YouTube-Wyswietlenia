using System;
using fox.My_code.browser.basics;
using Gecko;

namespace fox.My_code.browser.basics.classes
{
    public abstract class Firefox_Base: GeckoWebBrowser, Client_Interface
    {
        public Firefox_Base()
        {
            int size_X =1400;
            int size_Y =780;

            FrameEventsPropagateToMainWindow = false;
            Location = new System.Drawing.Point(0,0);
            Name = "FoX";
            Size = new System.Drawing.Size(size_X,size_Y);
            TabIndex = 0;
            UseHttpActivityObserver = false;

            //Click += new System.EventHandler(this.geckoWebBrowser1_Click);
        }

        public abstract int doSth();
        public abstract int LogIn();
        public abstract int Navigate_toMain();
    }
}
