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
        SqlConnection conn = new SqlConnection("Server= BAVHU\\SQLEXPRESS; Database = PremierServiceSolutionsDB; Trusted_Connection = true");
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
                        c.ContractId = rdr.GetString(0);
                        c.ContractType = rdr.GetString(1);
                        c.ContractDescription = rdr.GetString(2);
                        c.IndividualPrice = rdr.GetDouble(3);
                        c.BusinessPrice = rdr.GetDouble(4);
                        c.ServiceLevel = rdr.GetString(5);
                        c.Available = rdr.GetBoolean(6);
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
