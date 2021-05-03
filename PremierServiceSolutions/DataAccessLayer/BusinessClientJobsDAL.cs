using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace PremierServiceSolutions.DataAccessLayer
{
    class BusinessClientJobsDAL
    {
        SqlConnection conn = new SqlConnection("Server= (local); Database = PremierServiceSolutionsDB; Trusted_Connection = true");

        public List<Job> GetBusinessClientJobsByClientID(string id)
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
            string query = $"update BusinessClientJobs set " +
                $"JobID = '{job.JobID}', " +
                $"JobDescription = '{job.Description}', " +
                $"JobStatus = '{job.Status}', " +
                $"JobDuration = '{job.Duration}', " +
                $"CompanyID = '{job.ClientID}', " +
                $"EmployeeID = '{job.EmployeeID}' " +
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

        public void UpdateBusinessClientJobTech(Job job)
        {
            string query = $"update BusinessClientJobs set " +
                $"JobDescription = '{job.Description}', " +
                $"JobStatus = '{job.Status}', " +
                $"JobDuration = '{job.Duration}', " +
                $"CompanyID = '{job.ClientID}', " +
                $"EmployeeID = ( select EmployeeID from Employees where EmployeeName = '{job.Technician}') " +
                $"where JobID = '{job.JobID}' ";
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
        public List<Job> GetAllBusinessJobs()
        {
            List<Job> ICJobs = new List<Job>();

            DataTable datatable = new DataTable();
            string query = $"select * from BusinessClientJobs";

            try
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                adapter.Fill(datatable);
                foreach (DataRow row in datatable.Rows)
                {
                    Job ICjob = new Job();

                    ICjob.JobID = row["JobID"].ToString();
                    ICjob.Description = row["JobDescription"].ToString();
                    ICjob.Status = row["JobStatus"].ToString();
                    ICjob.Duration = int.Parse(row["JobDuration"].ToString());
                    ICjob.ClientID = row["ClientID"].ToString();
                    ICjob.EmployeeID = row["EmployeeID"].ToString();
                    ICJobs.Add(ICjob);
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
            return ICJobs;
        }

        public List<Job> GetAllJobs()
        {
            List<Job> Jobs = new List<Job>();

            DataTable dataBC = new DataTable();
            string queryBC = $"select * from BusinessClientJobs";

            DataTable dataIC = new DataTable();
            string queryIC = $"select * from IndividualClientJobs";

            try
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(queryBC, conn);
                adapter.Fill(dataBC);
                foreach (DataRow row in dataBC.Rows)
                {
                    Job BCjob = new Job();

                    BCjob.JobID = row["JobID"].ToString();
                    BCjob.Description = row["JobDescription"].ToString();
                    BCjob.Status = row["JobStatus"].ToString();
                    BCjob.Duration = int.Parse(row["JobDuration"].ToString());
                    BCjob.ClientID = row["CompanyID"].ToString();
                    BCjob.EmployeeID = row["EmployeeID"].ToString();
                    Jobs.Add(BCjob);
                }

                adapter = new SqlDataAdapter(queryIC, conn);
                adapter.Fill(dataIC);
                foreach (DataRow row in dataIC.Rows)
                {
                    Job ICjob = new Job();

                    ICjob.JobID = row["JobID"].ToString();
                    ICjob.Description = row["JobDescription"].ToString();
                    ICjob.Status = row["JobStatus"].ToString();
                    ICjob.Duration = int.Parse(row["JobDuration"].ToString());
                    ICjob.ClientID = row["ClientID"].ToString();
                    ICjob.EmployeeID = row["EmployeeID"].ToString();
                    Jobs.Add(ICjob);
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
            return Jobs;
        }
    }
}
