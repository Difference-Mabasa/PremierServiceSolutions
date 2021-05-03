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

        public List<Object> AllClients()
        {
            List<Object> obj = new List<Object>();
            IndividualClientDAL indiData = new IndividualClientDAL();
            BusinessClientDAL busiData = new BusinessClientDAL();
            List<IndividualClient> individual = indiData.GetAllIndividualClients();
            List<BusinessClient> business = busiData.GetAllBusinessClients();
            obj.Add(individual);
            obj.Add(business);
            return obj;

        }

    }
}
