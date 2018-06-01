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
        string trash = null;
        string sent = null;
        string contactspath = "contacts.txt";
        List<uint> uidsInbox = new List<uint>();
        List<MailMessage> messagesInbox = new List<MailMessage>();
        List<uint> uidsSent = new List<uint>();
        List<MailMessage> messagesSent = new List<MailMessage>();
        List<uint> uidsTrash = new List<uint>();
        List<MailMessage> messagesTrash = new List<MailMessage>();
        List<Contacts> contactList = new List<Contacts>();

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
            switch (adress)
            {
                case "mail.ru":
                    sent = "Отправленные";
                    trash = "Корзина";
                    break;
                case "gmail.com":
                    sent = "[Gmail]/Отправленные";
                    trash = "[Gmail]/Корзина";
                    break;
                case "yandex.ru":
                    sent = "Отправленные";
                    trash = "Удаленные";
                    break;
            }
            metroTabControl1_SelectedIndexChanged(sender, e);
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
        public void GetInboxUids()
        {
            try
            {
                string imapadress = "imap." + adress;
                using (ImapClient Client = new ImapClient(imapadress, 993, login, password, AuthMethod.Login, true))
                {
                    IEnumerable<uint> uids = Client.Search(SearchCondition.All());
                    IEnumerable<MailMessage> messages = Client.GetMessages(uids.Reverse());
                    uidsInbox = new List<uint>();
                    messagesInbox = new List<MailMessage>();
                    messagesInbox = messages.ToList();
                    uidsInbox = uids.ToList();
                    uidsInbox.Reverse();
                }
            }
            catch (Exception gg)
            {
                MessageBox.Show(gg.Message, "Ошибка");
            }
        }
        public void GetSentUids()
        {
            try
            {
                string imapadress = "imap." + adress;
                using (ImapClient Client = new ImapClient(imapadress, 993, login, password, AuthMethod.Login, true))
                {
                    Client.DefaultMailbox = sent;
                    IEnumerable<uint> uids = Client.Search(SearchCondition.All());
                    IEnumerable<MailMessage> messages = Client.GetMessages(uids.Reverse());
                    uidsInbox = new List<uint>();
                    messagesSent = new List<MailMessage>();
                    messagesSent = messages.ToList();
                    uidsSent = uids.ToList();
                    uidsSent.Reverse();
                }
            }
            catch (Exception gg)
            {
                MessageBox.Show(gg.Message, "Ошибка");
            }
        }
        public void GetTrashUids()
        {
            try
            {
                string imapadress = "imap." + adress;
                using (ImapClient Client = new ImapClient(imapadress, 993, login, password, AuthMethod.Login, true))
                {
                    Client.DefaultMailbox = trash;
                    IEnumerable<uint> uids = Client.Search(SearchCondition.All());
                    IEnumerable<MailMessage> messages = Client.GetMessages(uids.Reverse());
                    uidsTrash = new List<uint>();
                    messagesTrash = new List<MailMessage>();
                    messagesTrash = messages.ToList();
                    uidsTrash = uids.ToList();
                    uidsTrash.Reverse();
                }
            }
            catch (Exception gg)
            {
                MessageBox.Show(gg.Message, "Ошибка");
            }
        }
        private void metroTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (metroTabControl1.SelectedIndex == 0)
            {
                bgWorker = new BackgroundWorker();
                bgWorker.DoWork += (obj, ea) => GetInboxUids();
                bgWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bgWorkerInbox_RunWorkerCompleted);
                bgWorker.RunWorkerAsync();
                List<MSGList> list = new List<MSGList>();
                foreach (var m in messagesInbox)
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
            if (metroTabControl1.SelectedIndex == 1)
            {
                bgWorker = new BackgroundWorker();
                bgWorker.DoWork += (obj, ea) => GetSentUids();
                bgWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bgWorkerSent_RunWorkerCompleted);
                bgWorker.RunWorkerAsync();
                List<MSGList> list = new List<MSGList>();
                foreach (var m in messagesSent)
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
                listBoxSentUids.DataSource = list;
                listBoxSentUids.DisplayMember = "mailhad";
                listBoxSentUids.ValueMember = "mailvalue";
            }
            if (metroTabControl1.SelectedIndex == 2)
            {
                bgWorker = new BackgroundWorker();
                bgWorker.DoWork += (obj, ea) => GetTrashUids();
                bgWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bgWorkerTrash_RunWorkerCompleted);
                bgWorker.RunWorkerAsync();
                List<MSGList> list = new List<MSGList>();
                foreach (var m in messagesTrash)
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
                listBoxTrashUids.DataSource = list;
                listBoxTrashUids.DisplayMember = "mailhad";
                listBoxTrashUids.ValueMember = "mailvalue";
            }
            if (metroTabControl1.SelectedIndex == 3)
            {
                int shag = 0;
                string[] data;
                string str;
                StreamReader f = new StreamReader(contactspath, Encoding.Default);
                int legenth = File.ReadAllLines(contactspath).Length;
                try
                {
                    contactList = new List<Contacts>();                    
                    while ((str = f.ReadLine()) != null)
                    {
                        data = str.Split(';');
                        Contacts c = new Contacts();
                        c.EmailAdress = data[0];
                        c.Surname = data[1];
                        c.Name = data[2];
                        c.Description = data[3];
                        contactList.Add(c);
                        shag++;
                    }
                    f.Close();
                    List<string> list = new List<string>();
                    foreach (var c in contactList)
                    {
                        string value = c.Surname + " " + c.Name + "(" + c.EmailAdress + ")";
                        list.Add(value);
                    }
                    listBoxContactList.DataSource = list;                    
                    /*textBoxContactSurname.Text = contactList[listBoxContactList.SelectedIndex].Surname.ToString();
                    textBoxContactName.Text = contactList[listBoxContactList.SelectedIndex].Name.ToString();
                    richTextBoxContactDescription.Text = contactList[listBoxContactList.SelectedIndex].Description.ToString();
                    textBoxContactEmail.Text = contactList[listBoxContactList.SelectedIndex].Name.ToString();*/
                }
                catch (Exception gg)
                {
                    shag++;
                    f.Close();
                    MessageBox.Show(shag + " строка в файле. " + gg.Message, "Ошибка");
                }
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
        private void bgWorkerInbox_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            metroTileDeleteMSG.Enabled = true;
            metroTileRefreshInbox.Enabled = true;
            metroTileReplyMSG.Enabled = true;
            listBoxInboxUids.Enabled = true;
            metroTabControl1_SelectedIndexChanged(sender, e);
        }
        private void bgWorkerSent_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            metroTileSentRefresh.Enabled = true;
            metroTileSentDeleteMSG.Enabled = true;
            listBoxSentUids.Enabled = true;
            metroTabControl1_SelectedIndexChanged(sender, e);
        }
        private void bgWorkerTrash_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            metroTileTrashDeleteMSG.Enabled = true;
            metroTileTrashRefresh.Enabled = true;
            listBoxTrashUids.Enabled = true;
            metroTabControl1_SelectedIndexChanged(sender, e);
        }

        private void metroTileDeleteMSG_Click(object sender, EventArgs e)
        {
            string imapadress = "imap." + adress;
            using (ImapClient Client = new ImapClient(imapadress, 993, login, password, AuthMethod.Login, true))
            {
                Client.DeleteMessage(uidsInbox[listBoxInboxUids.SelectedIndex]);
            }
            metroTileDeleteMSG.Enabled = false;
            metroTileRefreshInbox.Enabled = false;
            metroTileReplyMSG.Enabled = false;
            listBoxInboxUids.Enabled = false;
            bgWorker = new BackgroundWorker();
            bgWorker.DoWork += (obj, ea) => GetInboxUids();
            bgWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bgWorkerInbox_RunWorkerCompleted);
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
            form.to = messagesInbox[listBoxInboxUids.SelectedIndex].From.ToString();
            form.subject = messagesInbox[listBoxInboxUids.SelectedIndex].Subject.ToString();
            form.replybody = messagesInbox[listBoxInboxUids.SelectedIndex].Body.ToString() + "\n\n ... \n\n";
            form.Show();
        }

        private void metroTileRefreshInbox_Click(object sender, EventArgs e)
        {
            metroTileDeleteMSG.Enabled = false;
            metroTileRefreshInbox.Enabled = false;
            metroTileReplyMSG.Enabled = false;
            listBoxInboxUids.Enabled = false;
            bgWorker = new BackgroundWorker();
            bgWorker.DoWork += (obj, ea) => GetInboxUids();
            bgWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bgWorkerInbox_RunWorkerCompleted);
            bgWorker.RunWorkerAsync();
        }

        private void listBoxSentUids_DoubleClick(object sender, EventArgs e)
        {
            MetroForm form = new MetroForm();
            form.Show();
            form.Style = MetroFramework.MetroColorStyle.Green;
            form.Text = "Письмо:";
            RichTextBox rtb = new RichTextBox();
            rtb.Text = listBoxSentUids.SelectedValue.ToString();
            rtb.ReadOnly = true;
            rtb.DetectUrls = true;
            rtb.LinkClicked += richTextBox_LinkClicked;
            form.Controls.Add(rtb);
            rtb.Dock = DockStyle.Fill;
        }

        private void listBoxTrashUids_DoubleClick(object sender, EventArgs e)
        {
            MetroForm form = new MetroForm();
            form.Show();
            form.Style = MetroFramework.MetroColorStyle.Green;
            form.Text = "Письмо:";
            RichTextBox rtb = new RichTextBox();
            rtb.Text = listBoxTrashUids.SelectedValue.ToString();
            rtb.ReadOnly = true;
            rtb.DetectUrls = true;
            rtb.LinkClicked += richTextBox_LinkClicked;
            form.Controls.Add(rtb);
            rtb.Dock = DockStyle.Fill;
        }

        private void metroTileSentDeleteMSG_Click(object sender, EventArgs e)
        {
            string imapadress = "imap." + adress;
            using (ImapClient Client = new ImapClient(imapadress, 993, login, password, AuthMethod.Login, true))
            {
                Client.DeleteMessage(uidsSent[listBoxSentUids.SelectedIndex]);
            }
            metroTileSentRefresh.Enabled = false;
            metroTileSentDeleteMSG.Enabled = false;
            listBoxSentUids.Enabled = false;
            bgWorker = new BackgroundWorker();
            bgWorker.DoWork += (obj, ea) => GetSentUids();
            bgWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bgWorkerInbox_RunWorkerCompleted);
            bgWorker.RunWorkerAsync();
        }

        private void metroTileSentRefresh_Click(object sender, EventArgs e)
        {
            metroTileSentRefresh.Enabled = false;
            metroTileSentDeleteMSG.Enabled = false;
            listBoxSentUids.Enabled = false;
            bgWorker = new BackgroundWorker();
            bgWorker.DoWork += (obj, ea) => GetSentUids();
            bgWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bgWorkerInbox_RunWorkerCompleted);
            bgWorker.RunWorkerAsync();
        }

        private void metroTileTrashDeleteMSG_Click(object sender, EventArgs e)
        {
            string imapadress = "imap." + adress;
            using (ImapClient Client = new ImapClient(imapadress, 993, login, password, AuthMethod.Login, true))
            {
                Client.DeleteMessage(uidsTrash[listBoxTrashUids.SelectedIndex]);
            }
            metroTileTrashDeleteMSG.Enabled = false;
            metroTileTrashRefresh.Enabled = false;
            listBoxTrashUids.Enabled = false;
            bgWorker = new BackgroundWorker();
            bgWorker.DoWork += (obj, ea) => GetTrashUids();
            bgWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bgWorkerInbox_RunWorkerCompleted);
            bgWorker.RunWorkerAsync();
        }

        private void metroTileTrashRefresh_Click(object sender, EventArgs e)
        {
            metroTileTrashDeleteMSG.Enabled = false;
            metroTileTrashRefresh.Enabled = false;
            listBoxTrashUids.Enabled = false;
            bgWorker = new BackgroundWorker();
            bgWorker.DoWork += (obj, ea) => GetTrashUids();
            bgWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bgWorkerInbox_RunWorkerCompleted);
            bgWorker.RunWorkerAsync();
        }

        private void listBoxContactList_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxContactSurname.Text = contactList[listBoxContactList.SelectedIndex].Surname.ToString();
            textBoxContactName.Text = contactList[listBoxContactList.SelectedIndex].Name.ToString();
            richTextBoxContactDescription.Text = contactList[listBoxContactList.SelectedIndex].Description.ToString();
            textBoxContactEmail.Text = contactList[listBoxContactList.SelectedIndex].EmailAdress.ToString();
        }

        private void metroTileAddContact_Click(object sender, EventArgs e)
        {            
            using (StreamWriter sw = new StreamWriter(contactspath, true, Encoding.Default))
            {
                string text =textBoxContactEmail.Text + ";" + textBoxContactSurname.Text + ";" + textBoxContactName.Text + ";" + richTextBoxContactDescription.Text + "\n";                
                sw.Write(text);
                sw.Close();
                metroTabControl1_SelectedIndexChanged(sender, e);
            }
        }

        private void metroTileSendMSGContact_Click(object sender, EventArgs e)
        {
            string path = "tempfile.txt";
            using (StreamWriter sw = new StreamWriter(path, false, System.Text.Encoding.Default))
            {
                string text = login + ";" + password + ";" + adress;
                sw.WriteLine(text);
                sw.Close();
            }
            SendMessage form = new SendMessage();
            form.to = textBoxContactEmail.Text;            
            form.Show();
        }

        private void metroTileEditContact_Click(object sender, EventArgs e)
        {
            contactList[listBoxContactList.SelectedIndex].EmailAdress = textBoxContactEmail.Text;
            contactList[listBoxContactList.SelectedIndex].Surname = textBoxContactSurname.Text;
            contactList[listBoxContactList.SelectedIndex].Name = textBoxContactName.Text;
            contactList[listBoxContactList.SelectedIndex].Description = richTextBoxContactDescription.Text;
            using (StreamWriter sw = new StreamWriter(contactspath, false, Encoding.Default))
            {
                foreach (var c in contactList)
                {
                    string text = c.EmailAdress + ";" + c.Surname + ";" + c.Name + ";" + c.Description + "\n";
                    sw.Write(text);
                }
                sw.Close();
                metroTabControl1_SelectedIndexChanged(sender, e);
            }
        }

        private void metroTileDeleteContact_Click(object sender, EventArgs e)
        {
            contactList.RemoveAt(listBoxContactList.SelectedIndex);
            using (StreamWriter sw = new StreamWriter(contactspath, false, Encoding.Default))
            {
                foreach (var c in contactList)
                {
                    string text = c.EmailAdress + ";" + c.Surname + ";" + c.Name + ";" + c.Description + "\n";
                    sw.Write(text);
                }
                sw.Close();
                metroTabControl1_SelectedIndexChanged(sender, e);
            }
        }
        public void RefreshLabel(object sender, EventArgs e)
        {
            metroProgressSpinnerStatus.Value += 5;
            metroLabel5.Visible = true;
        }

        private void bgWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            Timer timer = new Timer();
            timer.Tick += new EventHandler(RefreshLabel);
            timer.Interval = 1000;
            timer.Start();
        }
    }
}
