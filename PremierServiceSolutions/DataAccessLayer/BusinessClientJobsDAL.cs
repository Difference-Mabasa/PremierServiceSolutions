using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PremierServiceSolutions.DataAccessLayer
{
    class BusinessClientJobsDAL
    {
        SqlConnection conn = new SqlConnection("Server= (local); Database = PremierServiceSolutionsDB; Trusted_Connection = true");

        public List<Job> GetBusinessClientJobByClientID(string id)
        {
            Job clientJob = new Job();
            List<Job> jobs = new List<Job>();
            string query = $"SELECT * FROM BusinessClientJobs WHERE ClientID = '{id}'";

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

        public void InsertBusinessClientJob(Job job)
        {
            string query = $"insert into BusinessClientJobs values" +
                $"('{job.JobID}', " +
                $"'{job.Description}', " +
                $"'{job.Status}', " +
                $"'{job.Duration}', " +
                $"{job.ClientID}, " +
                $"'{job.EmployeeID}')";

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Inserted Successfully");
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

        public void UpdateBusinessClientJob(Job job)
        {
            string query = $"update IndividualClientJobs set" +
                $"JobID = '{job.JobID}', " +
                $"JobDescription = '{job.Description}', " +
                $"JobStatus = '{job.Status}', " +
                $"JobDuration = '{job.Duration}', " +
                $"CompanyID = {job.ClientID}, " +
                $"EmployeeID = '{job.EmployeeID}'" +
                $"where JobID = '{job.JobID}'";
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Updated Successfully");
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


    }
}
