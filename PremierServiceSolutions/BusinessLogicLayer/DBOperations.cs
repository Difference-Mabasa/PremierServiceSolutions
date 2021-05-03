using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using PremierServiceSolutions.DataAccessLayer;

namespace PremierServiceSolutions.BusinessLogicLayer
{
    class DBOperations
    {
        public void AssignTechnician(Job job)
        {
            if (job.ClientID.Contains("BC"))
            {
                BusinessClientJobsDAL business = new BusinessClientJobsDAL();
                business.UpdateBusinessClientJobTech(job);

            }
            else if (job.ClientID.Contains("IC"))
            {
                IndividualClientJobsDAL individual = new IndividualClientJobsDAL();
                individual.UpdateIndividualClientJobTech(job);
            }
            else
            {
                MessageBox.Show("Unable To assign Technician");
            }
        }
    }
}
