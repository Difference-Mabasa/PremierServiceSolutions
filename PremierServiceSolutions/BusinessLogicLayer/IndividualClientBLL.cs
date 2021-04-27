using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PremierServiceSolutions.DataAccessLayer;

namespace PremierServiceSolutions.BusinessLogicLayer
{
    class IndividualClientBLL
    {
        public IndividualClient GetIndividualClientByID(string id)
        {

            IndividualClientDAL clientData = new IndividualClientDAL();
            IndividualClient client = clientData.SearchIndividualClientByID(id);

            return client;
        }

        //public List<Job> GetIndividualClientJosbsByClientID(string id)
        //{
        //    IndividualClientDAL clientData = new IndividualClientDAL();
        //    List<Job> jobs = clientData.GetIndividualClientJobByClientID(id);

        //    return jobs;

        //    List<String> a;
        //}
        public void InsertIndividualClient(IndividualClient client)
        {
            try
            {
                IndividualClientDAL clientData = new IndividualClientDAL();
                clientData.InsertIndividualClient(client);
            }
            catch (Exception e)
            {
                MessageBox.Show($"Error: {e.Message}");
            }


        }

        public void UpdateIndividualClient(IndividualClient client)
        {
            try
            {
                IndividualClientDAL clientData = new IndividualClientDAL();
                clientData.UpdateIndividualClient(client);
            }
            catch (Exception e)
            {
                MessageBox.Show($"Error: {e.Message}");
            }


        }
    }
}
