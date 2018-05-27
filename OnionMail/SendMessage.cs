using MetroFramework.Forms;
using System;
using System.Net;
using System.Net.Mail;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnionMail
{
    public partial class SendMessage : MetroForm
    {
        string login = null;
        string password = null;
        string adress = null;
        public string to = null;
        public string subject = null;
        string[] attachmentfilenames;
        MailMessage message = new MailMessage();
        public SendMessage()
        {
            InitializeComponent();
        }

        private void SendMessage_Load(object sender, EventArgs e)
        {
            string path = "tempfile.txt";
            StreamReader sr = new StreamReader(path, Encoding.Default);
            string[] data;
            string str = sr.ReadLine();
            data = str.Split(';');
            login = data[0];
            password = data[1];
            adress = data[2];
            //label1.Text = login;
            sr.Close();
            File.Delete("tempfile.txt");
            textBoxTo.Text = to;
            textBoxSubject.Text = subject;
        }

        private void metroTileSendMSG_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxTo.Text == null || textBoxTo.Text == "")
                    throw new Exception("Введите электронный адрес, кому нужно отправить сообщение.");
                string smtpadress = "smpt." + adress;
                SmtpClient client = new SmtpClient(smtpadress, 587);
                client.EnableSsl = true;
                client.Credentials = new NetworkCredential(login, password);
                message = new MailMessage();
                message.From = new MailAddress(login);
                message.To.Add(new MailAddress(textBoxTo.Text));
                message.Subject = textBoxSubject.Text;
                message.Body = richTextBoxBody.Text;
                if (metroCheckBoxAttachment.Checked && attachmentfilenames != null)
                {
                    foreach (var s in attachmentfilenames)
                    {
                        Attachment att = new Attachment(s);
                        message.Attachments.Add(att);
                    }                   
                }
                client.Send(message);
                MessageBox.Show("Сообщение на " + textBoxTo.Text + " успешно отправлено.", "Onion Mail");

            }
            catch (Exception gg)
            {
                MessageBox.Show(gg.Message, "Ошибка");
            }
        }

        private void metroCheckBoxAttachment_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBoxAttachment.Checked)
            {
                metroButtonAttachment.Visible = true;
            }
            else
            {
                metroButtonAttachment.Visible = false;
                metroButtonClearAttachment.Visible = false;
                metroButtonShowElements.Visible = false;
                metroLabelAttachmentStatus.Visible = false;
            }
        }

        private void metroButtonAttachment_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Multiselect = true;
            //openFileDialog1.Filter = "Все файлы (*.) | *.";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                attachmentfilenames = openFileDialog1.FileNames;
                metroLabelAttachmentStatus.Visible = true;
                metroLabelAttachmentStatus.Text = "Выбран(о) " + attachmentfilenames.Length + " элемент(ов)";
                metroButtonClearAttachment.Visible = true;
                metroButtonShowElements.Visible = true;
            }
        }

        private void metroButtonClearAttachment_Click(object sender, EventArgs e)
        {
            attachmentfilenames = null;
            message.Attachments.Clear();
            metroLabelAttachmentStatus.Visible = false;
        }

        private void metroButtonShowElements_Click(object sender, EventArgs e)
        {
            string element = null;
            if (attachmentfilenames != null)
            {
                foreach (string s in attachmentfilenames)
                {
                    element += s + "\n";
                }
                MessageBox.Show(element, "Вложения");
            }
            else MessageBox.Show("Нет вложений", "Вложения");
        }
    }
}
