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
    }
}