using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework.Controls;
using System.IO;
using S22.Imap;
using System.Net.Mail;

namespace OnionMail
{
    public partial class MainWindow : MetroForm
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        string login = null;
        string password = null;
        string adress = null;
        IEnumerable<uint> uids;
        List<MailMessage> messagess = new List<MailMessage>();

        private void metroTileLogOut_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void MainWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            string path = "tempfile.txt";
            StreamReader sr = new StreamReader(path, Encoding.Default);
            string[] data;
            string str = sr.ReadLine();
            data = str.Split(';');
            login = data[0];
            password = data[1];
            adress = data[2];
            metroLabelStatusLogin.Text = login;
            sr.Close();
            File.Delete("tempfile.txt");
            bgWorker = new BackgroundWorker();
            bgWorker.DoWork += (obj, ea) => GetListBoxUids();
            bgWorker.RunWorkerAsync();           
        }

        private void metroTileSendMSG_Click(object sender, EventArgs e)
        {
            string path = "tempfile.txt";
            using (StreamWriter sw = new StreamWriter(path, false, System.Text.Encoding.Default))
            {
                string text = login + ";" + password + ";" + adress;
                sw.WriteLine(text);
                sw.Close();
            }
            SendMessage form = new SendMessage();
            form.Show();
        }
        public void GetListBoxUids()
        {
            string imapadress = "imap." + adress;
            using (ImapClient Client = new ImapClient(imapadress, 993, login, password, AuthMethod.Login, true))
            {
                //label1.Text = "Загрузка...";
                IEnumerable<uint> uids = Client.Search(SearchCondition.All()); ;
                IEnumerable<MailMessage> messages = Client.GetMessages(uids.Reverse());
                messagess = messages.ToList();                
                MessageBox.Show("Загрузка завершена");
            }
        }        
    }
}
