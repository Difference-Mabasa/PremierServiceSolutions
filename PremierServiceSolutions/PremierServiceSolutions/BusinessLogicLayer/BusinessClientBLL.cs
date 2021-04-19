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

        public void InsertBusinessClient(string clientID, string companyName, string phone, string email, string addressid, string contractId)
        {
            BusinessClient client = new BusinessClient();
            client.clientID = clientID;
            client.CompanyName = companyName;
            client.Phone = phone;
            client.Email = email;
            client.AddressID = addressid;
            client.ContractID = contractId;

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

        public void UpdateBusinessClient(string clientID, string companyName, string phone, string email, string addressid, string contractId)
        {
            BusinessClient client = new BusinessClient();
            client.clientID = clientID;
            client.CompanyName = companyName;
            client.Phone = phone;
            client.Email = email;
            client.AddressID = addressid;
            client.ContractID = contractId;
            try
            {
                BusinessClientDAL clientData = new BusinessClientDAL();
                clientData.UpdateBusinessClient(client);
            }
            catch (Exception e)
            {
                MessageBox.Show($"Error: {e.Message}");
            }

        }
    }
}
