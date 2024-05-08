namespace WindowsFormsApp1
{
    partial class Login
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
            this.UserField = new System.Windows.Forms.TextBox();
            this.PasswordField = new System.Windows.Forms.TextBox();
            this.LoginButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CloseBtnPic = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.LoginMainPic = new System.Windows.Forms.PictureBox();
            this.UserLabelPic = new System.Windows.Forms.PictureBox();
            this.PasswordLabelPic = new System.Windows.Forms.PictureBox();
            this.LoginBtnPic = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloseBtnPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoginMainPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserLabelPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordLabelPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoginBtnPic)).BeginInit();
            this.SuspendLayout();
            // 
            // UserField
            // 
            this.UserField.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.UserField.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.UserField.Location = new System.Drawing.Point(319, 340);
            this.UserField.Name = "UserField";
            this.UserField.Size = new System.Drawing.Size(260, 29);
            this.UserField.TabIndex = 0;
            this.UserField.Text = "Felhasználónév";
            this.UserField.MouseClick += new System.Windows.Forms.MouseEventHandler(this.UserField_MouseClick);
            this.UserField.TextChanged += new System.EventHandler(this.UserField_TextChanged);
            // 
            // PasswordField
            // 
            this.PasswordField.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.PasswordField.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.PasswordField.Location = new System.Drawing.Point(319, 382);
            this.PasswordField.Name = "PasswordField";
            this.PasswordField.Size = new System.Drawing.Size(260, 29);
            this.PasswordField.TabIndex = 1;
            this.PasswordField.Text = "Jelszó";
            this.PasswordField.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PasswordField_MouseClick);
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.LoginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.LoginButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LoginButton.Location = new System.Drawing.Point(319, 417);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(260, 32);
            this.LoginButton.TabIndex = 4;
            this.LoginButton.Text = "Bejelentkezés";
            this.LoginButton.UseVisualStyleBackColor = false;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel2.Controls.Add(this.CloseBtnPic);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox6);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(923, 65);
            this.panel2.TabIndex = 8;
            // 
            // CloseBtnPic
            // 
            this.CloseBtnPic.Image = global::WindowsFormsApp1.Properties.Resources.Exit;
            this.CloseBtnPic.Location = new System.Drawing.Point(884, 0);
            this.CloseBtnPic.Name = "CloseBtnPic";
            this.CloseBtnPic.Size = new System.Drawing.Size(39, 38);
            this.CloseBtnPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CloseBtnPic.TabIndex = 10;
            this.CloseBtnPic.TabStop = false;
            this.CloseBtnPic.Click += new System.EventHandler(this.CloseBtnPic_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 8F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(822, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Design by: Fanni";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(57, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 47);
            this.label1.TabIndex = 1;
            this.label1.Text = "RHM Napelem Projekt";
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::WindowsFormsApp1.Properties.Resources.sun1;
            this.pictureBox6.Location = new System.Drawing.Point(0, 2);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(51, 63);
            this.pictureBox6.TabIndex = 0;
            this.pictureBox6.TabStop = false;
            // 
            // LoginMainPic
            // 
            this.LoginMainPic.Image = global::WindowsFormsApp1.Properties.Resources.mini_icon;
            this.LoginMainPic.Location = new System.Drawing.Point(319, 108);
            this.LoginMainPic.Name = "LoginMainPic";
            this.LoginMainPic.Size = new System.Drawing.Size(260, 214);
            this.LoginMainPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LoginMainPic.TabIndex = 9;
            this.LoginMainPic.TabStop = false;
            // 
            // UserLabelPic
            // 
            this.UserLabelPic.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.UserLabelPic.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.email;
            this.UserLabelPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.UserLabelPic.Location = new System.Drawing.Point(277, 340);
            this.UserLabelPic.Name = "UserLabelPic";
            this.UserLabelPic.Size = new System.Drawing.Size(25, 30);
            this.UserLabelPic.TabIndex = 7;
            this.UserLabelPic.TabStop = false;
            // 
            // PasswordLabelPic
            // 
            this.PasswordLabelPic.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PasswordLabelPic.BackgroundImage = global::WindowsFormsApp1.Properties.Resources._lock;
            this.PasswordLabelPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PasswordLabelPic.Location = new System.Drawing.Point(276, 382);
            this.PasswordLabelPic.Name = "PasswordLabelPic";
            this.PasswordLabelPic.Size = new System.Drawing.Size(26, 29);
            this.PasswordLabelPic.TabIndex = 6;
            this.PasswordLabelPic.TabStop = false;
            // 
            // LoginBtnPic
            // 
            this.LoginBtnPic.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LoginBtnPic.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.login_icon;
            this.LoginBtnPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LoginBtnPic.Location = new System.Drawing.Point(276, 417);
            this.LoginBtnPic.Name = "LoginBtnPic";
            this.LoginBtnPic.Size = new System.Drawing.Size(25, 31);
            this.LoginBtnPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.LoginBtnPic.TabIndex = 5;
            this.LoginBtnPic.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(923, 560);
            this.Controls.Add(this.LoginMainPic);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.UserLabelPic);
            this.Controls.Add(this.PasswordLabelPic);
            this.Controls.Add(this.LoginBtnPic);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.PasswordField);
            this.Controls.Add(this.UserField);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.Text = "Login";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloseBtnPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoginMainPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserLabelPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordLabelPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoginBtnPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UserField;
        private System.Windows.Forms.TextBox PasswordField;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.PictureBox LoginBtnPic;
        private System.Windows.Forms.PictureBox PasswordLabelPic;
        private System.Windows.Forms.PictureBox UserLabelPic;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox LoginMainPic;
        private System.Windows.Forms.PictureBox CloseBtnPic;
    }
}