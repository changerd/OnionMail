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
            this.listBoxTrashUids = new System.Windows.Forms.ListBox();
            this.metroTileSendMSG = new MetroFramework.Controls.MetroTile();
            this.bgWorker = new System.ComponentModel.BackgroundWorker();
            this.metroTileTrashRefresh = new MetroFramework.Controls.MetroTile();
            this.metroTileTrashDeleteMSG = new MetroFramework.Controls.MetroTile();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPageInbox.SuspendLayout();
            this.metroTabPageSent.SuspendLayout();
            this.metroTabPageTrash.SuspendLayout();
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
            this.metroTabControl1.Location = new System.Drawing.Point(27, 102);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(728, 352);
            this.metroTabControl1.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTabControl1.TabIndex = 2;
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
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 477);
            this.Controls.Add(this.metroTileSendMSG);
            this.Controls.Add(this.metroTabControl1);
            this.Controls.Add(this.metroLabelStatusLogin);
            this.Controls.Add(this.metroTileLogOut);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindow";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Onion Mail";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainWindow_FormClosed);
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPageInbox.ResumeLayout(false);
            this.metroTabPageSent.ResumeLayout(false);
            this.metroTabPageTrash.ResumeLayout(false);
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
    }
}