using fox.My_code.browser.basics;
using fox.My_code.browser.basics.classes;
using fox.My_code.ySense;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fox.My_code.browser.Factory
{
    public class Client_Manager
    {
        private Form _form;
        public Client_Manager(Form f)
        {
            _form = f;
            foreach (var item in clients)
            {
                //todo zmienic to na tworzenie mowego zminimalizowanego forma i dodawac do niego item!
                f.Controls.Add(item.Value);
            }
        }

        private Dictionary<Client_Type, Firefox_Base> clients = new Dictionary<Client_Type, Firefox_Base>()
        {
            {Client_Type.ySense, new ySense_client() }
        };

        public int doSth(Client_Type _type)
        {
            clients[_type].doSth();
            return 1;
        }
        public int LogIn_Client(Client_Type _type)
        {
            clients[_type].LogIn();
            return 1;
        }
        public int NavigatoToMain_Client(Client_Type _type)
        {
            clients[_type].Navigate_toMain();
            return 1;
        }
    }
}
