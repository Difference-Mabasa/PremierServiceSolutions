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
    class BusinessClientBLL
    {

        public DataTable GetAllBusinessClients() 
        {
            DataTable table;
            BusinessClientDAL businessClientDAL = new BusinessClientDAL();
            table = businessClientDAL.GetAllBusinessClients();

            return table;
           
        }

        public BusinessClient GetBusinessClientByID(string id)
        {
            BusinessClientDAL clientData = new BusinessClientDAL();
            BusinessClient client = clientData.SearchBusinessClientByID(id);

            return client;
        }

        

        public void InsertBusinessClient(BusinessClient client)
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

        public void UpdateBusinessClient(BusinessClient client)
        {
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
