using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using fox.My_code.browser;
using fox.My_code.browser.basics;
using fox.My_code.browser.Factory;
using fox.My_code.db;
using fox.YouTube.Data.Code;
using fox.YouTube.Data.Models;
using Gecko;
using Gecko.WebIDL;

namespace fox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Client_Manager manager;
        private void Form1_Load(object sender, EventArgs e)
        {
            Xpcom.Initialize("Firefox");
            //manager = new Client_Manager(this);
            //manager.NavigatoToMain_Client(Client_Type.ySense);
            //manager.LogIn_Client(Client_Type.ySense);
            List<loginData_Model> l = MyXmlReader<loginData_Model_List>.Read(@"C:\Users\pkubo\OneDrive\Desktop\YouTubeMaster_git\fox\XML\loginData.xml").YouTubeProfile_list;


            //GeckoWebBrowser browser = new GeckoWebBrowser();
            //browser.FrameEventsPropagateToMainWindow = true;
            //browser.Location = new System.Drawing.Point(0, 0);
            //browser.Name = "FoX";
            //browser.Size = new System.Drawing.Size(1920, 1080);
            //browser.TabIndex = 0;
            //browser.UseHttpActivityObserver = true;
            //Controls.Add(browser);
            //browser.Navigate(@"https://accounts.google.com/signin/v2/identifier?service=youtube&uilel=3&passive=true&continue=https%3A%2F%2Fwww.youtube.com%2Fsignin%3Faction_handle_signin%3Dtrue%26app%3Ddesktop%26hl%3Dpl%26next%3Dhttps%253A%252F%252Fwww.youtube.com%252F&hl=pl&gae=cb-p23934712&flowName=GlifWebSignIn&flowEntry=ServiceLogin");
            //browser.Navigate(@"https://www.youtube.com/watch?v=se1zpkvDVAs");

            Random random = new Random();
            int length = random.Next(8,20);
            const string chars = "qwertyuiopasdfghjklzxcvbnmABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            string hash =  new string(Enumerable.Repeat(chars, length).Select(s => s[random.Next(s.Length)]).ToArray());
            string url = @"https://www.youtube.com/watch?v=HM0R4qJFjyY&list=PL7s3qa2IEcmENu1KvSnYv_t9bKeXUQ5bp&index=1&fbclid=IwAR2sdgdgsdgsdg" + hash;
            //webBrowser1.Navigate(url);
            Form_Slave form2 = new Form_Slave(url, "pkubon3@gmail.com", "Start12345");
            form2.Size = new System.Drawing.Size(1600, 720);
            form2.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //FoxXmlData db = new FoxXmlData();
            //db.Read();
            //manager.NavigatoToMain_Client(Client_Type.ySense);
            
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            

        }
    }
}
