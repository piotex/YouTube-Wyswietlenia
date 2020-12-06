using System;
using System.Collections.Generic;
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
            List<loginData_Model> l = MyXmlReader<loginData_Model_List>.Read(@"C:\Users\pkubo\OneDrive\Desktop\YouTubeMaster\fox\XML\loginData.xml").YouTubeProfile_list;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //FoxXmlData db = new FoxXmlData();
            //db.Read();
            //manager.NavigatoToMain_Client(Client_Type.ySense);
        }
    }
}
