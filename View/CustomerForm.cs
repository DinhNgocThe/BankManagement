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
	public partial class CustomerForm : Form
	{
		public CustomerForm()
		{
			InitializeComponent();
			this.ShowInTaskbar = false;
		}

		private void CustomerForm_Load(object sender, EventArgs e)
		{
			dataGridViewCustomerInforCustomerForm.Rows.Add("356254", "024204007331", "DINH NGOC THE", "0385689273", "07/01/2005", "Quy Son, Luc Ngan, Bac Giang", "chiu luon");
			dataGridViewCustomerInforCustomerForm.Rows.Add("458652", "063521458965", "LUONG VAN SON", "0865236587", "01/01/2004", "Quy Son, Luc Ngan, Bac Giang");
			dataGridViewCustomerInforCustomerForm.Rows.Add("505944", "003568998541", "TRUONG QUANG VINH", "0968574586", "23/11/2004", "Kim Son, Hong Giang, Thanh Hoa");
			dataGridViewCustomerInforCustomerForm.Rows.Add("356254", "024204007331", "DINH NGOC THE", "0385689273", "07/01/2005", "Quy Son, Luc Ngan, Bac Giang");
			dataGridViewCustomerInforCustomerForm.Rows.Add("458652", "063521458965", "LUONG VAN SON", "0865236587", "01/01/2004", "Quy Son, Luc Ngan, Bac Giang");
			dataGridViewCustomerInforCustomerForm.Rows.Add("505944", "003568998541", "TRUONG QUANG VINH", "0968574586", "23/11/2004", "Kim Son, Hong Giang, Thanh Hoa");
			dataGridViewCustomerInforCustomerForm.Rows.Add("356254", "024204007331", "DINH NGOC THE", "0385689273", "07/01/2005", "Quy Son, Luc Ngan, Bac Giang");
			dataGridViewCustomerInforCustomerForm.Rows.Add("458652", "063521458965", "LUONG VAN SON", "0865236587", "01/01/2004", "Quy Son, Luc Ngan, Bac Giang");
			dataGridViewCustomerInforCustomerForm.Rows.Add("505944", "003568998541", "TRUONG QUANG VINH", "0968574586", "23/11/2004", "Kim Son, Hong Giang, Thanh Hoa");
			dataGridViewCustomerInforCustomerForm.Rows.Add("356254", "024204007331", "DINH NGOC THE", "0385689273", "07/01/2005", "Quy Son, Luc Ngan, Bac Giang");
			dataGridViewCustomerInforCustomerForm.Rows.Add("458652", "063521458965", "LUONG VAN SON", "0865236587", "01/01/2004", "Quy Son, Luc Ngan, Bac Giang");
			dataGridViewCustomerInforCustomerForm.Rows.Add("505944", "003568998541", "TRUONG QUANG VINH", "0968574586", "23/11/2004", "Kim Son, Hong Giang, Thanh Hoa");
			dataGridViewCustomerInforCustomerForm.Rows.Add("356254", "024204007331", "DINH NGOC THE", "0385689273", "07/01/2005", "Quy Son, Luc Ngan, Bac Giang");
			dataGridViewCustomerInforCustomerForm.Rows.Add("458652", "063521458965", "LUONG VAN SON", "0865236587", "01/01/2004", "Quy Son, Luc Ngan, Bac Giang");
			dataGridViewCustomerInforCustomerForm.Rows.Add("505944", "003568998541", "TRUONG QUANG VINH", "0968574586", "23/11/2004", "Kim Son, Hong Giang, Thanh Hoa");
			dataGridViewCustomerInforCustomerForm.Rows.Add("356254", "024204007331", "DINH NGOC THE", "0385689273", "07/01/2005", "Quy Son, Luc Ngan, Bac Giang");
			dataGridViewCustomerInforCustomerForm.Rows.Add("458652", "063521458965", "LUONG VAN SON", "0865236587", "01/01/2004", "Quy Son, Luc Ngan, Bac Giang");
			dataGridViewCustomerInforCustomerForm.Rows.Add("505944", "003568998541", "TRUONG QUANG VINH", "0968574586", "23/11/2004", "Kim Son, Hong Giang, Thanh Hoa");

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
	}
}
