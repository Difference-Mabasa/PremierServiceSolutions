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

        public List<Job> GetIndividualClientJosbsByClientID(string id)
        {
            IndividualClientDAL clientData = new IndividualClientDAL();
            List<Job> jobs = clientData.GetIndividualClientJobByClientID(id);

            return jobs;

            List<String> a;
        }
        public void InsertIndividualClient(string clientID, string name, string surname, string phone, string email,
            string addressid, string contractId)
        {
            IndividualClient client = new IndividualClient();
            client.clientID = clientID;
            client.Name = name;
            client.Surname = surname;
            client.Phone = phone;
            client.Email = email;
            client.AddressID = addressid;
            client.ContractID = contractId;

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

        public void UpdateIndividualClient(string clientID, string name, string surname, string phone, string email,
            string addressid, string contractId)
        {
            IndividualClient client = new IndividualClient();
            client.clientID = clientID;
            client.Name = name;
            client.Surname = surname;
            client.Phone = phone;
            client.Email = email;
            client.AddressID = addressid;
            client.ContractID = contractId;

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
