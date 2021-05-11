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
        SqlConnection conn = DBAccess.GetSQLConnection();

        public void UpdateContract(Contract cont)
        {
            string query = $"update Contracts set ContractID = '{cont.ContractID}', ContractType = '{cont.ContractType}', ContractDescription = '{cont.ContractDesc}', IndividualPrice = '{cont.IPrice}', BusinessPrice = '{cont.BPrice}', ContractAvailable = '{cont.ContractAvailable}' where ContractID = '{cont.ContractID}'";
            
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader rdr = cmd.ExecuteReader();
                MessageBox.Show("Updated Contract Successfully");

            }
            catch (Exception e)
            {
                MessageBox.Show("Error on Contracts : "+e.Message);
            }
        }

        public List<string> ViewServices()
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
            return services;
        }
        public void InsertContract(Contract cont) 
        {

            try
            {
                string query = $"Insert Into Contracts(ContractID, ContractType, ContractDescription, IndividualPrice, BusinessPrice, ContractAvailable) Values('{cont.ContractID}', '{cont.ContractType}', '{cont.ContractDesc}', '{cont.IPrice}', '{cont.BPrice}','{cont.ContractAvailable}')";
                SqlCommand cmd = new SqlCommand(query, conn);

            }
            catch (Exception e)
            {
                MessageBox.Show($"ERROR: {e.Message}");
            }

        }

        public List<Contract> GetAllContracts()
        {
            List<Contract> allContracts = new List<Contract>();
            try
            {
                conn.Open();
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
                        c.IPrice = rdr.GetDecimal(3);
                        c.BPrice = rdr.GetDecimal(4);
                        c.ContractAvailable = rdr.GetBoolean(5);
                        allContracts.Add(c);
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show($"Error on ContractDAL {e.Message}");
            }
            finally
            {
                conn.Close();
            }
            return allContracts;
        }
    }
}
