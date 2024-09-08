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
            this.lbBMS = new System.Windows.Forms.Label();
            this.guna2ResizeForm1 = new Guna.UI2.WinForms.Guna2ResizeForm(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbStaffName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnMinimizeMain = new System.Windows.Forms.PictureBox();
            this.btnMaximizeMain = new System.Windows.Forms.PictureBox();
            this.btnCloseMain = new System.Windows.Forms.PictureBox();
            this.imgLogoMain = new System.Windows.Forms.PictureBox();
            this.panelTitleBarMain.SuspendLayout();
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
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(182, 642);
            this.panel1.TabIndex = 1;
            // 
            // lbStaffName
            // 
            this.lbStaffName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbStaffName.AutoSize = true;
            this.lbStaffName.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStaffName.ForeColor = System.Drawing.Color.White;
            this.lbStaffName.Location = new System.Drawing.Point(853, 19);
            this.lbStaffName.Name = "lbStaffName";
            this.lbStaffName.Size = new System.Drawing.Size(123, 21);
            this.lbStaffName.TabIndex = 2;
            this.lbStaffName.Text = "Nguyen Anh Vy";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::BankManagement.Properties.Resources.staff;
            this.pictureBox1.Location = new System.Drawing.Point(800, 4);
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
            this.imgLogoMain.Location = new System.Drawing.Point(17, 4);
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
    }
}