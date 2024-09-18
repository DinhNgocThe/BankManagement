using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;


namespace BankManagement
{
    public partial class LoginForm : Form
    {

		private string connectionString = $@"Data Source={getServerName.serverName};Initial Catalog=UTCBank;Integrated Security=True;Encrypt=False";
		//Chuỗi kết nối csdl
		public LoginForm()
        {
            InitializeComponent();
            //this.BackColor = ColorTranslator.FromHtml("#34AB53");
            btnCloseLogin.HoverState.FillColor = Color.FromArgb(255, 90, 90); //Thuộc tính hover btnClose "đỏ"
        }
        private void LoginForm_Load(object sender, EventArgs e)
        { 

        }

		private void btnLoginClose_Click(object sender, EventArgs e)
		{
            Application.Exit(); //Đóng ứng dụng
		}

		private void btnLoginMinimize_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;  //Thu nhỏ ứng dụng
		}

        private void txtUTCBank_Click(object sender, EventArgs e)
        {

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
        private void PanelTitleBarLogin_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture(); //Nếu không có hàm này thì mọi sự kiện chuột ("kéo thả") vẫn sẽ được gửi đến title bar
            SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0); //Gửi thông điệp đến hđh để bắt đầu di chuyển form
        }
		//End - Hỗ trợ kéo thả khi giữ click vào thanh title

		private void panelLogin_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

		private void btnLogin_Click(object sender, EventArgs e)
        {
			string username = txtUsername.Text; //Lấy username
			string password = txtPassword.Text; //Lấy password
			//string hashedPassword = ComputeSha256Hash(password); //Mã hoá mật khẩu trước khi kiểm tra

			try
			{
				using (SqlConnection conn = new SqlConnection(connectionString)) //sử dụng using để đảm bảo ngắt kết nối khi khối lệnh kết thúc
				{
					conn.Open();

					string query = "SELECT 1 FROM admin_account WHERE username = @username AND password = @password";
					// Sử dụng câu lệnh có tham số để tránh SQL Injection

					using (SqlCommand sqlCommand = new SqlCommand(query, conn))
					{
						// Thêm các tham số để ràng buộc giá trị đầu vào
						sqlCommand.Parameters.AddWithValue("@username", username); //Thay thế username vào tham số @username ở câu truy vấn
						sqlCommand.Parameters.AddWithValue("@password", password); //Tương tự như username

						var result = sqlCommand.ExecuteScalar(); //Trả về giá trị của câu truy vấn
						if (result != null) //Trường hợp có kết quả
						{
							lblWarningLogin.Text = "";
							Main main = new Main();
							main.Show();
							this.Hide();
						}
						else
						{
							lblWarningLogin.Text = "Wrong username or password!";
						}
					}
				}
			}
			catch (Exception ex)
			{
				// Xử lý lỗi và hiển thị thông báo
				lblWarningLogin.Text = "Lỗi: " + ex.Message;
			}
		}

		// Hàm mã hóa mật khẩu bằng SHA-256
		private static string ComputeSha256Hash(string rawData)
		{
			using (SHA256 sha256Hash = SHA256.Create())
			{
				byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));
				StringBuilder builder = new StringBuilder();
				for (int i = 0; i < bytes.Length; i++)
				{
					builder.Append(bytes[i].ToString("x2"));
				}
				return builder.ToString();
			}
		}

		private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void roundControl1_Load(object sender, EventArgs e)
        {

        }

        private void panelTitleBar_Paint(object sender, PaintEventArgs e)
        {

        }
	}
}
