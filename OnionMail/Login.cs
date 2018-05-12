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
using S22.Imap;
using System.Net.Sockets;

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
            GetImapAdress();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            string login = textBoxLogin.Text + "@" +comboBoxMail.Text;            
            try
            {
                if (textBoxLogin.Text == null || textBoxLogin.Text == "")
                    throw new Exception("Введите логин.");
                if (textBoxPassword.Text == null || textBoxPassword.Text == "")
                    throw new Exception("Введите пароль");
                using (ImapClient Client = new ImapClient(comboBoxMail.SelectedValue.ToString(), 993, login, textBoxPassword.Text, AuthMethod.Login, true))
                {
                    MessageBox.Show("Вход выполнен успешно!", "Onion Mail");
                    MainWindow mainwindow = new MainWindow();
                    mainwindow.Show();
                    this.Hide();
                }
            }
            catch(InvalidCredentialsException fail)
            {
                MessageBox.Show("Неверный логин или пароль.", "Onion Mail");
            }
            catch(SocketException network)
            {
                MessageBox.Show("Проблемы с интернет-подключением. Проверьте интернет-соеденение.", "Onion Mail");
            }
            catch(Exception gg)
            {
                MessageBox.Show(gg.Message, "Onion Mail");
            }
        }
        public void GetImapAdress()
        {
            accessAdress mailru = new accessAdress { Name = "mail.ru", Url = "imap.mail.ru" };
            accessAdress gmail = new accessAdress { Name = "gmail.com", Url = "imap.gmail.com" };
            accessAdress yandex = new accessAdress { Name = "yandex.ru", Url = "imap.yandex.ru" };
            List<accessAdress> listMails = new List<accessAdress> { mailru, gmail, yandex };
            comboBoxMail.DataSource = listMails;
            comboBoxMail.DisplayMember = "Name";
            comboBoxMail.ValueMember = "Url";   
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }    
}
