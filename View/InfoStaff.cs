using BankManagement.Model;
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
        private Staff staff;
        private StaffRepository _staffRepository;
        private int staffId;
        public InfoStaff(int staffId)
        {
            InitializeComponent();
            this.staffId = staffId; //Nhận dữ liệu từ Main

            this.ShowInTaskbar = false; // Ẩn form khỏi thanh taskbar 
            this.Deactivate += new EventHandler(InfoStaff_Deactivate); // Đăng ký sự kiện Deactivate để đóng form khi mất focus

            this._staffRepository = new StaffRepository();
		}



        //Cập nhật dữ liệu form
		private void InfoStaff_Load(object sender, EventArgs e)
		{

			this.staff = _staffRepository.GetStaffById(this.staffId);
			if (this.staff != null)
			{
				lbStaffNameInfoStaffForm.Text = staff.GetName();
				lbUserNameInfoStaffForm.Text = staff.GetUsername();
				lbBranchInfoStaffForm.Text = "Chi nhánh: " + staff.GetWorkingBranch();
				lbJobPositionInfoStaffForm.Text = "Vị trí: " + staff.GetJobPosition();
			}
		}




		//Hàm xử lý sự kiện Deactivate
		private void InfoStaff_Deactivate(object sender, EventArgs e)
        {
            this.Close(); //Đóng form khi mất tiêu điểm
        }



        //Xử lí sự kiện logout
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
