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
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.btnMaximizeManin = new System.Windows.Forms.PictureBox();
            this.btnCloseLogin = new System.Windows.Forms.PictureBox();
            this.btnMinimizeMain = new System.Windows.Forms.PictureBox();
            this.groupBoxControll = new System.Windows.Forms.GroupBox();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizeManin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCloseLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizeMain)).BeginInit();
            this.groupBoxControll.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.Black;
            this.panelTitleBar.Controls.Add(this.groupBoxControll);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(0, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(855, 42);
            this.panelTitleBar.TabIndex = 0;
            this.panelTitleBar.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTitleBar_Paint);
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // btnMaximizeManin
            // 
            this.btnMaximizeManin.Image = global::BankManagement.Properties.Resources.maximize;
            this.btnMaximizeManin.Location = new System.Drawing.Point(61, 12);
            this.btnMaximizeManin.Name = "btnMaximizeManin";
            this.btnMaximizeManin.Size = new System.Drawing.Size(22, 22);
            this.btnMaximizeManin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMaximizeManin.TabIndex = 3;
            this.btnMaximizeManin.TabStop = false;
            this.btnMaximizeManin.Click += new System.EventHandler(this.btnMaximizeManin_Click);
            // 
            // btnCloseLogin
            // 
            this.btnCloseLogin.Image = global::BankManagement.Properties.Resources.close;
            this.btnCloseLogin.Location = new System.Drawing.Point(99, 12);
            this.btnCloseLogin.Name = "btnCloseLogin";
            this.btnCloseLogin.Size = new System.Drawing.Size(22, 22);
            this.btnCloseLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCloseLogin.TabIndex = 2;
            this.btnCloseLogin.TabStop = false;
            this.btnCloseLogin.Click += new System.EventHandler(this.btnCloseLogin_Click);
            // 
            // btnMinimizeMain
            // 
            this.btnMinimizeMain.Image = global::BankManagement.Properties.Resources.minimize;
            this.btnMinimizeMain.Location = new System.Drawing.Point(22, 12);
            this.btnMinimizeMain.Name = "btnMinimizeMain";
            this.btnMinimizeMain.Size = new System.Drawing.Size(22, 22);
            this.btnMinimizeMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizeMain.TabIndex = 1;
            this.btnMinimizeMain.TabStop = false;
            this.btnMinimizeMain.Click += new System.EventHandler(this.btnMinimizeMain_Click);
            // 
            // groupBoxControll
            // 
            this.groupBoxControll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxControll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.groupBoxControll.Controls.Add(this.btnCloseLogin);
            this.groupBoxControll.Controls.Add(this.btnMaximizeManin);
            this.groupBoxControll.Controls.Add(this.btnMinimizeMain);
            this.groupBoxControll.ForeColor = System.Drawing.Color.Black;
            this.groupBoxControll.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.groupBoxControll.Location = new System.Drawing.Point(728, 0);
            this.groupBoxControll.Name = "groupBoxControll";
            this.groupBoxControll.Size = new System.Drawing.Size(127, 42);
            this.groupBoxControll.TabIndex = 1;
            this.groupBoxControll.TabStop = false;
            this.groupBoxControll.PaddingChanged += new System.EventHandler(this.groupBoxControll_PaddingChanged);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(855, 450);
            this.Controls.Add(this.panelTitleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.Text = "Main";
            this.panelTitleBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizeManin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCloseLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizeMain)).EndInit();
            this.groupBoxControll.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.PictureBox btnMinimizeMain;
        private System.Windows.Forms.PictureBox btnCloseLogin;
        private System.Windows.Forms.PictureBox btnMaximizeManin;
        private System.Windows.Forms.GroupBox groupBoxControll;
    }
}