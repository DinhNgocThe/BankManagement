using System;
using System.Data;
using BankManagement.Language;
using BankManagement.View;
using Oracle.ManagedDataAccess.Client;

namespace BankManagement.Model
{
    internal class NotifyRepository
    {
        //Chuỗi kết nối database
        private string connectionString = getConnectionString.connectionString;

        public DataTable getAllNotifyByStaffId(int Id)
        {
            DataTable dt = new DataTable();

            // Câu truy vấn SQL cho Oracle
            string query = @"
            SELECT * 
            FROM (
                SELECT id, sn.notification_id, n.title, n.message, n.DateCreated, sn.isRead, sn.staff_id
                FROM staff_account sa 
                JOIN staff_notification sn ON sa.id = sn.staff_id
                JOIN notifications n ON sn.notification_id = n.notificationID
                WHERE sa.id = :Id 
                ORDER BY n.DateCreated DESC
            ) 
            WHERE ROWNUM <= 100";

            try
            {
                using (OracleConnection conn = new OracleConnection(connectionString))
                {
                    conn.Open();
                    using (OracleCommand cmd = new OracleCommand(query, conn))
                    {
                        // Thêm tham số vào câu truy vấn Oracle
                        cmd.Parameters.Add(new OracleParameter(":Id", OracleDbType.Int32) { Value = Id });

                        // Sử dụng OracleDataAdapter để điền dữ liệu vào DataTable
                        using (OracleDataAdapter oracleDataAdapter = new OracleDataAdapter(cmd))
                        {
                            oracleDataAdapter.Fill(dt);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Ném lại ngoại lệ để form cha có thể xử lý
                throw new Exception("Error: " + ex.Message, ex);
            }

            return dt;
        }




        public void markAsRead(int staffId, int notificationId)
        {
            string query = "UPDATE staff_notification SET isRead = 1 WHERE staff_id = :staffId AND notification_id = :notificationId";

            try
            {
                using (OracleConnection conn = new OracleConnection(connectionString))
                {
                    conn.Open();
                    using (OracleCommand cmd = new OracleCommand(query, conn))
                    {
                        // Thêm tham số vào câu truy vấn
                        cmd.Parameters.Add(new OracleParameter(":staffId", OracleDbType.Int32) { Value = staffId });
                        cmd.Parameters.Add(new OracleParameter(":notificationId", OracleDbType.Int32) { Value = notificationId });

                        // Thực thi câu lệnh
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ nếu có
                throw new Exception("Error when markAsRead: " + ex.Message, ex);
            }
        }




        public void CreateNotification(Notify notify)
        {
            string query = "INSERT INTO NOTIFICATIONS (TITLE, MESSAGE) " +
                           "VALUES (:Title, :Message)";
            try
            {
                using (OracleConnection conn = new OracleConnection(connectionString))
                {
                    conn.Open();

                    using (OracleCommand cmd = new OracleCommand(query, conn))
                    {
                        cmd.Parameters.Add(new OracleParameter(":Title", OracleDbType.Varchar2) { Value = notify.Title });
                        cmd.Parameters.Add(new OracleParameter(":Message", OracleDbType.Varchar2) { Value = notify.Message });
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error when create notification: " + ex.Message, ex);
            }
        }
    }
}
