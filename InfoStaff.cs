using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankManagement
{
    public partial class InfoStaff : Form
    {
        public InfoStaff()
        {
            InitializeComponent();
            this.ShowInTaskbar = false; // Ẩn form khỏi thanh taskbar 
            this.Deactivate += new EventHandler(InfoStaff_Deactivate); // Đăng ký sự kiện Deactivate để đóng form khi mất focus
		}
        // Hàm xử lý sự kiện Deactivate
        private void InfoStaff_Deactivate(object sender, EventArgs e)
        {
            this.Close(); //Đóng form khi mất tiêu điểm
        }

        private void btnLogOutInfoStaffForm_Click(object sender, EventArgs e)
        {
            // Đóng tất cả các form đang mở
            foreach (Form form in Application.OpenForms.Cast<Form>().ToList())
            {
                form.Close(); // Đóng từng form
            }

            // Khởi động lại ứng dụng
            RestartApplication();
        }

        private void RestartApplication()
        {
            // Khởi động lại ứng dụng bằng cách sử dụng lệnh debug của Visual Studio
            System.Diagnostics.Process.Start("cmd.exe", "/C start \"\" \"" + System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName + "\"");

            // Thoát ứng dụng hiện tại
            Application.Exit();
        }
    }
}
