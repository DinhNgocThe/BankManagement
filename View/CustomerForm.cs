using BankManagement.Model;
using BankManagement.ViewModel;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace BankManagement
{
	public partial class CustomerForm : Form
	{
		CustomerViewModel viewModel;
		public CustomerForm()
		{
			InitializeComponent();
			viewModel = new CustomerViewModel();
			this.ShowInTaskbar = false;
		}

		private void CustomerForm_Load(object sender, EventArgs e)
		{
			cbGenderCustomerForm.Items.Add("Male");
			cbGenderCustomerForm.Items.Add("Female");
			imgCustomerCustomerForm.Image = null;

            //Đăng ký sự kiện ScrollBar vertical
            dataGridViewCustomerInforCustomerForm.MouseWheel += dataGridViewCustomerInforCustomerForm_MouseWheel;
		}

        private void cbGenderCustomerForm_Paint(object sender, PaintEventArgs e)
        {
            // Lấy kích thước của ComboBox
            Rectangle rect = new Rectangle(0, 0, cbGenderCustomerForm.Width, cbGenderCustomerForm.Height);

            // Tùy chỉnh vẽ viền
            e.Graphics.DrawRectangle(new Pen(Color.Red, 2), rect);
        }

        //Sự kiện sử dụng con lăn chuột để kéo dataGridView
        private void dataGridViewCustomerInforCustomerForm_MouseWheel(object sender, MouseEventArgs e)
		{
			if (e.Delta > 0)
			{
				if (dataGridViewCustomerInforCustomerForm.FirstDisplayedScrollingRowIndex > 0)
				{
					dataGridViewCustomerInforCustomerForm.FirstDisplayedScrollingRowIndex--;
				}
			}
			else if (e.Delta < 0)
			{
				if (dataGridViewCustomerInforCustomerForm.FirstDisplayedScrollingRowIndex < dataGridViewCustomerInforCustomerForm.RowCount - 1)
				{
					dataGridViewCustomerInforCustomerForm.FirstDisplayedScrollingRowIndex++;
				}
			}
		}

		private void btnAddCustomerForm_Click(object sender, EventArgs e)
		{
			int id = 0;
			string cccd = txtCCCDCustomerForm.Text;
			string name = txtCustomerNameCustomerForm.Text;
			string phone_number = txtPhoneNumberCustomerForm.Text;
			DateTime date_of_birth = DateTime.Parse(txtDateOfBirthCustomerForm.Text);
			date_of_birth.ToString("yyyy-MM-dd");
			string address = txtAddressCustomerForm.Text;
			string nationality = txtNationalityCustomerForm.Text;
			string job = txtJobCustomerForm.Text;
			string email = txtEmailCustomerForm.Text;
			string photo = "";

			CustomerInfor customerInfor = new CustomerInfor(id, name, cccd, phone_number, email, job, nationality, address, date_of_birth, photo);
			viewModel.addCustomer(customerInfor);
		}

		private void btnSearchCustomerForm_Click(object sender, EventArgs e)
		{
            DataTable dt = viewModel.SearchCustomer(txtSearchCustomerForm.Text);
			foreach (DataRow row in dt.Rows)
			{
				int id = Convert.ToInt32(row["id"]);
				string cccd = row["cccd"].ToString();
				string name = row["name"].ToString();
				string phone_number = row["phone_number"].ToString();
                // Parse and format the dateOfBirth to only display the date part
                DateTime dateOfBirth = DateTime.Parse(row["date_of_birth"].ToString());
                string formattedDateOfBirth = dateOfBirth.ToString("dd/MM/yyyy");
                string address = row["address"].ToString();
				string nationality = row["nationality"].ToString();
				string job = row["job"].ToString() ;
				string email = row["email"].ToString();

                dataGridViewCustomerInforCustomerForm.Rows.Add(id, cccd, name, phone_number, formattedDateOfBirth, address , nationality , job , email);
            }
        }

        private void dataGridViewCustomerInforCustomerForm_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem chỉ số hàng hợp lệ
            if (e.RowIndex >= 0)
            {
                // Lấy hàng được chọn
                DataGridViewRow selectedRow = dataGridViewCustomerInforCustomerForm.Rows[e.RowIndex];

                // Lấy dữ liệu từ các cột trong hàng với kiểm tra null
                int id = Convert.ToInt32(selectedRow.Cells["id"].Value);
				string cccd = selectedRow.Cells["cccd"].Value.ToString();
				string name = selectedRow.Cells["customerName"].Value.ToString();
				string phone_number = selectedRow.Cells["phoneNumber"].Value.ToString();
				string dateOfBirth = selectedRow.Cells["dateOfBirth"].Value.ToString();
				string address = selectedRow.Cells["address"].Value.ToString();
				string nationality = selectedRow.Cells["nationality"].Value.ToString();
				string job = selectedRow.Cells["job"].Value.ToString();
				string email = selectedRow.Cells["email"].Value.ToString();

                // Hiển thị dữ liệu 
                txtCCCDCustomerForm.Text = cccd;
                txtCustomerNameCustomerForm.Text = name;
                txtPhoneNumberCustomerForm.Text = phone_number;
                txtDateOfBirthCustomerForm.Text = dateOfBirth;
                txtAddressCustomerForm.Text = address;
                txtNationalityCustomerForm.Text = nationality;
                txtJobCustomerForm.Text = job;
                txtEmailCustomerForm.Text = email;
            }
        }
    }
}
