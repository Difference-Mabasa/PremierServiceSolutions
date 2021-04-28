using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

using PremierServiceSolutions.DataAccessLayer;

namespace PremierServiceSolutions.BusinessLogicLayer
{
    class IndividualClientBLL
    {
        public List<IndividualClient> GetAllIndividualClients()
        {
            List<IndividualClient> iClient = new List<IndividualClient>();
            try
            {
                IndividualClientDAL getClients = new IndividualClientDAL();
                iClient = getClients.GetAllIndividualClients();
            }
            catch (Exception e)
            {
                MessageBox.Show($"Error on IndividulaClientBusinessLayer {e.Message}");
            }
            return iClient;
        }
        public IndividualClient GetIndividualClientByID(string id)
        {

            IndividualClientDAL clientData = new IndividualClientDAL();
            IndividualClient client = clientData.SearchIndividualClientByID(id);

            return client;
        }

        public DataTable GetAllIndividualClients()
        {
            IndividualClientDAL clientData = new IndividualClientDAL();
            DataTable table;
            table = clientData.GetAllIndividualClients();

            return table;
        }

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

        public int CountIndividualClients()
        {
            int total = 0;

            try
            {
                IndividualClientDAL dal = new IndividualClientDAL();
                total = dal.CountIndividualClients();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }
            

            return total;
        }
    }
}
