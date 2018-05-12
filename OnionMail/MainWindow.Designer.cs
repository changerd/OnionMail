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
            this.metroLinkInbox = new MetroFramework.Controls.MetroLink();
            this.metroLinkSent = new MetroFramework.Controls.MetroLink();
            this.metroLinkTrash = new MetroFramework.Controls.MetroLink();
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
            // metroLinkInbox
            // 
            this.metroLinkInbox.Location = new System.Drawing.Point(23, 79);
            this.metroLinkInbox.Name = "metroLinkInbox";
            this.metroLinkInbox.Size = new System.Drawing.Size(75, 23);
            this.metroLinkInbox.TabIndex = 1;
            this.metroLinkInbox.Text = "Входящие";
            // 
            // metroLinkSent
            // 
            this.metroLinkSent.Location = new System.Drawing.Point(23, 108);
            this.metroLinkSent.Name = "metroLinkSent";
            this.metroLinkSent.Size = new System.Drawing.Size(94, 23);
            this.metroLinkSent.TabIndex = 2;
            this.metroLinkSent.Text = "Отправленные";
            // 
            // metroLinkTrash
            // 
            this.metroLinkTrash.Location = new System.Drawing.Point(23, 137);
            this.metroLinkTrash.Name = "metroLinkTrash";
            this.metroLinkTrash.Size = new System.Drawing.Size(59, 23);
            this.metroLinkTrash.TabIndex = 3;
            this.metroLinkTrash.Text = "Корзина";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 387);
            this.Controls.Add(this.metroLinkTrash);
            this.Controls.Add(this.metroLinkSent);
            this.Controls.Add(this.metroLinkInbox);
            this.Controls.Add(this.metroTileLogOut);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindow";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Onion Mail";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainWindow_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile metroTileLogOut;
        private MetroFramework.Controls.MetroLink metroLinkInbox;
        private MetroFramework.Controls.MetroLink metroLinkSent;
        private MetroFramework.Controls.MetroLink metroLinkTrash;
    }
}