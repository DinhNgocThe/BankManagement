using BankManagement.Language;
using BankManagement.ViewModel;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankManagement.View
{
    public partial class AddStaffForm : Form
    {
        private string filePath;
        private int staffId;
        private AddStaffViewModel viewModel;
        public AddStaffForm(int staffId)
        {
            InitializeComponent();
            this.staffId = staffId;
            viewModel = new AddStaffViewModel();
            ShowInTaskbar = false;
        }

        private void AddStaffForm_Load(object sender, EventArgs e)
        {
            ChangeLanguage();
            cbRole.Items.Clear();
            cbRole.Items.Add("admin");
            cbRole.Items.Add("staff");
            reset();
        }
        void ChangeLanguage()
        {
            lbAddStaff.Text = LangHelper.Instance.GetString("Add Staff");
            txtSearch.PlaceholderText = LangHelper.Instance.GetString("Search by staff name");
            btnSearch.Text = LangHelper.Instance.GetString("Search");
            txtStaffName.PlaceholderText = LangHelper.Instance.GetString("Staff Name");
            lbRole.Text = LangHelper.Instance.GetString("Role");
            lbUsername.Text = LangHelper.Instance.GetString("Username");
            lbPassword.Text = LangHelper.Instance.GetString("Password");
            lbWorkingBranch.Text = LangHelper.Instance.GetString("Working Branch");
            txtWorkingBranch.PlaceholderText = LangHelper.Instance.GetString("District - City");
            lbJobPosition.Text = LangHelper.Instance.GetString("Job Position");
            txtJobPosition.PlaceholderText = LangHelper.Instance.GetString("Bank Teller");
            btnActive.Text = LangHelper.Instance.GetString("Active");
            btnUpdate.Text = LangHelper.Instance.GetString("Update");
            btnAdd.Text = LangHelper.Instance.GetString("Add");
            btnDisable.Text = LangHelper.Instance.GetString("Disable");
        }





        void reset()
        {
            LoadDataGridView();
            txtPassword.ReadOnly = false;
            btnAdd.Enabled = true;
            btnDisable.Enabled = false;
            btnUpdate.Enabled = false;
            btnActive.Visible = false;
            txtStaffName.ReadOnly = false;
            txtUsername.ReadOnly = false;
            imgStaff.Image = Image.FromFile("..\\..\\Image\\CustomerImage\\img_customer_default.png");
            txtStaffName.Text = "";
            cbRole.SelectedIndex = -1;
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtWorkingBranch.Text = "";
            txtJobPosition.Text = "";
            txtEmail.Text = "";
        }



        void LoadDataGridView()
        {
            try
            {
                viewModel.LoadAllStaff();
                dataGridViewStaffAccount.Rows.Clear();
                foreach (DataRow row in viewModel.DataTableStaff.Rows)
                {
                    int id = Convert.ToInt32(row["ID"]);
                    string username = row["USERNAME"].ToString();
                    string name = row["NAME"].ToString();
                    string workingBranch = row["WORKING_BRANCH"].ToString();
                    string jobPosition = row["JOB_POSITION"].ToString();
                    string staffPhoto = row["STAFF_PHOTO"].ToString();
                    string email = row["EMAIL"].ToString();
                    string status = row["STATUS"].ToString();
                    string role = row["ROLE"].ToString();


                    dataGridViewStaffAccount.Rows.Add(id, name, role, username, workingBranch, jobPosition, email, staffPhoto, status);
                }
            }
            catch (Exception ex)
            {
                CustomMessageBox.ShowBox("Error when load data grid view: " + ex.Message, "Error");
            }
        }

        

        private void dataGridViewStaffAccount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem chỉ số hàng hợp lệ
            if (e.RowIndex >= 0)
            {
                btnAdd.Enabled = false;
                btnDisable.Enabled = true;
                btnUpdate.Enabled = true;
                // Lấy hàng được chọn
                DataGridViewRow selectedRow = dataGridViewStaffAccount.Rows[e.RowIndex];

                if (selectedRow.Cells["id"].Value != null)
                {
                    // Lấy dữ liệu từ các cột trong hàng với kiểm tra null
                    int id = Convert.ToInt32(selectedRow.Cells["id"].Value);
                    viewModel.Id = id;
                    string name = selectedRow.Cells["staffName"].Value.ToString();
                    string role = selectedRow.Cells["role"].Value.ToString();
                    string username = selectedRow.Cells["username"].Value.ToString();
                    string workingBranch = selectedRow.Cells["workingBranch"].Value.ToString();
                    string jobPosition = selectedRow.Cells["jobPosition"].Value.ToString();
                    string email = selectedRow.Cells["email"].Value.ToString();
                    string status = selectedRow.Cells["status"].Value.ToString();
                    string photo = selectedRow.Cells["staffPhoto"].Value.ToString();
                    filePath = photo;



                    // Hiển thị dữ liệu.
                    txtStaffName.Text = name;
                    txtStaffName.ReadOnly = true;
                    cbRole.Text = role;
                    txtUsername.Text = username;
                    txtUsername.ReadOnly = true;
                    txtPassword.Text = "";
                    txtPassword.ReadOnly = true;
                    txtWorkingBranch.Text = workingBranch;
                    txtJobPosition.Text = jobPosition;
                    txtEmail.Text = email;
                    checkStatus(status);

                    try
                    {
                        if (photo != "")
                        {
                            imgStaff.Image = Image.FromFile(photo);
                        }
                    }
                    catch (Exception ex)
                    {
                        // Nếu có lỗi xảy ra, sử dụng hình ảnh mặc định
                        imgStaff.Image = Image.FromFile("..\\..\\Image\\CustomerImage\\img_customer_default.png");

                        // Bạn có thể log hoặc xử lý lỗi nếu cần thiết
                        Console.WriteLine(ex.Message);
                    }
                    
                }
            }
        }
        private void checkStatus(string status)
        {
            lbStatus.Text = status;
            if (status == "active")
            {
                imgStatus.Image = Image.FromFile("..\\..\\Resources\\checked.png");
                lbStatus.ForeColor = Color.FromArgb(78, 167, 46);
                btnActive.Visible = false; //show button active
                btnUpdate.Enabled = true;
                btnDisable.Enabled = true;
            }
            else
            {
                imgStatus.Image = Image.FromFile("..\\..\\Resources\\x-button.png");
                
                lbStatus.ForeColor = Color.FromArgb(203, 57, 53);
                btnActive.Visible = true; // hide button active
                btnUpdate.Enabled = false;
                btnDisable.Enabled = false;
            }
        }




        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (imgStaff.Image == Image.FromFile("..\\..\\Image\\CustomerImage\\img_customer_default.png") || txtStaffName.Text == "" || cbRole.SelectedIndex == -1 || txtUsername.Text == "" || txtPassword.Text == "" || txtWorkingBranch.Text == "" || txtJobPosition.Text == "" || txtEmail.Text == "")
            {
                CustomMessageBox.ShowBox(LangHelper.Instance.GetString("Please fill in all information!"), "Error");
                return;
            }
            var emailPattern = @"[a-z0-9._%+\-]+@[a-z0-9.\-]+\.[a-z]{2,}$";
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtEmail.Text, emailPattern))
            {
                CustomMessageBox.ShowBox(LangHelper.Instance.GetString("Invalid email address!"), "Error");
                return;
            }
            if (txtUsername.Text.Length < 9 || txtPassword.Text.Length < 9)
            {
                CustomMessageBox.ShowBox(LangHelper.Instance.GetString("Username and password must be longer than 8 characters!"), "Error");
                return;
            }
            UpdateViewModelFromForm();
            try
            {
                viewModel.AddStaff();
                if (filePath != "") MoveImageToFolder(filePath, "\\Image\\StaffImage");
                reset();
            }
            catch (Exception ex)
            {
                CustomMessageBox.ShowBox("Error when add staff: " + ex.Message, "Error");
            }
        }





        void UpdateViewModelFromForm()
        {
            viewModel.Username = txtUsername.Text;
            viewModel.Password = txtPassword.Text;
            viewModel.StaffName = txtStaffName.Text;
            viewModel.WorkingBranch = txtWorkingBranch.Text;
            viewModel.JobPosition = txtJobPosition.Text;
            viewModel.Email = txtEmail.Text;
            viewModel.Role = cbRole.Text;
            if (filePath != "")
            {
                viewModel.StaffPhoto = $"..\\\\..\\\\Image\\\\StaffImage\\\\{Path.GetFileName(filePath)}";
            }
            else
            {
                viewModel.StaffPhoto = $"..\\\\..\\\\Image\\\\StaffImage\\\\img_customer_default.png";
            }
        }





        private void cbRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Kiểm tra nếu không có mục nào được chọn (SelectedIndex == -1)
            if (cbRole.SelectedIndex == -1)
            {
                lbRole.Visible = true;
            }
            else
            {
                lbRole.Visible = false;
            }
        }

        private void btnResetCustomerForm_Click(object sender, EventArgs e)
        {
            reset();
        }





        private void imgStaff_Click(object sender, EventArgs e)
        {
            // Tạo đối tượng OpenFileDialog để chọn ảnh
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
            openFileDialog.Title = "Select a Picture";

            // Kiểm tra xem người dùng đã chọn file hay chưa
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Lấy đường dẫn file
                filePath = openFileDialog.FileName;

                // Sử dụng FileStream để load ảnh và tránh bị khóa file
                using (var stream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                {
                    // Hiển thị hình ảnh trên PictureBox (imgCustomerCustomerForm)
                    imgStaff.Image = Image.FromStream(stream);
                }
            }
        }





        private void MoveImageToFolder(string filePath, string folderName)
        {
            if (filePath == null) return;
            try
            {
                // Đường dẫn tới thư mục CustomerImage trong dự án
                string projectDirectory = Directory.GetParent(System.Windows.Forms.Application.StartupPath).Parent.Parent.FullName;
                string destinationFolder = Path.Combine(projectDirectory, $@"BankManagement{folderName}");


                // Hiển thị đường dẫn đích để kiểm tra
                //MessageBox.Show("Đường dẫn lưu ảnh: " + destinationFolder);

                // Kiểm tra và tạo thư mục nếu chưa tồn tại
                if (!Directory.Exists(destinationFolder))
                {
                    Directory.CreateDirectory(destinationFolder);
                }

                // Copy ảnh vào thư mục CustomerImage


                // Tạo đường dẫn đầy đủ cho file ảnh mới
                string destinationPath = Path.Combine(destinationFolder, Path.GetFileName(filePath));

                //// Kiểm tra nếu ảnh đã tồn tại, thì xóa ảnh cũ trước khi sao chép
                if (File.Exists(destinationPath))
                {
                    //File.Delete(destinationPath);
                    return;
                }

                // Sao chép ảnh vào thư mục đích
                File.Copy(filePath, destinationPath);
                //MessageBox.Show("Ảnh đã được lưu vào thư mục CustomerImage.");
            }
            catch (Exception ex)
            {
                CustomMessageBox.ShowBox("Error: " + ex.Message, "Error");
            }
        }

        private void btnDisable_Click(object sender, EventArgs e)
        {
            try
            {
                viewModel.DisableAccount();
                CustomMessageBox.ShowBox(LangHelper.Instance.GetString("Disabled successfully!"), "Success");
                reset();
            }
            catch (Exception ex)
            {
                CustomMessageBox.ShowBox("Error when disable account: " + ex.Message, "Error");
            }
        }

        private void btnActive_Click(object sender, EventArgs e)
        {
            try
            {
                viewModel.EnableAccount();
                CustomMessageBox.ShowBox(LangHelper.Instance.GetString("Enabled successfully!"), "Success");
                reset();
            }
            catch (Exception ex)
            {
                CustomMessageBox.ShowBox("Error when enable account: " + ex.Message, "Error");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (imgStaff.Image == Image.FromFile("..\\..\\Image\\CustomerImage\\img_customer_default.png") || txtStaffName.Text == "" || cbRole.SelectedIndex == -1 || txtUsername.Text == "" || txtWorkingBranch.Text == "" || txtJobPosition.Text == "" || txtEmail.Text == "")
            {
                CustomMessageBox.ShowBox(LangHelper.Instance.GetString("Please fill in all information!"), "Error");
                return;
            }
            var emailPattern = @"[a-z0-9._%+\-]+@[a-z0-9.\-]+\.[a-z]{2,}$";
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtEmail.Text, emailPattern))
            {
                CustomMessageBox.ShowBox(LangHelper.Instance.GetString("Invalid email address!"), "Error");
                return;
            }
            UpdateViewModelFromForm();
            try
            {
                viewModel.UpdateStaff();
                CustomMessageBox.ShowBox(LangHelper.Instance.GetString("Updated successfully!"), "Success");
                reset();
            }
            catch (Exception ex)
            {
                CustomMessageBox.ShowBox("Error when update staff: " + ex.Message, "Error");
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
