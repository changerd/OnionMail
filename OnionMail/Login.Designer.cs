namespace OnionMail
{
    partial class Login
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.comboBoxMail = new System.Windows.Forms.ComboBox();
            this.metroTileLogin = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Location = new System.Drawing.Point(35, 90);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(100, 20);
            this.textBoxLogin.TabIndex = 1;
            this.textBoxLogin.Tag = "Логин...";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(35, 131);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(100, 20);
            this.textBoxPassword.TabIndex = 3;
            this.textBoxPassword.Tag = "Пароль...";
            // 
            // comboBoxMail
            // 
            this.comboBoxMail.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMail.FormattingEnabled = true;
            this.comboBoxMail.Location = new System.Drawing.Point(141, 90);
            this.comboBoxMail.Name = "comboBoxMail";
            this.comboBoxMail.Size = new System.Drawing.Size(100, 21);
            this.comboBoxMail.TabIndex = 2;
            // 
            // metroTileLogin
            // 
            this.metroTileLogin.Location = new System.Drawing.Point(98, 182);
            this.metroTileLogin.Name = "metroTileLogin";
            this.metroTileLogin.Size = new System.Drawing.Size(75, 34);
            this.metroTileLogin.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTileLogin.TabIndex = 4;
            this.metroTileLogin.Text = "Войти";
            this.metroTileLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileLogin.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(268, 261);
            this.Controls.Add(this.metroTileLogin);
            this.Controls.Add(this.comboBoxMail);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxLogin);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MaximumSize = new System.Drawing.Size(268, 261);
            this.MinimumSize = new System.Drawing.Size(268, 261);
            this.Name = "Login";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.ComboBox comboBoxMail;
        private MetroFramework.Controls.MetroTile metroTileLogin;
    }
}

