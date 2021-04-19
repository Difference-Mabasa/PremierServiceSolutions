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
                jobs = clientData.GetBusinessClientJobByClientID(id);
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
    }
}
