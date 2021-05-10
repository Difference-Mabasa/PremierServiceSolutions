using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PremierServiceSolutions.DataAccessLayer;

namespace PremierServiceSolutions.BusinessLogicLayer
{
    class BusinessClientJobsBLL
    {
        public List<Job> GetBusinessClientJobByClientID(string id)
        {
            List<Job> jobs = new List<Job>();
            try
            {
                BusinessClientJobsDAL clientData = new BusinessClientJobsDAL();
                jobs = clientData.GetBusinessClientJobsByClientID(id);
            }
            catch (Exception e)
            {
                MessageBox.Show($"Error: {e.Message}");
            }

            return jobs;
        }

        public void InsertBusinessClientJob(Job job)
        {
            try
            {
                BusinessClientJobsDAL clientData = new BusinessClientJobsDAL();
                clientData.InsertBusinessClientJob(job);
            }
            catch (Exception e)
            {
                MessageBox.Show($"Error: {e.Message}");
            }
        }

        public void UpdateBusinessClientJob(Job job)
        {
            try
            {
                BusinessClientJobsDAL clientData = new BusinessClientJobsDAL();
                clientData.UpdateBusinessClientJob(job);
            }
            catch (Exception e)
            {
                MessageBox.Show($"Error: {e.Message}");
            }
        }

        public void UpdateBusinessClientJobTech(Job job)
        {
            try
            {
                BusinessClientJobsDAL clientData = new BusinessClientJobsDAL();
                clientData.UpdateBusinessClientJobTech(job);
            }
            catch (Exception e)
            {
                MessageBox.Show($"Error: {e.Message}");
            }
        }


        public List<Job> GetAllBusinessClientsJobs()
        {
            List<Job> jobs = new List<Job>();
            try
            {
                BusinessClientDAL getClients = new BusinessClientDAL();
                jobs = getClients.GetAllBusinessJobs();
            }
            catch (Exception e)
            {
                MessageBox.Show($"Error on Business Client Jobs {e.Message}");
            }
            return jobs;
        }

        

    }
}
