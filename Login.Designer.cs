namespace BankManagement
{
    partial class LoginForm
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
            this.lblUTCBank = new System.Windows.Forms.Label();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.roundControl1 = new BankManagement.RoundControl();
            this.lblAdminLogin = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtUsername = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnLogin = new Guna.UI2.WinForms.Guna2GradientButton();
            this.lblWarningLogin = new System.Windows.Forms.Label();
            this.imgLoginForm = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.btnMinimizeLogin = new System.Windows.Forms.PictureBox();
            this.btnCloseLogin = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgLoginForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizeLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCloseLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUTCBank
            // 
            this.lblUTCBank.AutoSize = true;
            this.lblUTCBank.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUTCBank.ForeColor = System.Drawing.Color.White;
            this.lblUTCBank.Location = new System.Drawing.Point(131, 63);
            this.lblUTCBank.Name = "lblUTCBank";
            this.lblUTCBank.Size = new System.Drawing.Size(131, 26);
            this.lblUTCBank.TabIndex = 2;
            this.lblUTCBank.Text = "UTC Bank";
            this.lblUTCBank.Click += new System.EventHandler(this.txtUTCBank_Click);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.Transparent;
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(0, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1200, 42);
            this.panelTitleBar.TabIndex = 3;
            this.panelTitleBar.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTitleBar_Paint);
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // roundControl1
            // 
            this.roundControl1.BackgroundColor = System.Drawing.Color.White;
            this.roundControl1.BorderColor = System.Drawing.SystemColors.Control;
            this.roundControl1.BorderWidth = 1F;
            this.roundControl1.Location = new System.Drawing.Point(200, 125);
            this.roundControl1.Name = "roundControl1";
            this.roundControl1.Radius = 10;
            this.roundControl1.Size = new System.Drawing.Size(800, 450);
            this.roundControl1.TabIndex = 4;
            this.roundControl1.Load += new System.EventHandler(this.roundControl1_Load);
            // 
            // lblAdminLogin
            // 
            this.lblAdminLogin.AutoSize = true;
            this.lblAdminLogin.BackColor = System.Drawing.Color.White;
            this.lblAdminLogin.Font = new System.Drawing.Font("Bahnschrift SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminLogin.Location = new System.Drawing.Point(341, 243);
            this.lblAdminLogin.Name = "lblAdminLogin";
            this.lblAdminLogin.Size = new System.Drawing.Size(141, 28);
            this.lblAdminLogin.TabIndex = 6;
            this.lblAdminLogin.Text = "Admin Login";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.BackColor = System.Drawing.Color.White;
            this.lblUserName.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(273, 287);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(88, 21);
            this.lblUserName.TabIndex = 6;
            this.lblUserName.Text = "Username";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.White;
            this.lblPassword.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(273, 369);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(86, 21);
            this.lblPassword.TabIndex = 6;
            this.lblPassword.Text = "Password";
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.White;
            this.txtUsername.BorderColor = System.Drawing.Color.Black;
            this.txtUsername.BorderRadius = 13;
            this.txtUsername.BorderThickness = 2;
            this.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsername.DefaultText = "";
            this.txtUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUsername.Font = new System.Drawing.Font("Bahnschrift", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.Color.Black;
            this.txtUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUsername.Location = new System.Drawing.Point(273, 309);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.PasswordChar = '\0';
            this.txtUsername.PlaceholderText = "";
            this.txtUsername.SelectedText = "";
            this.txtUsername.Size = new System.Drawing.Size(260, 45);
            this.txtUsername.TabIndex = 0;
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.White;
            this.txtPassword.BorderColor = System.Drawing.Color.Black;
            this.txtPassword.BorderRadius = 13;
            this.txtPassword.BorderThickness = 2;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.DefaultText = "";
            this.txtPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.Font = new System.Drawing.Font("Bahnschrift", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.Black;
            this.txtPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.Location = new System.Drawing.Point(273, 391);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.PlaceholderText = "";
            this.txtPassword.SelectedText = "";
            this.txtPassword.Size = new System.Drawing.Size(260, 45);
            this.txtPassword.TabIndex = 1;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.White;
            this.btnLogin.BorderRadius = 18;
            this.btnLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogin.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(186)))), ((int)(((byte)(146)))));
            this.btnLogin.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(245)))), ((int)(((byte)(152)))));
            this.btnLogin.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(329, 464);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(149, 45);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Login";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblWarningLogin
            // 
            this.lblWarningLogin.AutoSize = true;
            this.lblWarningLogin.BackColor = System.Drawing.Color.White;
            this.lblWarningLogin.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWarningLogin.ForeColor = System.Drawing.Color.Red;
            this.lblWarningLogin.Location = new System.Drawing.Point(375, 440);
            this.lblWarningLogin.Name = "lblWarningLogin";
            this.lblWarningLogin.Size = new System.Drawing.Size(0, 16);
            this.lblWarningLogin.TabIndex = 9;
            // 
            // imgLoginForm
            // 
            this.imgLoginForm.BackColor = System.Drawing.Color.White;
            this.imgLoginForm.Image = global::BankManagement.Properties.Resources.imgLogin;
            this.imgLoginForm.Location = new System.Drawing.Point(613, 230);
            this.imgLoginForm.Name = "imgLoginForm";
            this.imgLoginForm.Size = new System.Drawing.Size(318, 241);
            this.imgLoginForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgLoginForm.TabIndex = 7;
            this.imgLoginForm.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::BankManagement.Properties.Resources.userLogin;
            this.pictureBox1.Location = new System.Drawing.Point(371, 159);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // imgLogo
            // 
            this.imgLogo.Image = global::BankManagement.Properties.Resources.logo;
            this.imgLogo.Location = new System.Drawing.Point(55, 42);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(70, 70);
            this.imgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgLogo.TabIndex = 1;
            this.imgLogo.TabStop = false;
            // 
            // btnMinimizeLogin
            // 
            this.btnMinimizeLogin.Image = global::BankManagement.Properties.Resources.minimize;
            this.btnMinimizeLogin.Location = new System.Drawing.Point(1129, 8);
            this.btnMinimizeLogin.Name = "btnMinimizeLogin";
            this.btnMinimizeLogin.Size = new System.Drawing.Size(22, 22);
            this.btnMinimizeLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizeLogin.TabIndex = 0;
            this.btnMinimizeLogin.TabStop = false;
            this.btnMinimizeLogin.Click += new System.EventHandler(this.btnMinimizeLogin_Click);
            // 
            // btnCloseLogin
            // 
            this.btnCloseLogin.Image = global::BankManagement.Properties.Resources.close;
            this.btnCloseLogin.Location = new System.Drawing.Point(1165, 8);
            this.btnCloseLogin.Name = "btnCloseLogin";
            this.btnCloseLogin.Size = new System.Drawing.Size(22, 22);
            this.btnCloseLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCloseLogin.TabIndex = 0;
            this.btnCloseLogin.TabStop = false;
            this.btnCloseLogin.Click += new System.EventHandler(this.btnCloseLogin_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(134)))), ((int)(((byte)(102)))));
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.lblWarningLogin);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.imgLoginForm);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.lblAdminLogin);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.roundControl1);
            this.Controls.Add(this.lblUTCBank);
            this.Controls.Add(this.imgLogo);
            this.Controls.Add(this.btnMinimizeLogin);
            this.Controls.Add(this.btnCloseLogin);
            this.Controls.Add(this.panelTitleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(1200, 700);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgLoginForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizeLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCloseLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btnCloseLogin;
        private System.Windows.Forms.PictureBox btnMinimizeLogin;
        private System.Windows.Forms.PictureBox imgLogo;
        private System.Windows.Forms.Label lblUTCBank;
        private System.Windows.Forms.Panel panelTitleBar;
        private RoundControl roundControl1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblAdminLogin;
        private System.Windows.Forms.PictureBox imgLoginForm;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblPassword;
        private Guna.UI2.WinForms.Guna2TextBox txtUsername;
        private Guna.UI2.WinForms.Guna2TextBox txtPassword;
        private Guna.UI2.WinForms.Guna2GradientButton btnLogin;
        private System.Windows.Forms.Label lblWarningLogin;
    }
}

