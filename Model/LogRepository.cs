using Oracle.ManagedDataAccess.Client;  // Thư viện Oracle
using System;
using System.Data;
using System.Collections.Generic;

namespace BankManagement.Model
{
    internal class LogRepository
    {
        //Chuỗi kết nối database
        private string connectionString = getConnectionString.connectionString;

        //Lấy ra list log bằng staff_id
        public DataTable searchLogByStaffId(int id, DateTime from, DateTime to)
        {
            DataTable dataTableLog = new DataTable();

            // Lệnh truy vấn
            string query = @"SELECT id, staff_id, content, time 
                     FROM log 
                     WHERE staff_id = :staffId 
                     AND time BETWEEN :fromt AND :tot
                     ORDER BY time DESC"; // Sắp xếp theo thời gian giảm dần

            try
            {
                using (OracleConnection conn = new OracleConnection(connectionString))
                {
                    using (OracleCommand cmd = new OracleCommand(query, conn))
                    {
                        // Thêm tham số cho truy vấn (không cần dấu ":" trong khi thêm tham số)
                        cmd.Parameters.Add(new OracleParameter("staffId", OracleDbType.Int32) { Value = id });
                        cmd.Parameters.Add(new OracleParameter("fromt", OracleDbType.Date) { Value = from });
                        cmd.Parameters.Add(new OracleParameter("tot", OracleDbType.Date) { Value = to });

                        // Mở kết nối đến cơ sở dữ liệu
                        conn.Open();

                        // Sử dụng OracleDataAdapter để điền dữ liệu vào DataTable
                        using (OracleDataAdapter oracleDataAdapter = new OracleDataAdapter(cmd))
                        {
                            oracleDataAdapter.Fill(dataTableLog);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Ném lại ngoại lệ
                throw new Exception("Error when search log: " + ex.Message, ex);
            }

            // Trả về DataTable chứa các bản ghi tìm kiếm được
            return dataTableLog;
        }



        // Thêm bản ghi log
        public void AddLog(Log log)
        {
            // Lệnh truy vấn để thêm bản ghi mới vào bảng log
            string query = "INSERT INTO log (staff_id, content) VALUES (:staffId, :content)";

            try
            {
                using (OracleConnection conn = new OracleConnection(connectionString))
                {
                    using (OracleCommand cmd = new OracleCommand(query, conn))
                    {
                        // Thêm tham số vào câu truy vấn
                        cmd.Parameters.Add(new OracleParameter(":staffId", OracleDbType.Int32) { Value = log.StaffId });
                        cmd.Parameters.Add(new OracleParameter(":content", OracleDbType.NVarchar2) { Value = log.Content });

                        // Mở kết nối đến cơ sở dữ liệu
                        conn.Open();

                        // Thực thi câu lệnh INSERT
                        cmd.ExecuteNonQuery();
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
