using System;
using System.Data;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;

namespace BankManagement.Model
{
    internal class TransactionReponsitory
    {
        //Chuỗi kết nối database
        private string connectionString = getConnectionString.connectionString;

        //thêm một transaction transfer vào trong cơ sở dữ liệu
        public void addTransactionTransfer(Transaction transaction)
        {
            string query = @"
            INSERT INTO transaction_transfer (amount, date_transfer, note, account_customer_send, account_customer_receive, staff_account_transfer_id)
            VALUES (:Amount, :DateTransfer, :Note, :Account_customer_send, :Account_customer_receive, :Staff_account_transfer_id)
            RETURNING id INTO :Id";

            try
            {
                using (OracleConnection conn = new OracleConnection(connectionString))
                {
                    conn.Open();
                    using (OracleCommand cmd = new OracleCommand(query, conn))
                    {
                        // Thêm tham số
                        cmd.Parameters.Add(new OracleParameter(":Amount", OracleDbType.Decimal) { Value = transaction.Amount });
                        cmd.Parameters.Add(new OracleParameter(":DateTransfer", OracleDbType.Date) { Value = transaction.Date });
                        cmd.Parameters.Add(new OracleParameter(":Note", OracleDbType.NVarchar2) { Value = transaction.Note });
                        cmd.Parameters.Add(new OracleParameter(":Account_customer_send", OracleDbType.Int32) { Value = transaction.Account_customer_send_id });
                        cmd.Parameters.Add(new OracleParameter(":Account_customer_receive", OracleDbType.Int32) { Value = transaction.Account_customer_receive_id });
                        cmd.Parameters.Add(new OracleParameter(":Staff_account_transfer_id", OracleDbType.Int32) { Value = transaction.Staff_account_transfer_id });

                        // Thêm tham số để nhận giá trị ID
                        OracleParameter idParam = new OracleParameter(":Id", OracleDbType.Int32);
                        idParam.Direction = ParameterDirection.Output;
                        cmd.Parameters.Add(idParam);

                        // Thực thi lệnh
                        cmd.ExecuteNonQuery();

                        // Lấy ID vừa chèn
                        OracleDecimal oracleDecimal = (OracleDecimal)idParam.Value; // Lấy giá trị từ OracleDecimal
                        transaction.Id = oracleDecimal.IsNull ? 0 : oracleDecimal.ToInt32(); // Chuyển đổi sang kiểu int32 nếu có giá trị
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error: " + ex.Message, ex);
            }
        }


        //thêm một transaction deposit vào trong cơ sở dữ liệu
        public void addTransactionDeposit(Transaction transaction)
        {
            string query = @"
            INSERT INTO transaction_deposit (amount, date_deposit, note, account_customer_deposit_id, staff_account_deposit_id)
            VALUES (:Amount, :DateDeposit, :Note, :Account_customer_deposit_id, :Staff_account_deposit_id)
            RETURNING id INTO :Id";

            try
            {
                using (OracleConnection conn = new OracleConnection(connectionString))
                {
                    conn.Open();
                    using (OracleCommand cmd = new OracleCommand(query, conn))
                    {
                        cmd.Parameters.Add(new OracleParameter(":Amount", OracleDbType.Decimal) { Value = transaction.Amount });
                        cmd.Parameters.Add(new OracleParameter(":DateDeposit", OracleDbType.Date) { Value = transaction.Date });
                        cmd.Parameters.Add(new OracleParameter(":Note", OracleDbType.NVarchar2) { Value = transaction.Note });
                        cmd.Parameters.Add(new OracleParameter(":Account_customer_deposit_id", OracleDbType.Int32) { Value = transaction.Account_customer_send_id });
                        cmd.Parameters.Add(new OracleParameter(":Staff_account_deposit_id", OracleDbType.Int32) { Value = transaction.Staff_account_transfer_id });

                        // Thêm tham số để nhận giá trị ID
                        OracleParameter idParam = new OracleParameter(":Id", OracleDbType.Int32);
                        idParam.Direction = ParameterDirection.Output;
                        cmd.Parameters.Add(idParam);

                        // Thực thi lệnh
                        cmd.ExecuteNonQuery();

                        // Kiểm tra xem idParam có phải là kiểu OracleDecimal không
                        if (idParam.Value is OracleDecimal oracleDecimal)
                        {
                            // Chuyển giá trị OracleDecimal sang int
                            transaction.Id = oracleDecimal.IsNull ? 0 : oracleDecimal.ToInt32(); // Chuyển đổi sang int nếu không phải null
                        }
                        else
                        {
                            throw new InvalidCastException("The value returned for Id is not of type OracleDecimal.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error: " + ex.Message, ex);
            }
        }


        //thêm một transaction withdraw vào trong cơ sở dữ liệu
        public void addTransactionWithdraw(Transaction transaction)
        {
            string query = @"
            INSERT INTO transaction_withdraw (amount, date_withdraw, note, account_customer_withdraw_id, staff_account_withdraw_id)
            VALUES (:Amount, :DateWithdraw, :Note, :Account_customer_withdraw_id, :Staff_account_withdraw_id)
            RETURNING id INTO :Id";

            try
            {
                using (OracleConnection conn = new OracleConnection(connectionString))
                {
                    conn.Open();
                    using (OracleCommand cmd = new OracleCommand(query, conn))
                    {
                        cmd.Parameters.Add(new OracleParameter(":Amount", OracleDbType.Decimal) { Value = transaction.Amount });
                        cmd.Parameters.Add(new OracleParameter(":DateWithdraw", OracleDbType.Date) { Value = transaction.Date });
                        cmd.Parameters.Add(new OracleParameter(":Note", OracleDbType.NVarchar2) { Value = transaction.Note });
                        cmd.Parameters.Add(new OracleParameter(":Account_customer_withdraw_id", OracleDbType.Int32) { Value = transaction.Account_customer_send_id });
                        cmd.Parameters.Add(new OracleParameter(":Staff_account_withdraw_id", OracleDbType.Int32) { Value = transaction.Staff_account_transfer_id });

                        // Thêm tham số để nhận giá trị ID
                        OracleParameter idParam = new OracleParameter(":Id", OracleDbType.Int32);
                        idParam.Direction = ParameterDirection.Output;
                        cmd.Parameters.Add(idParam);

                        // Thực thi lệnh
                        cmd.ExecuteNonQuery();

                        // Kiểm tra xem idParam có phải là kiểu OracleDecimal không
                        if (idParam.Value is OracleDecimal oracleDecimal)
                        {
                            // Chuyển giá trị OracleDecimal sang int
                            transaction.Id = oracleDecimal.IsNull ? 0 : oracleDecimal.ToInt32(); // Chuyển đổi sang int nếu không phải null
                        }
                        else
                        {
                            throw new InvalidCastException("The value returned for Id is not of type OracleDecimal.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error: " + ex.Message, ex);
            }
        }


        //lấy tất cả giao dịch rút tiền bởi id tài khoản
        public DataTable getAllWithDrawByIdAccount(int account_id)
        {
            DataTable dt = new DataTable();
            string query = "SELECT * FROM transaction_withdraw WHERE account_customer_withdraw_id = :Account_customer_withdraw_id";
            try
            {
                using (OracleConnection con = new OracleConnection(connectionString))
                {
                    con.Open();
                    using (OracleCommand cmd = new OracleCommand(query, con))
                    {
                        cmd.Parameters.Add(new OracleParameter(":Account_customer_withdraw_id", OracleDbType.Int32) { Value = account_id });
                        using (OracleDataAdapter sqlDataAdapter = new OracleDataAdapter(cmd))
                        {
                            sqlDataAdapter.Fill(dt);
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

        //lấy tất cả giao dịch gửi tiền bởi id tài khoản
        public DataTable getAllDepositByIdAccount(int account_id)
        {
            DataTable dt = new DataTable();
            string query = "SELECT * FROM transaction_deposit WHERE account_customer_deposit_id = :Account_customer_deposit_id";
            try
            {
                using (OracleConnection con = new OracleConnection(connectionString))
                {
                    con.Open();
                    using (OracleCommand cmd = new OracleCommand(query, con))
                    {
                        cmd.Parameters.Add(new OracleParameter(":Account_customer_deposit_id", OracleDbType.Int32) { Value = account_id });
                        using (OracleDataAdapter sqlDataAdapter = new OracleDataAdapter(cmd))
                        {
                            sqlDataAdapter.Fill(dt);
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

        //lấy tất cả giao dịch chuyển khoản giữa 2 tài khoản
        public DataTable getAllTransferByIdAccount(int account_id)
        {
            DataTable dt = new DataTable();
            string query = "SELECT * FROM transaction_transfer WHERE account_customer_send = :Account_customer_send";
            try
            {
                using (OracleConnection con = new OracleConnection(connectionString))
                {
                    con.Open();
                    using (OracleCommand cmd = new OracleCommand(query, con))
                    {
                        cmd.Parameters.Add(new OracleParameter(":Account_customer_send", OracleDbType.Int32) { Value = account_id });
                        using (OracleDataAdapter sqlDataAdapter = new OracleDataAdapter(cmd))
                        {
                            sqlDataAdapter.Fill(dt);
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
    }
}
