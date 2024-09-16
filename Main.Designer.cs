namespace BankManagement
{
    partial class Main
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
			this.components = new System.ComponentModel.Container();
			this.panelTitleBarMain = new System.Windows.Forms.Panel();
			this.btnMinimize = new Guna.UI2.WinForms.Guna2Button();
			this.btnMaximize = new Guna.UI2.WinForms.Guna2Button();
			this.btnClose = new Guna.UI2.WinForms.Guna2Button();
			this.btnStaffAvatar = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.lbStaffName = new System.Windows.Forms.Label();
			this.lbBMS = new System.Windows.Forms.Label();
			this.imgLogoMain = new System.Windows.Forms.PictureBox();
			this.guna2ResizeForm1 = new Guna.UI2.WinForms.Guna2ResizeForm(this.components);
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnSetting = new Guna.UI2.WinForms.Guna2Button();
			this.btnLoan = new Guna.UI2.WinForms.Guna2Button();
			this.btnTransaction = new Guna.UI2.WinForms.Guna2Button();
			this.btnAccount = new Guna.UI2.WinForms.Guna2Button();
			this.btnCustomer = new Guna.UI2.WinForms.Guna2Button();
			this.panelTitleBarMain.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.btnStaffAvatar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.imgLogoMain)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panelTitleBarMain
			// 
			this.panelTitleBarMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
			this.panelTitleBarMain.Controls.Add(this.btnMinimize);
			this.panelTitleBarMain.Controls.Add(this.btnMaximize);
			this.panelTitleBarMain.Controls.Add(this.btnClose);
			this.panelTitleBarMain.Controls.Add(this.btnStaffAvatar);
			this.panelTitleBarMain.Controls.Add(this.pictureBox2);
			this.panelTitleBarMain.Controls.Add(this.lbStaffName);
			this.panelTitleBarMain.Controls.Add(this.lbBMS);
			this.panelTitleBarMain.Controls.Add(this.imgLogoMain);
			this.panelTitleBarMain.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelTitleBarMain.ForeColor = System.Drawing.Color.White;
			this.panelTitleBarMain.Location = new System.Drawing.Point(0, 0);
			this.panelTitleBarMain.Margin = new System.Windows.Forms.Padding(2);
			this.panelTitleBarMain.Name = "panelTitleBarMain";
			this.panelTitleBarMain.Size = new System.Drawing.Size(900, 47);
			this.panelTitleBarMain.TabIndex = 0;
			this.panelTitleBarMain.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBarMain_MouseDown);
			// 
			// btnMinimize
			// 
			this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnMinimize.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnMinimize.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnMinimize.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnMinimize.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnMinimize.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
			this.btnMinimize.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.btnMinimize.ForeColor = System.Drawing.Color.White;
			this.btnMinimize.Image = global::BankManagement.Properties.Resources.minimize;
			this.btnMinimize.ImageSize = new System.Drawing.Size(14, 3);
			this.btnMinimize.Location = new System.Drawing.Point(765, 3);
			this.btnMinimize.Name = "btnMinimize";
			this.btnMinimize.Size = new System.Drawing.Size(40, 40);
			this.btnMinimize.TabIndex = 2;
			this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
			// 
			// btnMaximize
			// 
			this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnMaximize.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnMaximize.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnMaximize.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnMaximize.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnMaximize.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
			this.btnMaximize.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.btnMaximize.ForeColor = System.Drawing.Color.White;
			this.btnMaximize.Image = global::BankManagement.Properties.Resources.maximize;
			this.btnMaximize.ImageSize = new System.Drawing.Size(12, 12);
			this.btnMaximize.Location = new System.Drawing.Point(811, 3);
			this.btnMaximize.Name = "btnMaximize";
			this.btnMaximize.Size = new System.Drawing.Size(40, 40);
			this.btnMaximize.TabIndex = 2;
			this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
			// 
			// btnClose
			// 
			this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnClose.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
			this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.btnClose.ForeColor = System.Drawing.Color.White;
			this.btnClose.Image = global::BankManagement.Properties.Resources.close;
			this.btnClose.ImageSize = new System.Drawing.Size(12, 12);
			this.btnClose.Location = new System.Drawing.Point(857, 3);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(40, 40);
			this.btnClose.TabIndex = 2;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// btnStaffAvatar
			// 
			this.btnStaffAvatar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnStaffAvatar.Image = global::BankManagement.Properties.Resources.staff_woman;
			this.btnStaffAvatar.Location = new System.Drawing.Point(571, 3);
			this.btnStaffAvatar.Margin = new System.Windows.Forms.Padding(2);
			this.btnStaffAvatar.Name = "btnStaffAvatar";
			this.btnStaffAvatar.Size = new System.Drawing.Size(38, 41);
			this.btnStaffAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.btnStaffAvatar.TabIndex = 2;
			this.btnStaffAvatar.TabStop = false;
			this.btnStaffAvatar.Click += new System.EventHandler(this.btnStaffAvatar_Click);
			// 
			// pictureBox2
			// 
			this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox2.Image = global::BankManagement.Properties.Resources.notification_bell;
			this.pictureBox2.Location = new System.Drawing.Point(722, 11);
			this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(21, 23);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox2.TabIndex = 2;
			this.pictureBox2.TabStop = false;
			this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
			// 
			// lbStaffName
			// 
			this.lbStaffName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lbStaffName.AutoSize = true;
			this.lbStaffName.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbStaffName.ForeColor = System.Drawing.Color.White;
			this.lbStaffName.Location = new System.Drawing.Point(613, 16);
			this.lbStaffName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lbStaffName.Name = "lbStaffName";
			this.lbStaffName.Size = new System.Drawing.Size(105, 17);
			this.lbStaffName.TabIndex = 2;
			this.lbStaffName.Text = "Nguyen Anh Vy";
			// 
			// lbBMS
			// 
			this.lbBMS.AutoSize = true;
			this.lbBMS.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbBMS.ForeColor = System.Drawing.Color.White;
			this.lbBMS.Location = new System.Drawing.Point(53, 14);
			this.lbBMS.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lbBMS.Name = "lbBMS";
			this.lbBMS.Size = new System.Drawing.Size(201, 19);
			this.lbBMS.TabIndex = 1;
			this.lbBMS.Text = "Bank Management System";
			// 
			// imgLogoMain
			// 
			this.imgLogoMain.Image = global::BankManagement.Properties.Resources.logo;
			this.imgLogoMain.Location = new System.Drawing.Point(13, 6);
			this.imgLogoMain.Margin = new System.Windows.Forms.Padding(2);
			this.imgLogoMain.Name = "imgLogoMain";
			this.imgLogoMain.Size = new System.Drawing.Size(38, 41);
			this.imgLogoMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.imgLogoMain.TabIndex = 0;
			this.imgLogoMain.TabStop = false;
			// 
			// guna2ResizeForm1
			// 
			this.guna2ResizeForm1.TargetForm = this;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
			this.panel1.Controls.Add(this.btnSetting);
			this.panel1.Controls.Add(this.btnLoan);
			this.panel1.Controls.Add(this.btnTransaction);
			this.panel1.Controls.Add(this.btnAccount);
			this.panel1.Controls.Add(this.btnCustomer);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Location = new System.Drawing.Point(0, 47);
			this.panel1.Margin = new System.Windows.Forms.Padding(2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(155, 522);
			this.panel1.TabIndex = 1;
			// 
			// btnSetting
			// 
			this.btnSetting.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnSetting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnSetting.CustomBorderColor = System.Drawing.Color.Gainsboro;
			this.btnSetting.CustomBorderThickness = new System.Windows.Forms.Padding(0, 1, 0, 0);
			this.btnSetting.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnSetting.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnSetting.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnSetting.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnSetting.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
			this.btnSetting.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSetting.ForeColor = System.Drawing.Color.White;
			this.btnSetting.Image = global::BankManagement.Properties.Resources.setting;
			this.btnSetting.ImageOffset = new System.Drawing.Point(-3, 5);
			this.btnSetting.ImageSize = new System.Drawing.Size(29, 29);
			this.btnSetting.Location = new System.Drawing.Point(32, 448);
			this.btnSetting.Margin = new System.Windows.Forms.Padding(2);
			this.btnSetting.Name = "btnSetting";
			this.btnSetting.Size = new System.Drawing.Size(90, 57);
			this.btnSetting.TabIndex = 1;
			this.btnSetting.Text = "Setting";
			this.btnSetting.TextOffset = new System.Drawing.Point(0, 5);
			this.btnSetting.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
			this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
			// 
			// btnLoan
			// 
			this.btnLoan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnLoan.BorderRadius = 15;
			this.btnLoan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnLoan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnLoan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnLoan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnLoan.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(61)))), ((int)(((byte)(55)))));
			this.btnLoan.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLoan.ForeColor = System.Drawing.Color.White;
			this.btnLoan.Image = global::BankManagement.Properties.Resources.loan;
			this.btnLoan.ImageOffset = new System.Drawing.Point(-2, -1);
			this.btnLoan.ImageSize = new System.Drawing.Size(33, 33);
			this.btnLoan.Location = new System.Drawing.Point(9, 240);
			this.btnLoan.Margin = new System.Windows.Forms.Padding(2);
			this.btnLoan.Name = "btnLoan";
			this.btnLoan.Size = new System.Drawing.Size(135, 48);
			this.btnLoan.TabIndex = 0;
			this.btnLoan.Text = "Loan";
			this.btnLoan.TextOffset = new System.Drawing.Point(0, -2);
			this.btnLoan.Click += new System.EventHandler(this.btnLoan_Click);
			// 
			// btnTransaction
			// 
			this.btnTransaction.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnTransaction.BorderRadius = 15;
			this.btnTransaction.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnTransaction.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnTransaction.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnTransaction.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnTransaction.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(61)))), ((int)(((byte)(55)))));
			this.btnTransaction.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnTransaction.ForeColor = System.Drawing.Color.White;
			this.btnTransaction.Image = global::BankManagement.Properties.Resources.transaction;
			this.btnTransaction.ImageOffset = new System.Drawing.Point(2, 0);
			this.btnTransaction.ImageSize = new System.Drawing.Size(30, 30);
			this.btnTransaction.Location = new System.Drawing.Point(9, 167);
			this.btnTransaction.Margin = new System.Windows.Forms.Padding(2);
			this.btnTransaction.Name = "btnTransaction";
			this.btnTransaction.Size = new System.Drawing.Size(135, 48);
			this.btnTransaction.TabIndex = 0;
			this.btnTransaction.Text = "Transaction";
			this.btnTransaction.TextOffset = new System.Drawing.Point(0, -2);
			this.btnTransaction.Click += new System.EventHandler(this.btnTransaction_Click);
			// 
			// btnAccount
			// 
			this.btnAccount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnAccount.BorderRadius = 15;
			this.btnAccount.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnAccount.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnAccount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnAccount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnAccount.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(61)))), ((int)(((byte)(55)))));
			this.btnAccount.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAccount.ForeColor = System.Drawing.Color.White;
			this.btnAccount.Image = global::BankManagement.Properties.Resources.account1;
			this.btnAccount.ImageOffset = new System.Drawing.Point(-2, 0);
			this.btnAccount.ImageSize = new System.Drawing.Size(32, 32);
			this.btnAccount.Location = new System.Drawing.Point(9, 93);
			this.btnAccount.Margin = new System.Windows.Forms.Padding(2);
			this.btnAccount.Name = "btnAccount";
			this.btnAccount.Size = new System.Drawing.Size(135, 48);
			this.btnAccount.TabIndex = 0;
			this.btnAccount.Text = "Account";
			this.btnAccount.TextOffset = new System.Drawing.Point(0, -2);
			this.btnAccount.Click += new System.EventHandler(this.btnAccount_Click);
			// 
			// btnCustomer
			// 
			this.btnCustomer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnCustomer.BorderRadius = 15;
			this.btnCustomer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnCustomer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnCustomer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnCustomer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnCustomer.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(61)))), ((int)(((byte)(55)))));
			this.btnCustomer.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCustomer.ForeColor = System.Drawing.Color.White;
			this.btnCustomer.Image = global::BankManagement.Properties.Resources.customer;
			this.btnCustomer.ImageSize = new System.Drawing.Size(32, 32);
			this.btnCustomer.Location = new System.Drawing.Point(9, 19);
			this.btnCustomer.Margin = new System.Windows.Forms.Padding(2);
			this.btnCustomer.Name = "btnCustomer";
			this.btnCustomer.Size = new System.Drawing.Size(135, 48);
			this.btnCustomer.TabIndex = 0;
			this.btnCustomer.Text = "Customer";
			this.btnCustomer.TextOffset = new System.Drawing.Point(0, -2);
			this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.ClientSize = new System.Drawing.Size(900, 569);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.panelTitleBarMain);
			this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(2);
			this.MinimumSize = new System.Drawing.Size(900, 569);
			this.Name = "Main";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Main";
			this.Load += new System.EventHandler(this.Main_Load);
			this.panelTitleBarMain.ResumeLayout(false);
			this.panelTitleBarMain.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.btnStaffAvatar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.imgLogoMain)).EndInit();
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitleBarMain;
        private System.Windows.Forms.PictureBox imgLogoMain;
        private System.Windows.Forms.Label lbBMS;
        private Guna.UI2.WinForms.Guna2ResizeForm guna2ResizeForm1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btnStaffAvatar;
        private System.Windows.Forms.Label lbStaffName;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Guna.UI2.WinForms.Guna2Button btnCustomer;
        private Guna.UI2.WinForms.Guna2Button btnAccount;
        private Guna.UI2.WinForms.Guna2Button btnTransaction;
        private Guna.UI2.WinForms.Guna2Button btnLoan;
        private Guna.UI2.WinForms.Guna2Button btnSetting;
		private Guna.UI2.WinForms.Guna2Button btnClose;
		private Guna.UI2.WinForms.Guna2Button btnMaximize;
		private Guna.UI2.WinForms.Guna2Button btnMinimize;
	}
}