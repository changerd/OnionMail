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
            this.metroTileLogOut = new MetroFramework.Controls.MetroTile();
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
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 387);
            this.Controls.Add(this.metroTileLogOut);
            this.Name = "MainWindow";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Onion Mail";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainWindow_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile metroTileLogOut;
    }
}