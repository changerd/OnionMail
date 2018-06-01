namespace OnionMail
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.metroTileLogOut = new MetroFramework.Controls.MetroTile();
            this.metroLabelStatusLogin = new MetroFramework.Controls.MetroLabel();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPageInbox = new MetroFramework.Controls.MetroTabPage();
            this.metroTileRefreshInbox = new MetroFramework.Controls.MetroTile();
            this.metroTileDeleteMSG = new MetroFramework.Controls.MetroTile();
            this.metroTileReplyMSG = new MetroFramework.Controls.MetroTile();
            this.listBoxInboxUids = new System.Windows.Forms.ListBox();
            this.metroTabPageSent = new MetroFramework.Controls.MetroTabPage();
            this.metroTileSentDeleteMSG = new MetroFramework.Controls.MetroTile();
            this.metroTileSentRefresh = new MetroFramework.Controls.MetroTile();
            this.listBoxSentUids = new System.Windows.Forms.ListBox();
            this.metroTabPageTrash = new MetroFramework.Controls.MetroTabPage();
            this.metroTileTrashDeleteMSG = new MetroFramework.Controls.MetroTile();
            this.metroTileTrashRefresh = new MetroFramework.Controls.MetroTile();
            this.listBoxTrashUids = new System.Windows.Forms.ListBox();
            this.metroTileSendMSG = new MetroFramework.Controls.MetroTile();
            this.bgWorker = new System.ComponentModel.BackgroundWorker();
            this.metroTabPageContactList = new MetroFramework.Controls.MetroTabPage();
            this.listBoxContactList = new System.Windows.Forms.ListBox();
            this.metroTileAddContact = new MetroFramework.Controls.MetroTile();
            this.metroTileEditContact = new MetroFramework.Controls.MetroTile();
            this.metroTileDeleteContact = new MetroFramework.Controls.MetroTile();
            this.metroPanelContactInfo = new MetroFramework.Controls.MetroPanel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.textBoxContactSurname = new System.Windows.Forms.TextBox();
            this.textBoxContactName = new System.Windows.Forms.TextBox();
            this.richTextBoxContactDescription = new System.Windows.Forms.RichTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.textBoxContactEmail = new System.Windows.Forms.TextBox();
            this.metroTileSendMSGContact = new MetroFramework.Controls.MetroTile();
            this.metroProgressSpinnerStatus = new MetroFramework.Controls.MetroProgressSpinner();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPageInbox.SuspendLayout();
            this.metroTabPageSent.SuspendLayout();
            this.metroTabPageTrash.SuspendLayout();
            this.metroTabPageContactList.SuspendLayout();
            this.metroPanelContactInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroTileLogOut
            // 
            this.metroTileLogOut.Location = new System.Drawing.Point(694, 27);
            this.metroTileLogOut.Name = "metroTileLogOut";
            this.metroTileLogOut.Size = new System.Drawing.Size(75, 23);
            this.metroTileLogOut.Style = MetroFramework.MetroColorStyle.Red;
            this.metroTileLogOut.TabIndex = 0;
            this.metroTileLogOut.Text = "Выход";
            this.metroTileLogOut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileLogOut.Click += new System.EventHandler(this.metroTileLogOut_Click);
            // 
            // metroLabelStatusLogin
            // 
            this.metroLabelStatusLogin.AutoSize = true;
            this.metroLabelStatusLogin.Location = new System.Drawing.Point(529, 31);
            this.metroLabelStatusLogin.Name = "metroLabelStatusLogin";
            this.metroLabelStatusLogin.Size = new System.Drawing.Size(38, 19);
            this.metroLabelStatusLogin.TabIndex = 1;
            this.metroLabelStatusLogin.Text = "login";
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPageInbox);
            this.metroTabControl1.Controls.Add(this.metroTabPageSent);
            this.metroTabControl1.Controls.Add(this.metroTabPageTrash);
            this.metroTabControl1.Controls.Add(this.metroTabPageContactList);
            this.metroTabControl1.Location = new System.Drawing.Point(27, 102);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(728, 352);
            this.metroTabControl1.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTabControl1.TabIndex = 0;
            this.metroTabControl1.SelectedIndexChanged += new System.EventHandler(this.metroTabControl1_SelectedIndexChanged);
            // 
            // metroTabPageInbox
            // 
            this.metroTabPageInbox.Controls.Add(this.metroTileRefreshInbox);
            this.metroTabPageInbox.Controls.Add(this.metroTileDeleteMSG);
            this.metroTabPageInbox.Controls.Add(this.metroTileReplyMSG);
            this.metroTabPageInbox.Controls.Add(this.listBoxInboxUids);
            this.metroTabPageInbox.HorizontalScrollbarBarColor = true;
            this.metroTabPageInbox.Location = new System.Drawing.Point(4, 35);
            this.metroTabPageInbox.Name = "metroTabPageInbox";
            this.metroTabPageInbox.Size = new System.Drawing.Size(720, 313);
            this.metroTabPageInbox.TabIndex = 1;
            this.metroTabPageInbox.Text = "Входящие";
            this.metroTabPageInbox.VerticalScrollbarBarColor = true;
            // 
            // metroTileRefreshInbox
            // 
            this.metroTileRefreshInbox.Enabled = false;
            this.metroTileRefreshInbox.Location = new System.Drawing.Point(638, 3);
            this.metroTileRefreshInbox.Name = "metroTileRefreshInbox";
            this.metroTileRefreshInbox.Size = new System.Drawing.Size(79, 33);
            this.metroTileRefreshInbox.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTileRefreshInbox.TabIndex = 5;
            this.metroTileRefreshInbox.Text = "Обновить";
            this.metroTileRefreshInbox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileRefreshInbox.Click += new System.EventHandler(this.metroTileRefreshInbox_Click);
            // 
            // metroTileDeleteMSG
            // 
            this.metroTileDeleteMSG.Enabled = false;
            this.metroTileDeleteMSG.Location = new System.Drawing.Point(84, 3);
            this.metroTileDeleteMSG.Name = "metroTileDeleteMSG";
            this.metroTileDeleteMSG.Size = new System.Drawing.Size(115, 33);
            this.metroTileDeleteMSG.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTileDeleteMSG.TabIndex = 4;
            this.metroTileDeleteMSG.Text = "Удалить письмо";
            this.metroTileDeleteMSG.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileDeleteMSG.Click += new System.EventHandler(this.metroTileDeleteMSG_Click);
            // 
            // metroTileReplyMSG
            // 
            this.metroTileReplyMSG.Enabled = false;
            this.metroTileReplyMSG.Location = new System.Drawing.Point(3, 3);
            this.metroTileReplyMSG.Name = "metroTileReplyMSG";
            this.metroTileReplyMSG.Size = new System.Drawing.Size(75, 33);
            this.metroTileReplyMSG.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTileReplyMSG.TabIndex = 3;
            this.metroTileReplyMSG.Text = "Ответить";
            this.metroTileReplyMSG.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileReplyMSG.Click += new System.EventHandler(this.metroTileReplyMSG_Click);
            // 
            // listBoxInboxUids
            // 
            this.listBoxInboxUids.FormattingEnabled = true;
            this.listBoxInboxUids.Location = new System.Drawing.Point(3, 42);
            this.listBoxInboxUids.Name = "listBoxInboxUids";
            this.listBoxInboxUids.Size = new System.Drawing.Size(714, 251);
            this.listBoxInboxUids.TabIndex = 2;
            this.listBoxInboxUids.DoubleClick += new System.EventHandler(this.listBoxInboxUids_DoubleClick);
            // 
            // metroTabPageSent
            // 
            this.metroTabPageSent.Controls.Add(this.metroTileSentDeleteMSG);
            this.metroTabPageSent.Controls.Add(this.metroTileSentRefresh);
            this.metroTabPageSent.Controls.Add(this.listBoxSentUids);
            this.metroTabPageSent.HorizontalScrollbarBarColor = true;
            this.metroTabPageSent.Location = new System.Drawing.Point(4, 35);
            this.metroTabPageSent.Name = "metroTabPageSent";
            this.metroTabPageSent.Size = new System.Drawing.Size(720, 313);
            this.metroTabPageSent.TabIndex = 2;
            this.metroTabPageSent.Text = "Отправленные";
            this.metroTabPageSent.VerticalScrollbarBarColor = true;
            // 
            // metroTileSentDeleteMSG
            // 
            this.metroTileSentDeleteMSG.Enabled = false;
            this.metroTileSentDeleteMSG.Location = new System.Drawing.Point(3, 3);
            this.metroTileSentDeleteMSG.Name = "metroTileSentDeleteMSG";
            this.metroTileSentDeleteMSG.Size = new System.Drawing.Size(118, 33);
            this.metroTileSentDeleteMSG.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTileSentDeleteMSG.TabIndex = 8;
            this.metroTileSentDeleteMSG.Text = "Удалить письмо";
            this.metroTileSentDeleteMSG.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileSentDeleteMSG.Click += new System.EventHandler(this.metroTileSentDeleteMSG_Click);
            // 
            // metroTileSentRefresh
            // 
            this.metroTileSentRefresh.Enabled = false;
            this.metroTileSentRefresh.Location = new System.Drawing.Point(638, 3);
            this.metroTileSentRefresh.Name = "metroTileSentRefresh";
            this.metroTileSentRefresh.Size = new System.Drawing.Size(79, 33);
            this.metroTileSentRefresh.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTileSentRefresh.TabIndex = 6;
            this.metroTileSentRefresh.Text = "Обновить";
            this.metroTileSentRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileSentRefresh.Click += new System.EventHandler(this.metroTileSentRefresh_Click);
            // 
            // listBoxSentUids
            // 
            this.listBoxSentUids.FormattingEnabled = true;
            this.listBoxSentUids.Location = new System.Drawing.Point(3, 42);
            this.listBoxSentUids.Name = "listBoxSentUids";
            this.listBoxSentUids.Size = new System.Drawing.Size(714, 251);
            this.listBoxSentUids.TabIndex = 3;
            this.listBoxSentUids.DoubleClick += new System.EventHandler(this.listBoxSentUids_DoubleClick);
            // 
            // metroTabPageTrash
            // 
            this.metroTabPageTrash.Controls.Add(this.metroTileTrashDeleteMSG);
            this.metroTabPageTrash.Controls.Add(this.metroTileTrashRefresh);
            this.metroTabPageTrash.Controls.Add(this.listBoxTrashUids);
            this.metroTabPageTrash.HorizontalScrollbarBarColor = true;
            this.metroTabPageTrash.Location = new System.Drawing.Point(4, 35);
            this.metroTabPageTrash.Name = "metroTabPageTrash";
            this.metroTabPageTrash.Size = new System.Drawing.Size(720, 313);
            this.metroTabPageTrash.TabIndex = 3;
            this.metroTabPageTrash.Text = "Корзина";
            this.metroTabPageTrash.VerticalScrollbarBarColor = true;
            // 
            // metroTileTrashDeleteMSG
            // 
            this.metroTileTrashDeleteMSG.Enabled = false;
            this.metroTileTrashDeleteMSG.Location = new System.Drawing.Point(3, 3);
            this.metroTileTrashDeleteMSG.Name = "metroTileTrashDeleteMSG";
            this.metroTileTrashDeleteMSG.Size = new System.Drawing.Size(115, 33);
            this.metroTileTrashDeleteMSG.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTileTrashDeleteMSG.TabIndex = 8;
            this.metroTileTrashDeleteMSG.Text = "Удалить письмо";
            this.metroTileTrashDeleteMSG.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileTrashDeleteMSG.Click += new System.EventHandler(this.metroTileTrashDeleteMSG_Click);
            // 
            // metroTileTrashRefresh
            // 
            this.metroTileTrashRefresh.Enabled = false;
            this.metroTileTrashRefresh.Location = new System.Drawing.Point(638, 3);
            this.metroTileTrashRefresh.Name = "metroTileTrashRefresh";
            this.metroTileTrashRefresh.Size = new System.Drawing.Size(79, 33);
            this.metroTileTrashRefresh.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTileTrashRefresh.TabIndex = 7;
            this.metroTileTrashRefresh.Text = "Обновить";
            this.metroTileTrashRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileTrashRefresh.Click += new System.EventHandler(this.metroTileTrashRefresh_Click);
            // 
            // listBoxTrashUids
            // 
            this.listBoxTrashUids.FormattingEnabled = true;
            this.listBoxTrashUids.Location = new System.Drawing.Point(3, 42);
            this.listBoxTrashUids.Name = "listBoxTrashUids";
            this.listBoxTrashUids.Size = new System.Drawing.Size(714, 251);
            this.listBoxTrashUids.TabIndex = 4;
            this.listBoxTrashUids.DoubleClick += new System.EventHandler(this.listBoxTrashUids_DoubleClick);
            // 
            // metroTileSendMSG
            // 
            this.metroTileSendMSG.Location = new System.Drawing.Point(27, 63);
            this.metroTileSendMSG.Name = "metroTileSendMSG";
            this.metroTileSendMSG.Size = new System.Drawing.Size(91, 33);
            this.metroTileSendMSG.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTileSendMSG.TabIndex = 3;
            this.metroTileSendMSG.Text = "Написать";
            this.metroTileSendMSG.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileSendMSG.Click += new System.EventHandler(this.metroTileSendMSG_Click);
            // 
            // bgWorker
            // 
            this.bgWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgWorker_ProgressChanged);
            // 
            // metroTabPageContactList
            // 
            this.metroTabPageContactList.Controls.Add(this.metroTileSendMSGContact);
            this.metroTabPageContactList.Controls.Add(this.textBoxContactEmail);
            this.metroTabPageContactList.Controls.Add(this.metroLabel4);
            this.metroTabPageContactList.Controls.Add(this.metroPanelContactInfo);
            this.metroTabPageContactList.Controls.Add(this.metroTileDeleteContact);
            this.metroTabPageContactList.Controls.Add(this.metroTileEditContact);
            this.metroTabPageContactList.Controls.Add(this.metroTileAddContact);
            this.metroTabPageContactList.Controls.Add(this.listBoxContactList);
            this.metroTabPageContactList.HorizontalScrollbarBarColor = true;
            this.metroTabPageContactList.Location = new System.Drawing.Point(4, 35);
            this.metroTabPageContactList.Name = "metroTabPageContactList";
            this.metroTabPageContactList.Size = new System.Drawing.Size(720, 313);
            this.metroTabPageContactList.TabIndex = 4;
            this.metroTabPageContactList.Text = "Контакты";
            this.metroTabPageContactList.VerticalScrollbarBarColor = true;
            // 
            // listBoxContactList
            // 
            this.listBoxContactList.FormattingEnabled = true;
            this.listBoxContactList.Location = new System.Drawing.Point(3, 3);
            this.listBoxContactList.Name = "listBoxContactList";
            this.listBoxContactList.Size = new System.Drawing.Size(264, 264);
            this.listBoxContactList.TabIndex = 2;
            this.listBoxContactList.SelectedIndexChanged += new System.EventHandler(this.listBoxContactList_SelectedIndexChanged);
            // 
            // metroTileAddContact
            // 
            this.metroTileAddContact.Location = new System.Drawing.Point(3, 269);
            this.metroTileAddContact.Name = "metroTileAddContact";
            this.metroTileAddContact.Size = new System.Drawing.Size(84, 29);
            this.metroTileAddContact.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTileAddContact.TabIndex = 3;
            this.metroTileAddContact.Text = "Добавить";
            this.metroTileAddContact.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileAddContact.Click += new System.EventHandler(this.metroTileAddContact_Click);
            // 
            // metroTileEditContact
            // 
            this.metroTileEditContact.Location = new System.Drawing.Point(93, 269);
            this.metroTileEditContact.Name = "metroTileEditContact";
            this.metroTileEditContact.Size = new System.Drawing.Size(84, 29);
            this.metroTileEditContact.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTileEditContact.TabIndex = 4;
            this.metroTileEditContact.Text = "Изменить";
            this.metroTileEditContact.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileEditContact.Click += new System.EventHandler(this.metroTileEditContact_Click);
            // 
            // metroTileDeleteContact
            // 
            this.metroTileDeleteContact.Location = new System.Drawing.Point(183, 269);
            this.metroTileDeleteContact.Name = "metroTileDeleteContact";
            this.metroTileDeleteContact.Size = new System.Drawing.Size(84, 29);
            this.metroTileDeleteContact.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTileDeleteContact.TabIndex = 5;
            this.metroTileDeleteContact.Text = "Удалить";
            this.metroTileDeleteContact.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileDeleteContact.Click += new System.EventHandler(this.metroTileDeleteContact_Click);
            // 
            // metroPanelContactInfo
            // 
            this.metroPanelContactInfo.BackColor = System.Drawing.SystemColors.Control;
            this.metroPanelContactInfo.Controls.Add(this.richTextBoxContactDescription);
            this.metroPanelContactInfo.Controls.Add(this.textBoxContactName);
            this.metroPanelContactInfo.Controls.Add(this.textBoxContactSurname);
            this.metroPanelContactInfo.Controls.Add(this.metroLabel3);
            this.metroPanelContactInfo.Controls.Add(this.metroLabel2);
            this.metroPanelContactInfo.Controls.Add(this.metroLabel1);
            this.metroPanelContactInfo.HorizontalScrollbarBarColor = true;
            this.metroPanelContactInfo.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanelContactInfo.HorizontalScrollbarSize = 10;
            this.metroPanelContactInfo.Location = new System.Drawing.Point(273, 3);
            this.metroPanelContactInfo.Name = "metroPanelContactInfo";
            this.metroPanelContactInfo.Size = new System.Drawing.Size(447, 198);
            this.metroPanelContactInfo.Style = MetroFramework.MetroColorStyle.Green;
            this.metroPanelContactInfo.TabIndex = 6;
            this.metroPanelContactInfo.VerticalScrollbarBarColor = true;
            this.metroPanelContactInfo.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanelContactInfo.VerticalScrollbarSize = 10;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(67, 15);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(78, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Фамилия:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(102, 45);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(43, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Имя:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.Location = new System.Drawing.Point(3, 73);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(142, 19);
            this.metroLabel3.TabIndex = 4;
            this.metroLabel3.Text = "Доп. информация:";
            // 
            // textBoxContactSurname
            // 
            this.textBoxContactSurname.Location = new System.Drawing.Point(151, 14);
            this.textBoxContactSurname.Name = "textBoxContactSurname";
            this.textBoxContactSurname.Size = new System.Drawing.Size(280, 20);
            this.textBoxContactSurname.TabIndex = 5;
            // 
            // textBoxContactName
            // 
            this.textBoxContactName.Location = new System.Drawing.Point(151, 44);
            this.textBoxContactName.Name = "textBoxContactName";
            this.textBoxContactName.Size = new System.Drawing.Size(280, 20);
            this.textBoxContactName.TabIndex = 6;
            // 
            // richTextBoxContactDescription
            // 
            this.richTextBoxContactDescription.Location = new System.Drawing.Point(151, 73);
            this.richTextBoxContactDescription.Name = "richTextBoxContactDescription";
            this.richTextBoxContactDescription.Size = new System.Drawing.Size(280, 113);
            this.richTextBoxContactDescription.TabIndex = 7;
            this.richTextBoxContactDescription.Text = "";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.Location = new System.Drawing.Point(276, 225);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(193, 25);
            this.metroLabel4.TabIndex = 7;
            this.metroLabel4.Text = "Электронный адрес:";
            // 
            // textBoxContactEmail
            // 
            this.textBoxContactEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxContactEmail.Location = new System.Drawing.Point(475, 225);
            this.textBoxContactEmail.Name = "textBoxContactEmail";
            this.textBoxContactEmail.Size = new System.Drawing.Size(229, 26);
            this.textBoxContactEmail.TabIndex = 8;
            // 
            // metroTileSendMSGContact
            // 
            this.metroTileSendMSGContact.Location = new System.Drawing.Point(568, 269);
            this.metroTileSendMSGContact.Name = "metroTileSendMSGContact";
            this.metroTileSendMSGContact.Size = new System.Drawing.Size(136, 29);
            this.metroTileSendMSGContact.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTileSendMSGContact.TabIndex = 9;
            this.metroTileSendMSGContact.Text = "Отправить письмо";
            this.metroTileSendMSGContact.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileSendMSGContact.Click += new System.EventHandler(this.metroTileSendMSGContact_Click);
            // 
            // metroProgressSpinnerStatus
            // 
            this.metroProgressSpinnerStatus.Location = new System.Drawing.Point(719, 64);
            this.metroProgressSpinnerStatus.Maximum = 100;
            this.metroProgressSpinnerStatus.Name = "metroProgressSpinnerStatus";
            this.metroProgressSpinnerStatus.Size = new System.Drawing.Size(32, 32);
            this.metroProgressSpinnerStatus.Style = MetroFramework.MetroColorStyle.Green;
            this.metroProgressSpinnerStatus.TabIndex = 4;
            this.metroProgressSpinnerStatus.Visible = false;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(633, 72);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(71, 19);
            this.metroLabel5.TabIndex = 5;
            this.metroLabel5.Text = "Загрузка...";
            this.metroLabel5.Visible = false;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(782, 477);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroProgressSpinnerStatus);
            this.Controls.Add(this.metroTileSendMSG);
            this.Controls.Add(this.metroTabControl1);
            this.Controls.Add(this.metroLabelStatusLogin);
            this.Controls.Add(this.metroTileLogOut);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(782, 477);
            this.MinimumSize = new System.Drawing.Size(782, 477);
            this.Name = "MainWindow";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Onion Mail";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainWindow_FormClosed);
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPageInbox.ResumeLayout(false);
            this.metroTabPageSent.ResumeLayout(false);
            this.metroTabPageTrash.ResumeLayout(false);
            this.metroTabPageContactList.ResumeLayout(false);
            this.metroTabPageContactList.PerformLayout();
            this.metroPanelContactInfo.ResumeLayout(false);
            this.metroPanelContactInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private MetroFramework.Controls.MetroTile metroTileLogOut;
        private MetroFramework.Controls.MetroLabel metroLabelStatusLogin;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPageInbox;
        private MetroFramework.Controls.MetroTabPage metroTabPageSent;
        private MetroFramework.Controls.MetroTabPage metroTabPageTrash;
        private MetroFramework.Controls.MetroTile metroTileSendMSG;
        private System.Windows.Forms.ListBox listBoxInboxUids;
        private System.ComponentModel.BackgroundWorker bgWorker;
        private MetroFramework.Controls.MetroTile metroTileDeleteMSG;
        private MetroFramework.Controls.MetroTile metroTileReplyMSG;
        private MetroFramework.Controls.MetroTile metroTileRefreshInbox;
        private System.Windows.Forms.ListBox listBoxSentUids; 
        private System.Windows.Forms.ListBox listBoxTrashUids;
        private MetroFramework.Controls.MetroTile metroTileSentDeleteMSG;
        private MetroFramework.Controls.MetroTile metroTileSentRefresh;
        private MetroFramework.Controls.MetroTile metroTileTrashDeleteMSG;
        private MetroFramework.Controls.MetroTile metroTileTrashRefresh;
        private MetroFramework.Controls.MetroTabPage metroTabPageContactList;
        private MetroFramework.Controls.MetroPanel metroPanelContactInfo;
        private MetroFramework.Controls.MetroTile metroTileDeleteContact;
        private MetroFramework.Controls.MetroTile metroTileEditContact;
        private MetroFramework.Controls.MetroTile metroTileAddContact;
        private System.Windows.Forms.ListBox listBoxContactList;
        private MetroFramework.Controls.MetroTile metroTileSendMSGContact;
        private System.Windows.Forms.TextBox textBoxContactEmail;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.RichTextBox richTextBoxContactDescription;
        private System.Windows.Forms.TextBox textBoxContactName;
        private System.Windows.Forms.TextBox textBoxContactSurname;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroProgressSpinner metroProgressSpinnerStatus;
        private MetroFramework.Controls.MetroLabel metroLabel5;
    }
}