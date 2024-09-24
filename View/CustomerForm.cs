using BankManagement.Model;
using BankManagement.ViewModel;
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
			//dataGridViewCustomerInforCustomerForm.Rows.Add("356254", "024204007331", "DINH NGOC THE", "0385689273", "07/01/2005", "Quy Son, Luc Ngan, Bac Giang", "chiu luon");
			//dataGridViewCustomerInforCustomerForm.Rows.Add("458652", "063521458965", "LUONG VAN SON", "0865236587", "01/01/2004", "Quy Son, Luc Ngan, Bac Giang");
			//dataGridViewCustomerInforCustomerForm.Rows.Add("505944", "003568998541", "TRUONG QUANG VINH", "0968574586", "23/11/2004", "Kim Son, Hong Giang, Thanh Hoa");
			//dataGridViewCustomerInforCustomerForm.Rows.Add("356254", "024204007331", "DINH NGOC THE", "0385689273", "07/01/2005", "Quy Son, Luc Ngan, Bac Giang");
			//dataGridViewCustomerInforCustomerForm.Rows.Add("458652", "063521458965", "LUONG VAN SON", "0865236587", "01/01/2004", "Quy Son, Luc Ngan, Bac Giang");
			//dataGridViewCustomerInforCustomerForm.Rows.Add("505944", "003568998541", "TRUONG QUANG VINH", "0968574586", "23/11/2004", "Kim Son, Hong Giang, Thanh Hoa");
			//dataGridViewCustomerInforCustomerForm.Rows.Add("356254", "024204007331", "DINH NGOC THE", "0385689273", "07/01/2005", "Quy Son, Luc Ngan, Bac Giang");
			//dataGridViewCustomerInforCustomerForm.Rows.Add("458652", "063521458965", "LUONG VAN SON", "0865236587", "01/01/2004", "Quy Son, Luc Ngan, Bac Giang");
			//dataGridViewCustomerInforCustomerForm.Rows.Add("505944", "003568998541", "TRUONG QUANG VINH", "0968574586", "23/11/2004", "Kim Son, Hong Giang, Thanh Hoa");
			//dataGridViewCustomerInforCustomerForm.Rows.Add("356254", "024204007331", "DINH NGOC THE", "0385689273", "07/01/2005", "Quy Son, Luc Ngan, Bac Giang");
			//dataGridViewCustomerInforCustomerForm.Rows.Add("458652", "063521458965", "LUONG VAN SON", "0865236587", "01/01/2004", "Quy Son, Luc Ngan, Bac Giang");
			//dataGridViewCustomerInforCustomerForm.Rows.Add("505944", "003568998541", "TRUONG QUANG VINH", "0968574586", "23/11/2004", "Kim Son, Hong Giang, Thanh Hoa");
			//dataGridViewCustomerInforCustomerForm.Rows.Add("356254", "024204007331", "DINH NGOC THE", "0385689273", "07/01/2005", "Quy Son, Luc Ngan, Bac Giang");
			//dataGridViewCustomerInforCustomerForm.Rows.Add("458652", "063521458965", "LUONG VAN SON", "0865236587", "01/01/2004", "Quy Son, Luc Ngan, Bac Giang");
			//dataGridViewCustomerInforCustomerForm.Rows.Add("505944", "003568998541", "TRUONG QUANG VINH", "0968574586", "23/11/2004", "Kim Son, Hong Giang, Thanh Hoa");
			//dataGridViewCustomerInforCustomerForm.Rows.Add("356254", "024204007331", "DINH NGOC THE", "0385689273", "07/01/2005", "Quy Son, Luc Ngan, Bac Giang");
			//dataGridViewCustomerInforCustomerForm.Rows.Add("458652", "063521458965", "LUONG VAN SON", "0865236587", "01/01/2004", "Quy Son, Luc Ngan, Bac Giang");
			//dataGridViewCustomerInforCustomerForm.Rows.Add("505944", "003568998541", "TRUONG QUANG VINH", "0968574586", "23/11/2004", "Kim Son, Hong Giang, Thanh Hoa");

			//Đăng ký sự kiện ScrollBar vertical
			dataGridViewCustomerInforCustomerForm.MouseWheel += dataGridViewCustomerInforCustomerForm_MouseWheel;
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
                //// Lấy hàng được chọn
                //DataGridViewRow selectedRow = dataGridViewCustomerInforCustomerForm.Rows[e.RowIndex];

                //// Lấy dữ liệu từ các cột trong hàng với kiểm tra null
                //int id = selectedRow.Cells["ID"].Value != DBNull.Value ? Convert.ToInt32(selectedRow.Cells["ID"].Value) : 0;
                //string cccd = selectedRow.Cells["CCCD"].Value?.ToString() ?? string.Empty;
                //string name = selectedRow.Cells["Customer Name"].Value?.ToString() ?? string.Empty;
                //string phone_number = selectedRow.Cells["Phone Number"].Value?.ToString() ?? string.Empty;
                //string dateOfBirth = selectedRow.Cells["Date of Birth"].Value?.ToString() ?? string.Empty;
                //string address = selectedRow.Cells["Address"].Value?.ToString() ?? string.Empty;
                //string nationality = selectedRow.Cells["Nationality"].Value?.ToString() ?? string.Empty;
                //string job = selectedRow.Cells["Job"].Value?.ToString() ?? string.Empty;
                //string email = selectedRow.Cells["Email"].Value?.ToString() ?? string.Empty;

                //// Hiển thị dữ liệu 
                //txtCustomerIDCustomerForm.Text = id.ToString();
                //txtCCCDCustomerForm.Text = cccd;
                //txtCustomerNameCustomerForm.Text = name;
                //txtPhoneNumberCustomerForm.Text = phone_number;
                //txtDateOfBirthCustomerForm.Text = dateOfBirth;
                //txtAddressCustomerForm.Text = address;
                //txtNationalityCustomerForm.Text = nationality;
                //txtJobCustomerForm.Text = job;
                //txtEmailCustomerForm.Text = email;
            }
        }

    }
}
