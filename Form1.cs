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

namespace BankManagement
{
    public partial class LoginForm : Form
    { 
        public LoginForm()
        {
            InitializeComponent();
            //this.BackColor = ColorTranslator.FromHtml("#34AB53");
        }
        private void LoginForm_Load(object sender, EventArgs e)
        { 

        }

        private void btnCloseLogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimizeLogin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void txtUTCBank_Click(object sender, EventArgs e)
        {

        }

        //Hỗ trợ kéo thả khi giữ click vào thanh title 
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }

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
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            using (SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-75GGNPLE\MAY1;Initial Catalog=UTCBank;Integrated Security=True;Encrypt=False"))
            {
                conn.Open();

                // Sử dụng câu lệnh có tham số để tránh SQL Injection
                string query = "SELECT username, password FROM admin_account WHERE username = @username AND password = @password";
                using (SqlCommand sqlCommand = new SqlCommand(query, conn))
                {
                    // Thêm các tham số để ràng buộc giá trị đầu vào
                    sqlCommand.Parameters.AddWithValue("@username", username);
                    sqlCommand.Parameters.AddWithValue("@password", password);

                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                    DataTable dataTable = new DataTable();
                    sqlDataAdapter.Fill(dataTable);

                    if (dataTable.Rows.Count > 0)
                    {
                        lblWarningLogin.Text = "";
                        MessageBox.Show("Login successful!");
                    }
                    else
                    {
                        lblWarningLogin.Text = "Wrong username or password!";
                    }
                }
            }
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
