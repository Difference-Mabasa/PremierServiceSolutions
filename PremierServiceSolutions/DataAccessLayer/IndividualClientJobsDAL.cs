﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace PremierServiceSolutions.DataAccessLayer
{
    class IndividualClientJobsDAL
    {
        SqlConnection conn = new SqlConnection("Server= (local); Database = PremierServiceSolutionsDB; Trusted_Connection = true");

        public List<Job> GetIndividualClientJobsByClientID(string id)
        {
            List<Job> jobs = new List<Job>();
            Job clientJob = new Job();
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

        public void InsertIndividualClientJob(Job job)
        {
            string query = $"insert into IndividualClientJobs values" +
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

        public void UpdateIndividualClientJob(Job job)
        {
            string query = $"update IndividualClientJobs set" +
                $"JobID = '{job.JobID}', " +
                $"JobDescription = '{job.Description}', " +
                $"JobStatus = '{job.Status}', " +
                $"JobDuration = '{job.Duration}', " +
                $"ClientID = {job.ClientID}, " +
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

        public List<Job> GetAllIndividualJobs()
        {
            List<Job> ICJobs = new List<Job>();

            DataTable datatable = new DataTable();
            string query = $"select * from IndividualClientJobs"; 

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

        public void UpdateIndividualClientJobTech(Job job)
        {
            string query = $"update IndividualClientJobs set " +
                $"JobDescription = '{job.Description}', " +
                $"JobStatus = '{job.Status}', " +
                $"JobDuration = '{job.Duration}', " +
                $"ClientID = '{job.ClientID}', " +
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
    }
}
