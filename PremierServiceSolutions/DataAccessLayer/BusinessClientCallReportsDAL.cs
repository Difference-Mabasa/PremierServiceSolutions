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

        public void InsertBusinessCallReport()
        {
            //string query = $"insert into BusinessClientCallReports(CallID,CallDuration,CallDate,CallStartTime,CompanyID,EmployeeID) values" +
            //$"('{}', " +
            //$"'{}', " +
            //$"'{}', " +
            //$"'{}', " +
            //$"'{}', " +
            //$"'{}')";

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

        //public List<IndividualClientCallReport> GetAllBusinessCallReports()
        //{
        //    List<IndividualClientCallReport> callreports = new List<IndividualClientCallReport>();
        //    DataTable datatable = new DataTable();

        //    string query = $"SELECT * FROM BusinessClientCallReports ";

        //    try
        //    {
        //        conn.Open();
        //        SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
        //        adapter.Fill(datatable);
        //        foreach (DataRow row in datatable.Rows)
        //        {
        //            callreports = row["CallID"].ToString();
        //            callreports = row["CallDuration"].ToString();
        //            callreports = row["CallDate"].ToString();
        //            callreports = row["CallStartTime"].ToString();
        //            callreports = row["CompanyID"].ToString();
        //            callreports = row["EmployeeID"].ToString();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("ERROR: " + ex.Message);
        //    }
        //    finally
        //    {
        //        conn.Close();

        //    }
        //    return callreports;
        //}
    }
}
