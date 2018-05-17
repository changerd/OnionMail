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
            this.metroTabPageSent = new MetroFramework.Controls.MetroTabPage();
            this.metroTabPageTrash = new MetroFramework.Controls.MetroTabPage();
            this.metroTileSendMSG = new MetroFramework.Controls.MetroTile();
            this.metroTabControl1.SuspendLayout();
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
            this.metroLabelStatusLogin.Location = new System.Drawing.Point(542, 31);
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
            this.metroTabControl1.Location = new System.Drawing.Point(23, 102);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(728, 262);
            this.metroTabControl1.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTabControl1.TabIndex = 2;
            // 
            // metroTabPageInbox
            // 
            this.metroTabPageInbox.HorizontalScrollbarBarColor = true;
            this.metroTabPageInbox.Location = new System.Drawing.Point(4, 35);
            this.metroTabPageInbox.Name = "metroTabPageInbox";
            this.metroTabPageInbox.Size = new System.Drawing.Size(720, 223);
            this.metroTabPageInbox.TabIndex = 1;
            this.metroTabPageInbox.Text = "Входящие";
            this.metroTabPageInbox.VerticalScrollbarBarColor = true;
            // 
            // metroTabPageSent
            // 
            this.metroTabPageSent.HorizontalScrollbarBarColor = true;
            this.metroTabPageSent.Location = new System.Drawing.Point(4, 35);
            this.metroTabPageSent.Name = "metroTabPageSent";
            this.metroTabPageSent.Size = new System.Drawing.Size(720, 223);
            this.metroTabPageSent.TabIndex = 2;
            this.metroTabPageSent.Text = "Отправленные";
            this.metroTabPageSent.VerticalScrollbarBarColor = true;
            // 
            // metroTabPageTrash
            // 
            this.metroTabPageTrash.HorizontalScrollbarBarColor = true;
            this.metroTabPageTrash.Location = new System.Drawing.Point(4, 35);
            this.metroTabPageTrash.Name = "metroTabPageTrash";
            this.metroTabPageTrash.Size = new System.Drawing.Size(720, 223);
            this.metroTabPageTrash.TabIndex = 3;
            this.metroTabPageTrash.Text = "Корзина";
            this.metroTabPageTrash.VerticalScrollbarBarColor = true;
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
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 387);
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
    }
}