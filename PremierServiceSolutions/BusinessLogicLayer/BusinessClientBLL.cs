using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PremierServiceSolutions.DataAccessLayer;

namespace PremierServiceSolutions.BusinessLogicLayer
{
    class BusinessClientBLL
    {
        public BusinessClient GetBusinessClientByID(string id)
        {
            BusinessClientDAL clientData = new BusinessClientDAL();
            BusinessClient client = clientData.SearchBusinessClientByID(id);

            return client;
        }

        public List<Job> GetBusinessClientJosbsByClientID(string id)
        {
            BusinessClientDAL clientData = new BusinessClientDAL();
            List<Job> jobs = clientData.GetBusinessClientJobByClientID(id);

            return jobs;

        }

        public void InsertIndividualClient(BusinessClient client)
        {
            try
            {
                BusinessClientDAL clientData = new BusinessClientDAL();
                clientData.InsertBusinessClient(client);
            }
            catch (Exception e)
            {
                MessageBox.Show($"Error: {e.Message}");
            }


        }

        public void UpdateIndividualClient(BusinessClient client)
        {
            try
            {
                BusinessClientDAL clientData = new BusinessClientDAL();
                clientData.InsertBusinessClient(client);
            }
            catch (Exception e)
            {
                MessageBox.Show($"Error: {e.Message}");
            }


        }
    }
}
