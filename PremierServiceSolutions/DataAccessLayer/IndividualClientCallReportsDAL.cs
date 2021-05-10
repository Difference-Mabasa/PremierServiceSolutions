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
    class IndividualClientCallReportsDAL
    {
        SqlConnection conn = DBAccess.GetSQLConnection();
        SqlCommand cmd;
        string query;

        public List<Call> GetIndividualClientCallReportsByClientID(string id)
        {
            List<Call> calls = new List<Call>();
            Call clientCall = new Call();
            string query = $"SELECT * FROM IndividualClientCallReports WHERE ClientID = '{id}'";

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        clientCall.CallID = reader.GetString(0);
                        clientCall.Duration = reader.GetInt32(1);
                        clientCall.StartTime = Convert.ToDateTime(reader.GetString(2));
                        clientCall.CallDate = Convert.ToDateTime(reader.GetString(3));
                        clientCall.ClientID = reader.GetString(4);
                        clientCall.EmployeeID = reader.GetString(5);

                        calls.Add(clientCall);
                    }

                }

                else
                {
                    MessageBox.Show("No previous jobs found");
                }

                reader.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR!: " + ex.Message);
            }
            finally
            {
                conn.Close();

            }



            return calls;
        }

        public void InsertIndividualCallReport(Call call)
        {
            string query = $"insert into IndividualClientCallReports(CallID,CallDuration,CallDateDate,CallStartTime,ClientID,EmployeeID) values" +
            $"('{call.CallID}', " +
            $"'{call.Duration}', " +
            $"'{call.CallDate.ToString()}', " +
            $"'{call.StartTime.ToString()}', " +
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

        public List<Call> GetAllIndividualCallReports()
        {
            List<Call> callreports = new List<Call>();
            DataTable datatable = new DataTable();

            string query = $"SELECT * FROM IndividualClientCallReports ";

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

        public int CountIndividualClientCallReports()
        {
            string query = $"SELECT COUNT(CallID) FROM IndividualClientCallReports";
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
