using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace PremierServiceSolutions.DataAccessLayer
{
    class BusinessClientCallReportsDAL
    {
        SqlConnection conn = DBAccess.GetSQLConnection();
        SqlCommand cmd;
        string query;

        public void InsertBusinessCallReport(Call call)
        {
            string query = $"insert into BusinessClientCallReports(CallID,CallDuration,CallDate,CallStartTime,CompanyID,EmployeeID) values" +
            $"('{call.CallID}', " +
            $"'{call.Duration}', " +
            $"'{call.CallDate}', " +
            $"'{call.StartTime}', " +
            $"'{call.ClientID}', " +
            $"'{call.EmployeeID}')";

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }

            finally
            {
                conn.Close();
            }
        }

        public List<Call> GetAllBusinessCallReports()
        {
            List<Call> callreports = new List<Call>();
            DataTable datatable = new DataTable();

            string query = $"SELECT * FROM BusinessClientCallReports ";

            try
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                adapter.Fill(datatable);
                foreach (DataRow row in datatable.Rows)
                {
                    Call details = new Call();
                    details.CallID = row["CallID"].ToString();
                    details.Duration = (int)row["CallDuration"];
                    details.CallDate = (DateTime)row["CallDate"];
                    details.StartTime = (DateTime)row["CallStartTime"];
                    details.ClientID = row["ClientID"].ToString();
                    details.EmployeeID = row["EmployeeID"].ToString();
                    callreports.Add(details);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }
            finally
            {
                conn.Close();

            }
            return callreports;
        }

        public int CountBusinessClientCallReports()
        {
            string query = $"SELECT COUNT(CallID) FROM BusinessClientCallReports";
            int total = 0;

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);

                total = (int)cmd.ExecuteScalar();

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }
            finally
            {
                conn.Close();

            }

            return total;
        }
    }
}
