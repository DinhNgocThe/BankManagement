using BankManagement.Language;
using BankManagement.View;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Configuration;
using System.Windows.Forms;

namespace BankManagement.Model
{
	internal class StaffRepository
	{
		//Chuỗi kết nối database
		private string connectionString = getConnectionString.connectionString;

		public StaffRepository()
		{
        }


        // Phương thức lấy thông tin Staff từ bảng staff_account bằng ID
        public Staff GetStaffById(int staffId)
        {
            Staff staff = null;

            // Câu truy vấn Oracle
            string query = @"
        SELECT id, name, username, password, working_branch, job_position, staff_photo, email, status, role
        FROM staff_account
        WHERE id = :id AND ROWNUM = 1"; // Giới hạn chỉ lấy một dòng đầu tiên

            try
            {
                using (OracleConnection conn = new OracleConnection(connectionString)) // Đảm bảo ngắt kết nối khi kết thúc khối lệnh
                {
                    conn.Open();

                    using (OracleCommand cmd = new OracleCommand(query, conn)) // Truy vấn
                    {
                        // Thêm tham số id vào truy vấn
                        cmd.Parameters.Add(new OracleParameter("id", OracleDbType.Int32)).Value = staffId;

                        using (OracleDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Lấy các cột từ kết quả truy vấn và khởi tạo đối tượng Staff
                                int id = reader.GetInt32(0);
                                string name = reader.GetString(1);
                                string username = reader.GetString(2);
                                string password = reader.GetString(3);
                                string workingBranch = reader.GetString(4);
                                string jobPosition = reader.GetString(5);
                                string staffPhoto = reader.IsDBNull(6) ? null : reader.GetString(6); // Xử lý giá trị null
                                string email = reader.IsDBNull(7) ? null : reader.GetString(7);      // Xử lý giá trị null
                                string status = reader.GetString(8);
                                string role = reader.GetString(9);

                                // Tạo đối tượng Staff từ dữ liệu truy vấn
                                staff = new Staff(id, name, username, password, workingBranch, jobPosition, staffPhoto, email, status, role);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Ném lại ngoại lệ để form cha có thể xử lý
                throw new Exception("Error: " + ex.Message, ex);
            }

            return staff; // Trả về đối tượng Staff hoặc null nếu không tìm thấy
        }



        //Phương thức lấy thông tin staff bằng username và password
        public Staff GetStaffByUsernamePassword(string username, string password)
        {
            Staff staff = null;

            // Câu truy vấn Oracle
            string query = @"
            SELECT id, name, username, password, working_branch, job_position, staff_photo, email, status
            FROM staff_account
            WHERE username = :username AND password = :password
            AND ROWNUM = 1"; // Giới hạn chỉ lấy một dòng đầu tiên

            try
            {
                using (OracleConnection conn = new OracleConnection(connectionString)) // Đảm bảo ngắt kết nối khi kết thúc khối lệnh
                {
                    conn.Open();

                    using (OracleCommand cmd = new OracleCommand(query, conn)) // Truy vấn
                    {
                        // Thêm tham số vào truy vấn
                        cmd.Parameters.Add(new OracleParameter("username", OracleDbType.Varchar2)).Value = username;
                        cmd.Parameters.Add(new OracleParameter("password", OracleDbType.Varchar2)).Value = password;

                        using (OracleDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Lấy các cột từ kết quả truy vấn và khởi tạo đối tượng Staff
                                int id = reader.GetInt32(0);
                                string name = reader.GetString(1);
                                string staffUsername = reader.GetString(2);
                                string staffPassword = reader.GetString(3);
                                string workingBranch = reader.GetString(4);
                                string jobPosition = reader.GetString(5);
                                string staffPhoto = reader.IsDBNull(6) ? null : reader.GetString(6); // Xử lý giá trị null
                                string email = reader.IsDBNull(7) ? null : reader.GetString(7);      // Xử lý giá trị null
                                string status = reader.GetString(8);

                                // Tạo đối tượng Staff từ dữ liệu truy vấn
                                staff = new Staff(id, name, staffUsername, staffPassword, workingBranch, jobPosition, staffPhoto, email, status);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Ném lại ngoại lệ để form cha có thể xử lý
                throw new Exception("Error: " + ex.Message, ex);
            }

            return staff; // Trả về đối tượng Staff hoặc null nếu không tìm thấy
        }



        //Phương thức vô hiệu hoá tài khoản
        public void DisableAccount(int staffId)
        {
            // Câu truy vấn Oracle
            string query = "UPDATE staff_account SET status = 'disabled' WHERE id = :id";

            try
            {
                using (OracleConnection conn = new OracleConnection(connectionString)) // Đảm bảo ngắt kết nối sau khi thực thi
                {
                    conn.Open();

                    using (OracleCommand cmd = new OracleCommand(query, conn)) // Thực thi truy vấn
                    {
                        // Thêm tham số vào truy vấn
                        cmd.Parameters.Add(new OracleParameter("id", OracleDbType.Int32)).Value = staffId;
                        // Thực thi truy vấn
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                // Ném lại ngoại lệ để form cha có thể xử lý
                throw new Exception("Error: " + ex.Message, ex);
            }
        }





        //Phương thức active tài khoản
        public void EnableAccount(int staffId)
        {
            // Câu truy vấn Oracle
            string query = "UPDATE staff_account SET status = 'active' WHERE id = :id";

            try
            {
                using (OracleConnection conn = new OracleConnection(connectionString)) // Đảm bảo ngắt kết nối sau khi thực thi
                {
                    conn.Open();

                    using (OracleCommand cmd = new OracleCommand(query, conn)) // Thực thi truy vấn
                    {
                        // Thêm tham số vào truy vấn
                        cmd.Parameters.Add(new OracleParameter("id", OracleDbType.Int32)).Value = staffId;
                        // Thực thi truy vấn
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                // Ném lại ngoại lệ để form cha có thể xử lý
                throw new Exception("Error: " + ex.Message, ex);
            }
        }





        //Phương thức đổi mật khẩu
        public void ChangePassword(string password, int staffId)
        {
            // Câu truy vấn Oracle
            string query = "UPDATE staff_account SET password = :password WHERE id = :id";

            try
            {
                using (OracleConnection conn = new OracleConnection(connectionString)) // Đảm bảo ngắt kết nối sau khi thực thi
                {
                    conn.Open();

                    using (OracleCommand cmd = new OracleCommand(query, conn)) // Thực thi truy vấn
                    {
                        // Thêm tham số vào truy vấn
                        cmd.Parameters.Add(new OracleParameter("password", OracleDbType.Varchar2)).Value = password;
                        cmd.Parameters.Add(new OracleParameter("id", OracleDbType.Int32)).Value = staffId;
                        // Thực thi truy vấn
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                // Ném lại ngoại lệ để form cha có thể xử lý
                throw new Exception("Error: " + ex.Message, ex);
            }
        }





        //Thêm nhân viên
        public void AddStaff(Staff staff)
        {
            string query = "INSERT INTO STAFF_ACCOUNT (USERNAME, PASSWORD, NAME, WORKING_BRANCH, JOB_POSITION, STAFF_PHOTO, EMAIL, ROLE) " +
                           "VALUES (:Username, :Password, :Name, :WorkingBranch, :JobPosition, :StaffPhoto, :Email, :Role)";
            try
            {
                using (OracleConnection conn = new OracleConnection(connectionString))
                {
                    conn.Open();

                    using (OracleCommand cmd = new OracleCommand(query, conn))
                    {
                        cmd.Parameters.Add(new OracleParameter(":Username", OracleDbType.Varchar2) { Value = staff.GetUsername() });
                        cmd.Parameters.Add(new OracleParameter(":Password", OracleDbType.Varchar2) { Value = staff.Password });
                        cmd.Parameters.Add(new OracleParameter(":Name", OracleDbType.Varchar2) { Value = staff.GetName() });
                        cmd.Parameters.Add(new OracleParameter(":WorkingBranch", OracleDbType.Varchar2) { Value = staff.GetWorkingBranch() });
                        cmd.Parameters.Add(new OracleParameter(":JobPosition", OracleDbType.Varchar2) { Value = staff.GetJobPosition() });

                        if (!string.IsNullOrEmpty(staff.GetPhotoPath()))
                        {
                            cmd.Parameters.Add(new OracleParameter(":StaffPhoto", OracleDbType.Varchar2) { Value = staff.GetPhotoPath() });
                        }
                        else
                        {
                            cmd.Parameters.Add(new OracleParameter(":StaffPhoto", OracleDbType.Varchar2) { Value = DBNull.Value });
                        }

                        cmd.Parameters.Add(new OracleParameter(":Email", OracleDbType.Varchar2) { Value = staff.GetEmail() });
                        cmd.Parameters.Add(new OracleParameter(":Role", OracleDbType.Varchar2) { Value = staff.GetRole() });

                        cmd.ExecuteNonQuery();
                    }
                }

                CustomMessageBox.ShowBox(LangHelper.Instance.GetString("Added customer successfully!"), "Success");
            }
            catch (Exception ex)
            {
                throw new Exception("Error when add staff: " + ex.Message, ex);
            }
        }





        //Update nhân viên
        public void UpdateStaff(Staff staff)
        {
            string query = @"
        UPDATE STAFF_ACCOUNT 
        SET 
            WORKING_BRANCH = :WorkingBranch,
            JOB_POSITION = :JobPosition,
            EMAIL = :Email,
            ROLE = :Role
        WHERE ID = :Id";

            try
            {
                using (OracleConnection conn = new OracleConnection(connectionString))
                {
                    conn.Open();

                    using (OracleCommand cmd = new OracleCommand(query, conn))
                    {
                        //MessageBox.Show(staff.GetWorkingBranch() + " " + staff.GetJobPosition() + " " + staff.GetEmail() + " " + staff.GetRole() + " " + staff.GetId());
                        // Thêm tham số vào câu lệnh
                        cmd.Parameters.Add(new OracleParameter(":WorkingBranch", OracleDbType.Varchar2) { Value = staff.GetWorkingBranch() });
                        cmd.Parameters.Add(new OracleParameter(":JobPosition", OracleDbType.Varchar2) { Value = staff.GetJobPosition() });
                        cmd.Parameters.Add(new OracleParameter(":Email", OracleDbType.Varchar2) { Value = staff.GetEmail() });
                        cmd.Parameters.Add(new OracleParameter(":Role", OracleDbType.Varchar2) { Value = staff.GetRole() });
                        cmd.Parameters.Add(new OracleParameter(":Id", OracleDbType.Int32) { Value = staff.GetId() }); // Lấy ID của nhân viên

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error when updating staff: " + ex.Message, ex);
            }
        }





        //LoadAllStaff
        public DataTable LoadAllStaff()
        {
            DataTable dataTableStaff = new DataTable();
            string query = "SELECT * FROM STAFF_ACCOUNT";

            try
            {
                using (OracleConnection conn = new OracleConnection(connectionString))
                {
                    using (OracleCommand cmd = new OracleCommand(query, conn))
                    {
                        conn.Open();

                        using (OracleDataAdapter sqlDataAdapter = new OracleDataAdapter(cmd))
                        {
                            sqlDataAdapter.Fill(dataTableStaff);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Ném lại ngoại lệ
                throw new Exception("Error: " + ex.Message, ex);
            }

            return dataTableStaff;
        }
    }
}
