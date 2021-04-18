using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PremierServiceSolutions.DataAccessLayer
{
    class BusinessClientDAL
    {
        SqlConnection conn = new SqlConnection("Server= BAVHU\\SQLEXPRESS; Database = PremierServiceSolutionsDB; Trusted_Connection = true");


        public BusinessClient SearchBusinessClientByID(string id)
        {

            BusinessClient myClient = new BusinessClient();
            string query = $"SELECT * FROM BusinessClients WHERE ClientID = '{id}'";

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {

                        myClient.clientID = reader.GetString(0);
                        myClient.CompanyName = reader.GetString(1);
                        myClient.Phone = reader.GetString(2);
                        myClient.Email = reader.GetString(3);
                        myClient.AddressID = reader.GetString(4);
                        myClient.ContractID = reader.GetString(5);

                    }
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return myClient;
        }

        public List<Job> GetBusinessClientJobByClientID(string id)
        {
            Job clientJob = new Job();
            List<Job> jobs = new List<Job>();
            string query = $"SELECT * FROM IndividualClientJobs WHERE ClientID = '{id}'";

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {


                        clientJob.JobID = reader.GetString(0);
                        clientJob.Description = reader.GetString(1);
                        clientJob.Status = reader.GetString(2);
                        clientJob.Duration = reader.GetInt32(3);
                        clientJob.ClientID = reader.GetString(4);
                        clientJob.EmployeeID = reader.GetString(5);

                        jobs.Add(clientJob);
                    }

                }

                else
                {
                    MessageBox.Show("No Jobs found");
                }

                reader.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }
            finally
            {
                conn.Close();

            }



            return jobs;
        }
    }
}
