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
using System.Diagnostics;

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
        List<uint> uidss = new List<uint>();
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
            bgWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bgWorker_RunWorkerCompleted);
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
                IEnumerable<uint> uids = Client.Search(SearchCondition.All());
                IEnumerable<MailMessage> messages = Client.GetMessages(uids.Reverse());
                uidss = new List<uint>();
                messagess = new List<MailMessage>();
                messagess = messages.ToList();
                uidss = uids.ToList();
                uidss.Reverse();                
            }
        }       
        private void metroTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (metroTabControl1.SelectedIndex == 0)
            {
                List<MSGList> list = new List<MSGList>();
                foreach (var m in messagess)
                {
                    MSGList msg = new MSGList
                    {
                        mailhad = "От " + m.From + ": " + m.Subject,
                        mailvalue = "Тема: " + m.Subject + "\n"
                        + "От " + m.From + "\n"
                        + "Кому: " + m.To + "\n"
                        + "\n"
                        + m.Body,
                    };
                    list.Add(msg);
                }
                listBoxInboxUids.DataSource = list;
                listBoxInboxUids.DisplayMember = "mailhad";
                listBoxInboxUids.ValueMember = "mailvalue";                
            }
        }

        

        private void listBoxInboxUids_DoubleClick(object sender, EventArgs e)
        {
            MetroForm form = new MetroForm();
            form.Show();
            form.Style = MetroFramework.MetroColorStyle.Green;
            form.Text = "Письмо:";
            RichTextBox rtb = new RichTextBox();
            rtb.Text = listBoxInboxUids.SelectedValue.ToString();
            rtb.ReadOnly = true;
            rtb.DetectUrls = true;
            rtb.LinkClicked += richTextBox_LinkClicked;
            form.Controls.Add(rtb);
            rtb.Dock = DockStyle.Fill;
        }
        public void richTextBox_LinkClicked(object sender, LinkClickedEventArgs e)
        {             
            Process.Start(e.LinkText);
        }
        private void bgWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            metroTabControl1.Enabled = true;
            listBoxInboxUids.Enabled = true;
            metroTabControl1_SelectedIndexChanged(sender, e);
        }

        private void metroTileDeleteMSG_Click(object sender, EventArgs e)
        {
            string imapadress = "imap." + adress;
            using (ImapClient Client = new ImapClient(imapadress, 993, login, password, AuthMethod.Login, true))
            {
                Client.DeleteMessage(uidss[listBoxInboxUids.SelectedIndex]);
            }
            metroTabControl1.Enabled = false;
            bgWorker = new BackgroundWorker();
            bgWorker.DoWork += (obj, ea) => GetListBoxUids();
            bgWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bgWorker_RunWorkerCompleted);
            bgWorker.RunWorkerAsync();
        }

        private void metroTileReplyMSG_Click(object sender, EventArgs e)
        {
            string path = "tempfile.txt";
            using (StreamWriter sw = new StreamWriter(path, false, System.Text.Encoding.Default))
            {
                string text = login + ";" + password + ";" + adress;
                sw.WriteLine(text);
                sw.Close();
            }
            SendMessage form = new SendMessage();
            form.to = messagess[listBoxInboxUids.SelectedIndex].From.ToString();
            form.subject = messagess[listBoxInboxUids.SelectedIndex].Subject.ToString();
            form.Show();
        }

        private void metroTileRefreshInbox_Click(object sender, EventArgs e)
        {
            metroTabControl1.Enabled = false;
            bgWorker = new BackgroundWorker();
            bgWorker.DoWork += (obj, ea) => GetListBoxUids();
            bgWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bgWorker_RunWorkerCompleted);
            bgWorker.RunWorkerAsync();
        }       
    }
}
