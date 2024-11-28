using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BankManagement.View;
using BankManagement.Language;
using Oracle.ManagedDataAccess.Client;

namespace BankManagement.Model
{
    internal class CustomerAccountWithInforRepository
    {
        //Chuỗi kết nối database
        private string connectionString = getConnectionString.connectionString;

        public CustomerAccountWithInforRepository()
        {

        }

        //Tìm kiếm theo account number và trả về một danh sách thông tin khách hàng và tài khoản tương ứng
        public DataTable SearchCustomerAccountByAccountNumber(int account_number)
        {
            DataTable dataTableCustomerAccountInfor = new DataTable();

            string query = "SELECT a.id, b.cccd, b.phone_number, b.name, b.gender, a.account_number, a.username, a.account_status, " +
               "b.date_of_birth, b.address, b.email, b.photo, b.status, a.date_opened, a.balance " +
               "FROM customer_account a INNER JOIN customer_infor b ON a.customer_id = b.id " +
               "WHERE CAST(a.account_number AS VARCHAR2(20)) LIKE :Account_number";


            try
            {
                using (OracleConnection conn = new OracleConnection(connectionString)) // Đảm bảo ngắt kết nối khi kết thúc khối lệnh
                {
                    conn.Open();

                    using (OracleCommand cmd = new OracleCommand(query, conn)) // Truy vấn
                    {
                        // Thêm tham số AccountNumber vào truy vấn
                        cmd.Parameters.Add(new OracleParameter(":Account_number", OracleDbType.Varchar2) { Value = "%" + account_number.ToString() + "%" });
                        // Sử dụng OracleDataAdapter để điền dữ liệu vào DataTable
                        using (OracleDataAdapter oracleDataAdapter = new OracleDataAdapter(cmd))
                        {
                            oracleDataAdapter.Fill(dataTableCustomerAccountInfor);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Ném lại ngoại lệ để form cha có thể xử lý
                throw new Exception("Error when search account: " + ex.Message, ex);
            }

            return dataTableCustomerAccountInfor; // Trả về danh sách thông tin khách hàng và tài khoản tương ứng
        }

        //Tìm kiếm theo account number và trả về một danh sách thông tin khách hàng và tài khoản tương ứng
        public DataTable SearchCustomerAccountByCccd(string cccd)
        {
            DataTable dataTableCustomerAccountInfor = new DataTable();

            string query = "SELECT a.id ,b.cccd ,b.name ,b.gender ,a.account_number, a.username, a.account_status," +
                " b.date_of_birth, b.address, b.email, b.photo, b.status, a.date_opened, a.balance " +
                "FROM customer_account a INNER JOIN customer_infor b ON a.customer_id = b.id " +
                "WHERE b.cccd LIKE :Cccd";

            try
            {
                using (OracleConnection conn = new OracleConnection(connectionString)) // Đảm bảo ngắt kết nối khi kết thúc khối lệnh
                {
                    conn.Open();

                    using (OracleCommand cmd = new OracleCommand(query, conn)) // Truy vấn
                    {
                        // Thêm tham số CCCD vào truy vấn
                        cmd.Parameters.Add(new OracleParameter(":Cccd", OracleDbType.Varchar2) { Value = "%" + cccd + "%" });
                        // Sử dụng OracleDataAdapter để điền dữ liệu vào DataTable
                        using (OracleDataAdapter oracleDataAdapter = new OracleDataAdapter(cmd))
                        {
                            oracleDataAdapter.Fill(dataTableCustomerAccountInfor);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Ném lại ngoại lệ để form cha có thể xử lý
                throw new Exception("Error: " + ex.Message, ex);
            }

            return dataTableCustomerAccountInfor; // Trả về danh sách thông tin khách hàng và tài khoản tương ứng
        }

        //Lấy ra thông tin tất cả các khách hàng và tài khoản tương ứng
        public DataTable LoadAllAccount()
        {
            DataTable dataTableAccount = new DataTable();
            string query = "select a.id, b.cccd, b.name, b.gender, a.account_number, a.username, a.account_status, b.date_of_birth, b.address, b.email, b.photo, b.status, a.date_opened, a.balance " +
                "FROM customer_account a inner join customer_infor b ON a.customer_id = b.id";

            try
            {
                using (OracleConnection conn = new OracleConnection(connectionString))
                {
                    conn.Open();

                    using (OracleCommand cmd = new OracleCommand(query, conn))
                    {
                        using (OracleDataAdapter oracleDataAdapter = new OracleDataAdapter(cmd))
                        {
                            oracleDataAdapter.Fill(dataTableAccount);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Ném lại ngoại lệ để form cha có thể xử lý
                throw new Exception("Error: " + ex.Message, ex);
            }
            return dataTableAccount;
        }

        //Thêm một tài khoản
        public void AddCustomerAccount(CustomerAccount customerAccount)
        {
            string query = "INSERT INTO customer_account " +
                           "(username, password, balance, date_opened, customer_id, account_status, account_number) " +
                           "VALUES (:Username, :Password, :Balance, :Date_opened, :Customer_id, :Account_status, :Account_number)";

            try
            {
                using (OracleConnection conn = new OracleConnection(connectionString))
                {
                    conn.Open();
                    using (OracleCommand cmd = new OracleCommand(query, conn))
                    {
                        // Thêm các tham số
                        cmd.Parameters.Add(new OracleParameter(":Username", OracleDbType.NVarchar2) { Value = customerAccount.Username });
                        cmd.Parameters.Add(new OracleParameter(":Password", OracleDbType.NVarchar2) { Value = customerAccount.Password });
                        cmd.Parameters.Add(new OracleParameter(":Balance", OracleDbType.Decimal) { Value = customerAccount.Balance }); // Sửa thành Decimal
                        cmd.Parameters.Add(new OracleParameter(":Date_opened", OracleDbType.Date) { Value = customerAccount.Date_opened }); // Không cần chuyển đổi
                        cmd.Parameters.Add(new OracleParameter(":Customer_id", OracleDbType.Int32) { Value = customerAccount.Customer_id });
                        cmd.Parameters.Add(new OracleParameter(":Account_status", OracleDbType.NVarchar2) { Value = customerAccount.Account_status });
                        cmd.Parameters.Add(new OracleParameter(":Account_number", OracleDbType.Int64) { Value = customerAccount.Account_number }); // Sử dụng Int64 vì NUMBER(15,0) lớn hơn Int32

                        // Thực thi câu lệnh
                        cmd.ExecuteNonQuery();
                    }
                }
                CustomMessageBox.ShowBox(LangHelper.Instance.GetString("Account created successfully!"), "Success");
            }
            catch (Exception ex)
            {
                // Ném lại ngoại lệ để form cha có thể xử lý
                throw new Exception("Error: " + ex.Message, ex);
            }
        }


        //Lấy ra số tài khoản lớn nhất
        public int getMaxAccountNumber()
        {
            int maxAccountNumber = 0;
            string query = "SELECT MAX(account_number) FROM customer_account";

            try
            {
                using (OracleConnection conn = new OracleConnection(connectionString))
                {
                    conn.Open();
                    using (OracleCommand cmd = new OracleCommand(query, conn))
                    {
                        object result = cmd.ExecuteScalar();
                        if (result != DBNull.Value)
                        {
                            maxAccountNumber = Convert.ToInt32(result);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Xử lý lỗi nếu có
                throw new Exception("Error: " + ex.Message, ex);
            }

            return maxAccountNumber;
        }

        //Lấy ra 1 tài khoản bằng userName
        public CustomerAccount getCustomerAccountByUserName(string user_name)
        {
            CustomerAccount customerAccount = null;
            string query = "SELECT * from customer_account where username = :Username";
            try
            {
                using (OracleConnection conn = new OracleConnection(connectionString))
                {
                    conn.Open();
                    using (OracleCommand cmd = new OracleCommand(query, conn))
                    {
                        cmd.Parameters.Add(new OracleParameter(":Username", OracleDbType.Varchar2) { Value = user_name });
                        using (OracleDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                int id = reader.GetInt32(0);
                                string username = reader.GetString(1);
                                string password = reader.GetString(2);
                                Decimal balance = reader.GetDecimal(3);
                                DateTime date_opened = reader.GetDateTime(4);
                                int customerId = reader.GetInt32(5);
                                string account_status = reader.GetString(6);
                                int accountNumber = reader.GetInt32(7);
                                customerAccount = new CustomerAccount(id, username, password, balance, date_opened, customerId, account_status, accountNumber);
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
            return customerAccount;
        }

        //Xoá tài khoản
        public void deleteCustomerAccount(int accountNumber)
        {
            string query = "Update customer_account SET account_status = :Status WHERE account_number = :AccountNumber";
            try
            {
                using (OracleConnection conn = new OracleConnection(connectionString))
                {
                    conn.Open();
                    using (OracleCommand cmd = new OracleCommand(query, conn))
                    {
                        cmd.Parameters.Add(new OracleParameter(":Status", OracleDbType.Varchar2) { Value = "Inactive" });
                        cmd.Parameters.Add(new OracleParameter(":AccountNumber", OracleDbType.Int32) { Value = accountNumber });
                        cmd.ExecuteNonQuery();
                    }
                }
                CustomMessageBox.ShowBox(LangHelper.Instance.GetString("Account deleted successfully!"), "Success");
            }
            catch (Exception ex)
            {
                // Ném lại ngoại lệ để form cha có thể xử lý
                throw new Exception("Error: " + ex.Message, ex);
            }
        }
        //Active tài khoản---------------------------------------------------------------------------------------------------------------------------------------------------------
        public void updateStatusAccountCustomer(int accountNumber)
        {
            string query = "UPDATE customer_account SET account_status = :Status WHERE account_number = :AccountNumber";
            try
            {
                using (OracleConnection conn = new OracleConnection(connectionString))
                {
                    conn.Open();

                    using (OracleCommand cmd = new OracleCommand(query, conn))
                    { 
                        cmd.Parameters.Add(new OracleParameter(":Status", OracleDbType.Varchar2) { Value = "Active" });
                        cmd.Parameters.Add(new OracleParameter(":AccountNumber", OracleDbType.Int32) { Value = accountNumber });
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            CustomMessageBox.ShowBox(LangHelper.Instance.GetString("Account recovery successful!"), "Success");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Ném lại ngoại lệ để form cha có thể xử lý
                throw new Exception("Error: " + ex.Message, ex);
            }
        }

        public bool updateAccountBalance(Decimal amount, int accountNumber)
        {
            // Cập nhật câu lệnh SQL với tham số :Amount
            string query = "UPDATE customer_account SET balance = balance + :Amount WHERE account_number = :AccountNumber";

            try
            {
                using (OracleConnection conn = new OracleConnection(connectionString))
                {
                    conn.Open();

                    using (OracleCommand cmd = new OracleCommand(query, conn))
                    {
                        // Thêm tham số :Amount
                        cmd.Parameters.Add(new OracleParameter(":Amount", OracleDbType.Decimal) { Value = amount });
                        // Thêm tham số :AccountNumber
                        cmd.Parameters.Add(new OracleParameter(":AccountNumber", OracleDbType.Int32) { Value = accountNumber });

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            return true;
                        }
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                // Ném lại ngoại lệ để form cha có thể xử lý
                throw new Exception("Error: " + ex.Message, ex);
            }
        }

    }
}
