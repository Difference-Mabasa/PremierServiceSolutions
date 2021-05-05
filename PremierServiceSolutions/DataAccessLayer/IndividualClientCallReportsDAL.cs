﻿using System;
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

        public void InsertIndividualCallReport(Call call)
        {
            string query = $"insert into IndividualClientCallReports(CallID,CallDuration,CallDate,CallStartTime,ClientID,EmployeeID) values" +
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
                    details.Duration = row["CallDuration"].ToString();
                    details.CallDate = row["CallDate"].ToString();
                    details.StartTime = row["CallStartTime"].ToString();
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
    }
}
