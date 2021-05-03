using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PremierServiceSolutions.DataAccessLayer
{
    class ContractDAL
    {
        SqlConnection conn = new SqlConnection("Server= (local); Database = PremierServiceSolutionsDB; Trusted_Connection = true");

        public void ViewServices()
        {
            List<string> services = new List<string>();
            try
            {
                string query = "SELECT * FROM ServicesOff";
                SqlCommand cmd = new SqlCommand(query, conn);   
                SqlDataReader rdr = cmd.ExecuteReader();

                if (rdr.HasRows)
                {
                    while (rdr.Read())
                    {
                        services.Add(rdr.ToString());
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Unable to view services");
            }
        }
        public void InserctConract(string contractID, string contractType, string contractDesc, double contractPrice, string serviceLevel) 
        {
            string id = contractID;
            string type = contractType;
            double price = contractPrice;
            string level = serviceLevel;

            try
            {
                string query = $"Insert Into Contracts(ontractID, ContractType, ContractDesc, ContractPrice, ServiceLevel) Values({0}, {1}, {2}, {3}, {4});, id, type, price, level";
                SqlCommand cmd = new SqlCommand(query, conn);

            }
            catch (Exception e)
            {
                MessageBox.Show($"Contract not inserted");
            }

        }

        public List<Contract> GetAllContracts()
        {
            List<Contract> allContracts = new List<Contract>();
            try
            {
                string query = "SELECT * FROM contracts";
                SqlCommand cmd = new SqlCommand(query, conn);   
                SqlDataReader rdr = cmd.ExecuteReader();

                if (rdr.HasRows)
                {
                    while (rdr.Read())
                    {
                        Contract c = new Contract();
                        c.ContractID = rdr.GetString(0);
                        c.ContractType = rdr.GetString(1);
                        c.ContractDesc = rdr.GetString(2);
                        c.ContractPrice = rdr.GetDouble(3);
                        c.ServiceLevel = rdr.GetString(5);
                        allContracts.Add(c);
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show($"Error on ContractDAL {e.Message}");
            }
            return allContracts;
        }
    }
}
