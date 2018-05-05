using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;

namespace OnionMail
{
    public partial class Login : MetroForm
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {            
            GetSmptAdress();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {           
            
            
        }
        public void GetSmptAdress()
        {
            accessAdress mailru = new accessAdress { Name = "@mail.ru", Url = "imap.mail.ru" };
            accessAdress gmail = new accessAdress { Name = "@gmail.com", Url = "imap.gmail.com" };
            accessAdress yandex = new accessAdress { Name = "@yandex.ru", Url = "imap.yandex.ru" };
            List<accessAdress> listMails = new List<accessAdress> { mailru, gmail, yandex };
            comboBoxMail.DataSource = listMails;
            comboBoxMail.DisplayMember = "Name";
            comboBoxMail.ValueMember = "Url";            

        }
    }
    class accessAdress
    {
        public string Name { get; set; }
        public string Url { get; set; }
        //public int port { get; set; }
    }
}
