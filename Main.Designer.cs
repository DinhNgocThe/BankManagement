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
            this.imgLogoMain = new System.Windows.Forms.PictureBox();
            this.lbBMS = new System.Windows.Forms.Label();
            this.guna2ResizeForm1 = new Guna.UI2.WinForms.Guna2ResizeForm(this.components);
            this.panelTitleBarMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogoMain)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTitleBarMain
            // 
            this.panelTitleBarMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
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
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.panelTitleBarMain);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(1200, 700);
            this.Name = "Main";
            this.Text = "Main";
            this.panelTitleBarMain.ResumeLayout(false);
            this.panelTitleBarMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogoMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitleBarMain;
        private System.Windows.Forms.PictureBox imgLogoMain;
        private System.Windows.Forms.Label lbBMS;
        private Guna.UI2.WinForms.Guna2ResizeForm guna2ResizeForm1;
    }
}