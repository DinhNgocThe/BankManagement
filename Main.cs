using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankManagement
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            this.Load += Main_Load;
        }

        //Hỗ trợ kéo thả khi giữ click vào thanh title 
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void panelTitleBarMain_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }


        //Các biến trạng thái
        private bool isMaximized = false;
        private Rectangle normalBounds;

        private void btnCloseMain_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizeMain_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximizeMain_Click(object sender, EventArgs e)
        {
            if (isMaximized)
            {
                // Chuyển về kích thước bình thường
                this.Bounds = normalBounds;
                this.FormBorderStyle = FormBorderStyle.None; // Đảm bảo vẫn giữ không có viền
                this.WindowState = FormWindowState.Normal;
                isMaximized = false;
            }
            else
            {
                // Phóng to cửa sổ
                normalBounds = this.Bounds; // Lưu lại kích thước bình thường
                this.Bounds = Screen.PrimaryScreen.WorkingArea; // Phóng to ra toàn màn hình
                this.FormBorderStyle = FormBorderStyle.None; // Đảm bảo vẫn giữ không có viền
                this.WindowState = FormWindowState.Maximized;
                isMaximized = true;
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            // Lưu trữ kích thước và vị trí ban đầu của form
            normalBounds = this.Bounds;
        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ok");
        }
    }
}
