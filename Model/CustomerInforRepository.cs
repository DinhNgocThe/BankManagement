using System;
using System.Collections.Generic;
using System.Data;
using Oracle.ManagedDataAccess.Client; // Thư viện Oracle
using BankManagement.View;
using BankManagement.Language;
using System.Windows.Forms;

namespace BankManagement.Model
{
    internal class CustomerInforRepository
    {
        //Chuỗi kết nối Oracle
        private string connectionString = getConnectionString.connectionString;

        public CustomerInforRepository()
        {
        }

        //Lấy ra thông tin của một khách hàng bằng CCCD
        public CustomerInfor getCustomerInforByCccd(string customerInforCccd)
        {
            CustomerInfor customerInfor = null;
            string query = "SELECT * FROM customer_infor WHERE cccd = :Cccd"; // Sử dụng tham số kiểu Oracle

            try
            {
                using (OracleConnection conn = new OracleConnection(connectionString))
                {
                    conn.Open();

                    using (OracleCommand cmd = new OracleCommand(query, conn)) // Truy vấn Oracle
                    {
                        // Thêm tham số cccd vào truy vấn
                        cmd.Parameters.Add(new OracleParameter(":Cccd", OracleDbType.Varchar2) { Value = customerInforCccd });

                        using (OracleDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                int id = reader.GetInt32(0);
                                string name = reader.GetString(1);
                                string cccd = reader.GetString(2);
                                string phone_number = reader.GetString(3);
                                string email = reader.GetString(4);
                                string job = reader.GetString(5);
                                string nationality = reader.GetString(6);
                                string address = reader.GetString(7);
                                DateTime date_of_birth = reader.GetDateTime(8);

                                // Kiểm tra nếu cột "photo" là DBNull, nếu không thì lấy giá trị của nó
                                string photo = reader.IsDBNull(9) ? null : reader.GetString(9);
                                string status = reader.GetString(10);
                                string gender = reader.GetString(11);

                                customerInfor = new CustomerInfor(id, name, cccd, phone_number, email, job, nationality, address, date_of_birth, photo, status, gender);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Xử lý lỗi nếu có
                throw new Exception("Error: " + ex.Message, ex);
            }

            return customerInfor;
        }

        //Lấy ra một list khách hàng bằng CCCD
        public DataTable searchCustomerByCccd(string cccd)
        {
            DataTable dataTableCustomerInfor = new DataTable();
            string query = "SELECT * FROM customer_infor WHERE cccd LIKE :Cccd";

            try
            {
                using (OracleConnection conn = new OracleConnection(connectionString))
                {
                    using (OracleCommand cmd = new OracleCommand(query, conn))
                    {
                        cmd.Parameters.Add(new OracleParameter(":Cccd", OracleDbType.Varchar2) { Value = "%" + cccd + "%" });

                        conn.Open();

                        using (OracleDataAdapter sqlDataAdapter = new OracleDataAdapter(cmd))
                        {
                            sqlDataAdapter.Fill(dataTableCustomerInfor);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Ném lại ngoại lệ
                throw new Exception("Error: " + ex.Message, ex);
            }

            return dataTableCustomerInfor;
        }

        //Lấy ra tất cả khách hàng
        public DataTable LoadAllCustomer()
        {
            DataTable dt = new DataTable();
            string query = "SELECT * FROM customer_infor";

            try
            {
                using (OracleConnection conn = new OracleConnection(connectionString))
                {
                    using (OracleCommand cmd = new OracleCommand(query, conn))
                    {
                        conn.Open();

                        using (OracleDataAdapter da = new OracleDataAdapter(cmd))
                        {
                            da.Fill(dt);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error: " + ex.Message, ex);
            }

            return dt;
        }

        //Thêm một khách hàng
        public void addCustomer(CustomerInfor customerInfor)
        {
            string query = "INSERT INTO customer_Infor (name, cccd, phone_number, email, job, nationality, address, date_of_birth, photo, gender) " +
                           "VALUES (:Name, :Cccd, :PhoneNumber, :Email, :Job, :Nationality, :Address, :DateOfBirth, :PhotoPath, :Gender)";
            try
            {
                using (OracleConnection conn = new OracleConnection(connectionString))
                {
                    conn.Open();

                    using (OracleCommand cmd = new OracleCommand(query, conn))
                    {
                        cmd.Parameters.Add(new OracleParameter(":Name", OracleDbType.Varchar2) { Value = customerInfor.Name });
                        cmd.Parameters.Add(new OracleParameter(":Cccd", OracleDbType.Varchar2) { Value = customerInfor.Cccd });
                        cmd.Parameters.Add(new OracleParameter(":PhoneNumber", OracleDbType.Varchar2) { Value = customerInfor.PhoneNumber });
                        cmd.Parameters.Add(new OracleParameter(":Email", OracleDbType.Varchar2) { Value = customerInfor.Email });
                        cmd.Parameters.Add(new OracleParameter(":Job", OracleDbType.Varchar2) { Value = customerInfor.Job });
                        cmd.Parameters.Add(new OracleParameter(":Nationality", OracleDbType.Varchar2) { Value = customerInfor.Nationality });
                        cmd.Parameters.Add(new OracleParameter(":Address", OracleDbType.Varchar2) { Value = customerInfor.Address });

                        // Truyền trực tiếp DateTime mà không cần chuyển đổi sang chuỗi
                        cmd.Parameters.Add(new OracleParameter(":DateOfBirth", OracleDbType.Date) { Value = customerInfor.DateOfBirth });

                        if (!string.IsNullOrEmpty(customerInfor.PhotoPath))
                        {
                            cmd.Parameters.Add(new OracleParameter(":PhotoPath", OracleDbType.Varchar2) { Value = customerInfor.PhotoPath });
                        }
                        else
                        {
                            cmd.Parameters.Add(new OracleParameter(":PhotoPath", OracleDbType.Varchar2) { Value = DBNull.Value });
                        }

                        cmd.Parameters.Add(new OracleParameter(":Gender", OracleDbType.Varchar2) { Value = customerInfor.Gender });

                        cmd.ExecuteNonQuery();
                    }
                }

                CustomMessageBox.ShowBox(LangHelper.Instance.GetString("Added customer successfully!"), "Success");
            }
            catch (Exception ex)
            {
                throw new Exception("Error when add customer: " + ex.Message, ex);
            }
        }


        //Xoá một khách hàng
        public void deleteCustomer(string cccd)
        {
            string query = "UPDATE customer_Infor SET status = 'Inactive' WHERE cccd = :Cccd";

            try
            {
                using (OracleConnection conn = new OracleConnection(connectionString))
                {
                    conn.Open();

                    using (OracleCommand cmd = new OracleCommand(query, conn))
                    {
                        cmd.Parameters.Add(new OracleParameter(":Cccd", OracleDbType.Varchar2) { Value = cccd });
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            // Hiển thị thông báo khi cập nhật thành công
                            CustomMessageBox.ShowBox(LangHelper.Instance.GetString("Customer deleted successfully!"), "Success");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Bắt lỗi và hiển thị thông báo lỗi nếu có
                throw new Exception("Error: " + ex.Message, ex);
            }
        }
        //Active khách hàng
        public void activeCustomer(string cccd)
        {
            string query = "UPDATE customer_Infor SET status = 'Active' WHERE cccd = :Cccd";

            try
            {
                using (OracleConnection conn = new OracleConnection(connectionString))
                {
                    conn.Open();

                    using (OracleCommand cmd = new OracleCommand(query, conn))
                    {
                        cmd.Parameters.Add(new OracleParameter(":Cccd", OracleDbType.Varchar2) { Value = cccd });
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            // Hiển thị thông báo khi cập nhật thành công
                            CustomMessageBox.ShowBox(LangHelper.Instance.GetString("Customer active successfully!"), "Success");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Bắt lỗi và hiển thị thông báo lỗi nếu có
                throw new Exception("Error: " + ex.Message, ex);
            }
        }


        //Cập nhật thông tin khách hàng
        public void updateCustomer(CustomerInfor customerInfor)
        {
            string query = "UPDATE customer_Infor SET " +
                           "name = :Name, phone_number = :PhoneNumber, email = :Email, " +
                           "job = :Job, nationality = :Nationality, address = :Address, " +
                           "date_of_birth = :DateOfBirth, photo = :PhotoPath, gender = :Gender " +
                           "WHERE cccd = :Cccd";

            try
            {
                using (OracleConnection conn = new OracleConnection(connectionString))
                {
                    conn.Open();

                    using (OracleCommand cmd = new OracleCommand(query, conn))
                    {
                        // Thêm các tham số vào câu truy vấn
                        cmd.Parameters.Add(new OracleParameter(":Name", OracleDbType.Varchar2) { Value = customerInfor.Name });
                        cmd.Parameters.Add(new OracleParameter(":PhoneNumber", OracleDbType.Varchar2) { Value = customerInfor.PhoneNumber });
                        cmd.Parameters.Add(new OracleParameter(":Email", OracleDbType.Varchar2) { Value = customerInfor.Email });
                        cmd.Parameters.Add(new OracleParameter(":Job", OracleDbType.Varchar2) { Value = customerInfor.Job });
                        cmd.Parameters.Add(new OracleParameter(":Nationality", OracleDbType.Varchar2) { Value = customerInfor.Nationality });
                        cmd.Parameters.Add(new OracleParameter(":Address", OracleDbType.Varchar2) { Value = customerInfor.Address });

                        // Xử lý DateOfBirth và kiểm tra null
                        if (customerInfor.DateOfBirth != DateTime.MinValue)
                        {
                            cmd.Parameters.Add(new OracleParameter(":DateOfBirth", OracleDbType.Date) { Value = customerInfor.DateOfBirth });
                        }
                        else
                        {
                            cmd.Parameters.Add(new OracleParameter(":DateOfBirth", OracleDbType.Date) { Value = DBNull.Value });
                        }

                        // Kiểm tra nếu có PhotoPath
                        if (!string.IsNullOrEmpty(customerInfor.PhotoPath))
                        {
                            cmd.Parameters.Add(new OracleParameter(":PhotoPath", OracleDbType.Varchar2) { Value = customerInfor.PhotoPath });
                        }
                        else
                        {
                            cmd.Parameters.Add(new OracleParameter(":PhotoPath", OracleDbType.Varchar2) { Value = DBNull.Value });
                        }

                        // Thêm tham số Gender
                        cmd.Parameters.Add(new OracleParameter(":Gender", OracleDbType.Varchar2) { Value = customerInfor.Gender });
                        cmd.Parameters.Add(new OracleParameter(":Cccd", OracleDbType.Varchar2) { Value = customerInfor.Cccd });
                        // Thực hiện câu lệnh update
                        int rowsAffected = cmd.ExecuteNonQuery();

                        // Kiểm tra nếu có bản ghi được cập nhật
                        if (rowsAffected > 0)
                        {
                            CustomMessageBox.ShowBox(LangHelper.Instance.GetString("Update successful!"), "Success");
                        }
                        else
                        {
                            CustomMessageBox.ShowBox(LangHelper.Instance.GetString("No customer found with the given CCCD!"), "Error");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ
                throw new Exception("Error: " + ex.Message, ex);
            }
        }

    }
}
