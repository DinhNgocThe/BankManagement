using BankManagement.Language;
using BankManagement.View;
using System;
using System.Collections.Generic;
using System.Data;
using Oracle.ManagedDataAccess.Client;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Configuration;
using System.Windows.Forms;

namespace BankManagement.Model
{
    internal class FeedBackReponsitory
    {
        //Chuỗi kết nối database
        private string connectionString = getConnectionString.connectionString;
        public FeedBackReponsitory()
        {
        }

        //thêm một feedback vào cơ sở dữ liệu
        public void addFeedBack(FeedBack feedBack)
        {
            string query = "INSERT INTO feedback (title, descriptions, staff_id, rating) VALUES (:Title, :Descriptions, :Staff_id, :Rating)";
            try
            {
                using (OracleConnection conn = new OracleConnection(connectionString))
                {
                    conn.Open();
                    using (OracleCommand cmd = new OracleCommand(query, conn))
                    {
                        cmd.Parameters.Add(new OracleParameter(":Title", OracleDbType.Varchar2) { Value = feedBack.Title });
                        cmd.Parameters.Add(new OracleParameter(":Descriptions", OracleDbType.Varchar2) { Value = feedBack.Description });
                        cmd.Parameters.Add(new OracleParameter(":Staff_id", OracleDbType.Int32) { Value = feedBack.StaffId });
                        cmd.Parameters.Add(new OracleParameter(":Rating", OracleDbType.Int32) { Value = feedBack.Rating });
                        cmd.ExecuteNonQuery();
                    }
                }
                CustomMessageBox.ShowBox(LangHelper.Instance.GetString("Feedback sent successfully!"), "Success");
            }
            catch (Exception ex)
            {
                // Ném lại ngoại lệ để form cha có thể xử lý
                throw new Exception("Error: " + ex.Message, ex);
            }
        }
    }
}
