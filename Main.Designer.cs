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
            this.lbStaffName = new System.Windows.Forms.Label();
            this.lbBMS = new System.Windows.Forms.Label();
            this.guna2ResizeForm1 = new Guna.UI2.WinForms.Guna2ResizeForm(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSetting = new Guna.UI2.WinForms.Guna2Button();
            this.btnLoan = new Guna.UI2.WinForms.Guna2Button();
            this.btnTransaction = new Guna.UI2.WinForms.Guna2Button();
            this.btnAccount = new Guna.UI2.WinForms.Guna2Button();
            this.btnCustomer = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnMinimizeMain = new System.Windows.Forms.PictureBox();
            this.btnMaximizeMain = new System.Windows.Forms.PictureBox();
            this.btnCloseMain = new System.Windows.Forms.PictureBox();
            this.imgLogoMain = new System.Windows.Forms.PictureBox();
            this.panelTitleBarMain.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizeMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizeMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCloseMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogoMain)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTitleBarMain
            // 
            this.panelTitleBarMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.panelTitleBarMain.Controls.Add(this.pictureBox1);
            this.panelTitleBarMain.Controls.Add(this.pictureBox2);
            this.panelTitleBarMain.Controls.Add(this.lbStaffName);
            this.panelTitleBarMain.Controls.Add(this.btnMinimizeMain);
            this.panelTitleBarMain.Controls.Add(this.btnMaximizeMain);
            this.panelTitleBarMain.Controls.Add(this.btnCloseMain);
            this.panelTitleBarMain.Controls.Add(this.lbBMS);
            this.panelTitleBarMain.Controls.Add(this.imgLogoMain);
            this.panelTitleBarMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBarMain.ForeColor = System.Drawing.Color.White;
            this.panelTitleBarMain.Location = new System.Drawing.Point(0, 0);
            this.panelTitleBarMain.Name = "panelTitleBarMain";
            this.panelTitleBarMain.Size = new System.Drawing.Size(1200, 58);
            this.panelTitleBarMain.TabIndex = 0;
            this.panelTitleBarMain.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBarMain_MouseDown);
            // 
            // lbStaffName
            // 
            this.lbStaffName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbStaffName.AutoSize = true;
            this.lbStaffName.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStaffName.ForeColor = System.Drawing.Color.White;
            this.lbStaffName.Location = new System.Drawing.Point(843, 19);
            this.lbStaffName.Name = "lbStaffName";
            this.lbStaffName.Size = new System.Drawing.Size(123, 21);
            this.lbStaffName.TabIndex = 2;
            this.lbStaffName.Text = "Nguyen Anh Vy";
            // 
            // lbBMS
            // 
            this.lbBMS.AutoSize = true;
            this.lbBMS.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBMS.ForeColor = System.Drawing.Color.White;
            this.lbBMS.Location = new System.Drawing.Point(71, 17);
            this.lbBMS.Name = "lbBMS";
            this.lbBMS.Size = new System.Drawing.Size(250, 24);
            this.lbBMS.TabIndex = 1;
            this.lbBMS.Text = "Bank Management System";
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
            this.panel1.Location = new System.Drawing.Point(0, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(207, 642);
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
            this.btnSetting.Location = new System.Drawing.Point(43, 552);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(120, 70);
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
            this.btnLoan.Location = new System.Drawing.Point(12, 296);
            this.btnLoan.Name = "btnLoan";
            this.btnLoan.Size = new System.Drawing.Size(180, 59);
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
            this.btnTransaction.Location = new System.Drawing.Point(12, 205);
            this.btnTransaction.Name = "btnTransaction";
            this.btnTransaction.Size = new System.Drawing.Size(180, 59);
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
            this.btnAccount.Location = new System.Drawing.Point(12, 114);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Size = new System.Drawing.Size(180, 59);
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
            this.btnCustomer.Location = new System.Drawing.Point(12, 23);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(180, 59);
            this.btnCustomer.TabIndex = 0;
            this.btnCustomer.Text = "Customer";
            this.btnCustomer.TextOffset = new System.Drawing.Point(0, -2);
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::BankManagement.Properties.Resources.staff_woman;
            this.pictureBox1.Location = new System.Drawing.Point(783, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = global::BankManagement.Properties.Resources.notification_bell;
            this.pictureBox2.Location = new System.Drawing.Point(1002, 13);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(28, 28);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // btnMinimizeMain
            // 
            this.btnMinimizeMain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizeMain.Image = global::BankManagement.Properties.Resources.minimize;
            this.btnMinimizeMain.Location = new System.Drawing.Point(1071, 18);
            this.btnMinimizeMain.Name = "btnMinimizeMain";
            this.btnMinimizeMain.Size = new System.Drawing.Size(22, 22);
            this.btnMinimizeMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizeMain.TabIndex = 1;
            this.btnMinimizeMain.TabStop = false;
            this.btnMinimizeMain.Click += new System.EventHandler(this.btnMinimizeMain_Click);
            // 
            // btnMaximizeMain
            // 
            this.btnMaximizeMain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizeMain.Image = global::BankManagement.Properties.Resources.maximize;
            this.btnMaximizeMain.Location = new System.Drawing.Point(1115, 18);
            this.btnMaximizeMain.Name = "btnMaximizeMain";
            this.btnMaximizeMain.Size = new System.Drawing.Size(22, 22);
            this.btnMaximizeMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMaximizeMain.TabIndex = 1;
            this.btnMaximizeMain.TabStop = false;
            this.btnMaximizeMain.Click += new System.EventHandler(this.btnMaximizeMain_Click);
            // 
            // btnCloseMain
            // 
            this.btnCloseMain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCloseMain.Image = global::BankManagement.Properties.Resources.close;
            this.btnCloseMain.Location = new System.Drawing.Point(1160, 18);
            this.btnCloseMain.Name = "btnCloseMain";
            this.btnCloseMain.Size = new System.Drawing.Size(22, 22);
            this.btnCloseMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCloseMain.TabIndex = 1;
            this.btnCloseMain.TabStop = false;
            this.btnCloseMain.Click += new System.EventHandler(this.btnCloseMain_Click);
            // 
            // imgLogoMain
            // 
            this.imgLogoMain.Image = global::BankManagement.Properties.Resources.logo;
            this.imgLogoMain.Location = new System.Drawing.Point(17, 7);
            this.imgLogoMain.Name = "imgLogoMain";
            this.imgLogoMain.Size = new System.Drawing.Size(50, 50);
            this.imgLogoMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgLogoMain.TabIndex = 0;
            this.imgLogoMain.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelTitleBarMain);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(1200, 700);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.panelTitleBarMain.ResumeLayout(false);
            this.panelTitleBarMain.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizeMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizeMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCloseMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogoMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitleBarMain;
        private System.Windows.Forms.PictureBox imgLogoMain;
        private System.Windows.Forms.Label lbBMS;
        private Guna.UI2.WinForms.Guna2ResizeForm guna2ResizeForm1;
        private System.Windows.Forms.PictureBox btnMinimizeMain;
        private System.Windows.Forms.PictureBox btnMaximizeMain;
        private System.Windows.Forms.PictureBox btnCloseMain;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbStaffName;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Guna.UI2.WinForms.Guna2Button btnCustomer;
        private Guna.UI2.WinForms.Guna2Button btnAccount;
        private Guna.UI2.WinForms.Guna2Button btnTransaction;
        private Guna.UI2.WinForms.Guna2Button btnLoan;
        private Guna.UI2.WinForms.Guna2Button btnSetting;
    }
}