namespace OnionMail
{
    partial class SendMessage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SendMessage));
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroCheckBoxAttachment = new MetroFramework.Controls.MetroCheckBox();
            this.textBoxTo = new System.Windows.Forms.TextBox();
            this.textBoxSubject = new System.Windows.Forms.TextBox();
            this.richTextBoxBody = new System.Windows.Forms.RichTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroTileSendMSG = new MetroFramework.Controls.MetroTile();
            this.metroButtonAttachment = new MetroFramework.Controls.MetroButton();
            this.metroLabelAttachmentStatus = new MetroFramework.Controls.MetroLabel();
            this.metroButtonClearAttachment = new MetroFramework.Controls.MetroButton();
            this.metroButtonShowElements = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 94);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(42, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Кому:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(24, 117);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(42, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Тема:";
            // 
            // metroCheckBoxAttachment
            // 
            this.metroCheckBoxAttachment.AutoSize = true;
            this.metroCheckBoxAttachment.Location = new System.Drawing.Point(24, 448);
            this.metroCheckBoxAttachment.Name = "metroCheckBoxAttachment";
            this.metroCheckBoxAttachment.Size = new System.Drawing.Size(79, 15);
            this.metroCheckBoxAttachment.TabIndex = 2;
            this.metroCheckBoxAttachment.Text = "Вложение";
            this.metroCheckBoxAttachment.UseVisualStyleBackColor = true;
            this.metroCheckBoxAttachment.CheckedChanged += new System.EventHandler(this.metroCheckBoxAttachment_CheckedChanged);
            // 
            // textBoxTo
            // 
            this.textBoxTo.Location = new System.Drawing.Point(71, 93);
            this.textBoxTo.Name = "textBoxTo";
            this.textBoxTo.Size = new System.Drawing.Size(337, 20);
            this.textBoxTo.TabIndex = 3;
            // 
            // textBoxSubject
            // 
            this.textBoxSubject.Location = new System.Drawing.Point(71, 119);
            this.textBoxSubject.Name = "textBoxSubject";
            this.textBoxSubject.Size = new System.Drawing.Size(337, 20);
            this.textBoxSubject.TabIndex = 4;
            // 
            // richTextBoxBody
            // 
            this.richTextBoxBody.Location = new System.Drawing.Point(71, 146);
            this.richTextBoxBody.Name = "richTextBoxBody";
            this.richTextBoxBody.Size = new System.Drawing.Size(337, 296);
            this.richTextBoxBody.TabIndex = 5;
            this.richTextBoxBody.Text = "";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(22, 146);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(43, 19);
            this.metroLabel3.TabIndex = 6;
            this.metroLabel3.Text = "Текст:";
            // 
            // metroTileSendMSG
            // 
            this.metroTileSendMSG.Location = new System.Drawing.Point(166, 523);
            this.metroTileSendMSG.Name = "metroTileSendMSG";
            this.metroTileSendMSG.Size = new System.Drawing.Size(98, 31);
            this.metroTileSendMSG.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTileSendMSG.TabIndex = 7;
            this.metroTileSendMSG.Text = "Отправить";
            this.metroTileSendMSG.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileSendMSG.Click += new System.EventHandler(this.metroTileSendMSG_Click);
            // 
            // metroButtonAttachment
            // 
            this.metroButtonAttachment.Location = new System.Drawing.Point(109, 448);
            this.metroButtonAttachment.Name = "metroButtonAttachment";
            this.metroButtonAttachment.Size = new System.Drawing.Size(57, 23);
            this.metroButtonAttachment.TabIndex = 8;
            this.metroButtonAttachment.Text = "Обзор";
            this.metroButtonAttachment.Visible = false;
            this.metroButtonAttachment.Click += new System.EventHandler(this.metroButtonAttachment_Click);
            // 
            // metroLabelAttachmentStatus
            // 
            this.metroLabelAttachmentStatus.AutoSize = true;
            this.metroLabelAttachmentStatus.Location = new System.Drawing.Point(172, 452);
            this.metroLabelAttachmentStatus.Name = "metroLabelAttachmentStatus";
            this.metroLabelAttachmentStatus.Size = new System.Drawing.Size(41, 19);
            this.metroLabelAttachmentStatus.TabIndex = 9;
            this.metroLabelAttachmentStatus.Text = "status";
            this.metroLabelAttachmentStatus.Visible = false;
            // 
            // metroButtonClearAttachment
            // 
            this.metroButtonClearAttachment.Location = new System.Drawing.Point(109, 477);
            this.metroButtonClearAttachment.Name = "metroButtonClearAttachment";
            this.metroButtonClearAttachment.Size = new System.Drawing.Size(127, 23);
            this.metroButtonClearAttachment.TabIndex = 10;
            this.metroButtonClearAttachment.Text = "Отчистить вложения";
            this.metroButtonClearAttachment.Visible = false;
            this.metroButtonClearAttachment.Click += new System.EventHandler(this.metroButtonClearAttachment_Click);
            // 
            // metroButtonShowElements
            // 
            this.metroButtonShowElements.Location = new System.Drawing.Point(242, 477);
            this.metroButtonShowElements.Name = "metroButtonShowElements";
            this.metroButtonShowElements.Size = new System.Drawing.Size(75, 23);
            this.metroButtonShowElements.TabIndex = 11;
            this.metroButtonShowElements.Text = "Элементы";
            this.metroButtonShowElements.Visible = false;
            this.metroButtonShowElements.Click += new System.EventHandler(this.metroButtonShowElements_Click);
            // 
            // SendMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 577);
            this.Controls.Add(this.metroButtonShowElements);
            this.Controls.Add(this.metroButtonClearAttachment);
            this.Controls.Add(this.metroLabelAttachmentStatus);
            this.Controls.Add(this.metroButtonAttachment);
            this.Controls.Add(this.metroTileSendMSG);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.richTextBoxBody);
            this.Controls.Add(this.textBoxSubject);
            this.Controls.Add(this.textBoxTo);
            this.Controls.Add(this.metroCheckBoxAttachment);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(431, 577);
            this.MinimumSize = new System.Drawing.Size(431, 577);
            this.Name = "SendMessage";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Отправка сообщения";
            this.Load += new System.EventHandler(this.SendMessage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroCheckBox metroCheckBoxAttachment;
        private System.Windows.Forms.TextBox textBoxTo;
        private System.Windows.Forms.TextBox textBoxSubject;
        private System.Windows.Forms.RichTextBox richTextBoxBody;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTile metroTileSendMSG;
        private MetroFramework.Controls.MetroButton metroButtonAttachment;
        private MetroFramework.Controls.MetroLabel metroLabelAttachmentStatus;
        private MetroFramework.Controls.MetroButton metroButtonClearAttachment;
        private MetroFramework.Controls.MetroButton metroButtonShowElements;
    }
}