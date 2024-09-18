using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
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

		//Begin - Hỗ trợ kéo thả khi giữ click vào thanh title 
		public const int WM_NCLBUTTONDOWN = 0xA1;
		//0xA1 là mã Hex đại diện cho sự kiện khi Windows khi nhấn nút trái chuột vào vùng không chứa title bar

		public const int HT_CAPTION = 0x2;
		//Tương tự là khi người dùng nhấn vào thanh title bar

		[DllImportAttribute("user32.dll")]
		//Gọi hàm API từ thư viện user32.dll
		public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
		//hWnd là một handle ("giống như ID định danh cho một loại tài nguyên, ở đây là form hiện tại)
		//Msg gửi thông điệp WM_NCLBUTTONDOWN (0xA1) là mã để báo hiệu click chuột trái vào title bar
		//wParam, lParam  Là các tham số bổ sung, thường mang thông tin về sự kiện chuột hoặc bàn phím, hoặc các chi tiết khác phụ thuộc vào thông điệp bạn đang gửi

		[DllImportAttribute("user32.dll")]
		//Mỗi lần import chỉ hoạt động cho một hàm cụ thể nên phải import nhiều lần
		public static extern bool ReleaseCapture();
		//Giải phóng việc bắt giữ chuột từ control hiện tại
		private void panelTitleBarMain_MouseDown(object sender, MouseEventArgs e)
        {
			ReleaseCapture(); //Nếu không có hàm này thì mọi sự kiện chuột ("kéo thả") vẫn sẽ được gửi đến title bar
			SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0); //Gửi thông điệp đến hđh để bắt đầu di chuyển form
		//End - Hỗ trợ kéo thả khi giữ click vào thanh title

			//Su kien double click vao thanh title
			if (e.Clicks == 2)
            {
                if (isMaximized) //Khi form ở trạng thái phóng to
                {
                    this.Bounds = normalBounds; // Chuyển về kích thước bình thường
                    isMaximized = false; //Cập nhật trạng thái không còn là phóng to
                }
                else
                {
                    // Phóng to cửa sổ
                    normalBounds = this.Bounds; // Lưu lại kích thước bình thường
                    this.Bounds = Screen.PrimaryScreen.WorkingArea; // Phóng to ra toàn màn hình
                    isMaximized = true; //Cập nhật trạng thái không còn là thu nhỏ
                }
            }
        }

		private void btnClose_Click(object sender, EventArgs e)
		{
			Application.Exit(); //Đóng ứng dụng
		}

		private void btnMinimize_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized; //Thu nhỏ ứng dụng
		}


		//Các biến trạng thái
		private bool isMaximized = false;
		private Rectangle normalBounds; //Lưu trữ kích thước form
		private void btnMaximize_Click(object sender, EventArgs e)
		{
			if (isMaximized) //Khi form ở trạng thái phóng to
			{
				this.Bounds = normalBounds; // Chuyển về kích thước bình thường
				isMaximized = false; //Cập nhật trạng thái không còn là phóng to
			}
			else
			{
				// Phóng to cửa sổ
				normalBounds = this.Bounds; // Lưu lại kích thước bình thường
				this.Bounds = Screen.PrimaryScreen.WorkingArea; // Phóng to ra toàn màn hình
				isMaximized = true; //Cập nhật trạng thái không còn là thu nhỏ
			}
		}

		private void Main_Load(object sender, EventArgs e)
        {
            // Lưu trữ kích thước và vị trí ban đầu của form
            normalBounds = this.Bounds;

            //Đổi màu hover
            btnCloseMain.HoverState.FillColor = Color.FromArgb(255, 90, 90);
            btnStaffAvatarMain.HoverState.FillColor = Color.FromArgb(200, 200, 200);
            btnNotifyMain.HoverState.FillColor = Color.FromArgb(100, 100, 100);
        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ok");
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ok Setting");
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ok customer");
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ok Account");
        }

        private void btnTransaction_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ok Transaction");
        }

        private void btnLoan_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ok Loan");
        }

		private void pictureBox2_Click(object sender, EventArgs e)
		{

		}
		private void btnStaffAvatarMain_Click(object sender, EventArgs e)
        {
			InfoStaff infoStaff = new InfoStaff();
			// Lấy tọa độ và điều chỉnh vị trí
			var buttonScreenPos = btnStaffAvatarMain.PointToScreen(new System.Drawing.Point(-27, btnStaffAvatarMain.Height + 5));

            // Đặt vị trí của InfoStaff ngay dưới nút btnStaffAvatar
            infoStaff.StartPosition = FormStartPosition.Manual;
            infoStaff.Location = buttonScreenPos;

            // Hiển thị InfoStaff
            infoStaff.Show(this);
        }
    }
}
