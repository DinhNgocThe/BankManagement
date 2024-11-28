using BankManagement.Language;
using BankManagement.View;
using System;
using System.Data;
using Oracle.ManagedDataAccess.Client;
using System.Windows.Forms;

namespace BankManagement.Model
{
    internal class LoanRepository
    {
        //Chuỗi kết nối database
        private string connectionString = getConnectionString.connectionString;

        public LoanRepository()
        {

        }

        //Tạo 1 khoản vay
        public void addLoan(Loan loan)
        {
            string query = "INSERT INTO Loan (principal_amount, loan_date, interest_rate, note, account_customer_loan_id, staff_account_loan_id, last_payment_date, paid_status, loan_term) " +
                           "VALUES (:Principal_amount, :Loan_date, :Interest_rate, :Note, :Account_customer_loan_id, :Staff_account_loan_id, :Last_payment_date, :Paid_status, :Loan_Term)";

            try
            {
                using (OracleConnection conn = new OracleConnection(connectionString))
                {
                    conn.Open();
                    using (OracleCommand cmd = new OracleCommand(query, conn))
                    {
                        cmd.Parameters.Add(new OracleParameter(":Principal_amount", OracleDbType.Decimal) { Value = loan.Principal_amount });
                        cmd.Parameters.Add(new OracleParameter(":Loan_date", OracleDbType.Date) { Value = loan.Loan_date });
                        cmd.Parameters.Add(new OracleParameter(":Interest_rate", OracleDbType.Double) { Value = loan.Interest_Rate });
                        cmd.Parameters.Add(new OracleParameter(":Note", OracleDbType.Varchar2) { Value = loan.Note });
                        cmd.Parameters.Add(new OracleParameter(":Account_customer_loan_id", OracleDbType.Int32) { Value = loan.CustomerAccountId });
                        cmd.Parameters.Add(new OracleParameter(":Staff_account_loan_id", OracleDbType.Int32) { Value = loan.StaffAccountId });
                        cmd.Parameters.Add(new OracleParameter(":Last_payment_date", OracleDbType.Date) { Value = loan.LastPaymentDate });
                        cmd.Parameters.Add(new OracleParameter(":Paid_status", OracleDbType.Int32) { Value = loan.Paid_status ? 1 : 0 }); // Oracle sử dụng 1 cho true, 0 cho false
                        cmd.Parameters.Add(new OracleParameter(":Loan_Term", OracleDbType.Int32) { Value = loan.LoanTerm });

                        cmd.ExecuteNonQuery();
                    }

                    CustomMessageBox.ShowBox(LangHelper.Instance.GetString("Loan created successfully!"), "Success");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error when add loan: " + ex.Message, ex);
            }
        }

        //Kiểm tra xem tài khoản này có đang phải trả khoản vay nào không
        public bool InPaymentPeriod(int id)
        {
            string query = "SELECT COUNT(*) FROM Loan WHERE account_customer_loan_id = :Id AND paid_status = 0";

            try
            {
                using (OracleConnection conn = new OracleConnection(connectionString))
                {
                    conn.Open();
                    using (OracleCommand cmd = new OracleCommand(query, conn))
                    {
                        cmd.Parameters.Add(new OracleParameter(":Id", OracleDbType.Int32) { Value = id });
                        return Convert.ToInt32(cmd.ExecuteScalar()) != 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error: " + ex.Message, ex);
            }
        }

        //Tìm kiếm 1 khoản vay
        public DataTable getLoanByIdAccount(int idAccount)
        {
            DataTable dt = new DataTable();
            string query = "SELECT * FROM Loan WHERE account_customer_loan_id = :IdAccount AND paid_status = 0";

            try
            {
                using (OracleConnection con = new OracleConnection(connectionString))
                using (OracleCommand cmd = new OracleCommand(query, con))
                {
                    cmd.Parameters.Add(new OracleParameter(":IdAccount", OracleDbType.Int32) { Value = idAccount });
                    using (OracleDataAdapter da = new OracleDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error: " + ex.Message, ex);
            }
            return dt;
        }

        //Thanh toán khoản vay
        public void payment(int id, bool paid_status)
        {
            string query = "UPDATE Loan SET last_payment_date = :Last_payment_date, paid_status = :Paid_status WHERE id = :Loan_id";
            DateTime time = DateTime.Today;

            try
            {
                using (OracleConnection conn = new OracleConnection(connectionString))
                {
                    conn.Open();
                    using (OracleCommand cmd = new OracleCommand(query, conn))
                    {
                        cmd.Parameters.Add(new OracleParameter(":Last_payment_date", OracleDbType.Date) { Value = time });
                        cmd.Parameters.Add(new OracleParameter(":Paid_status", OracleDbType.Int32) { Value = paid_status ? 1 : 0 }); // Oracle sử dụng 1 cho true, 0 cho false
                        cmd.Parameters.Add(new OracleParameter(":Loan_id", OracleDbType.Int32) { Value = id });
                        cmd.ExecuteNonQuery();
                    }

                    CustomMessageBox.ShowBox(LangHelper.Instance.GetString("Payment successful!"), "Success");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error: " + ex.Message, ex);
            }
        }
    }
}
