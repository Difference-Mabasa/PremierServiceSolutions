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

        //list of all individual contracts
        //public List<Contract> GetContracts()
        //{
        //    List<Contract> contractList = new List<Contract>();
        //    try
        //    {
        //        string query = "select * From Contracts";
        //        SqlCommand cmd = new SqlCommand(query, conn);   
        //        SqlDataReader rdr = cmd.ExecuteReader();

        //        if (rdr.HasRows)
        //        {
        //            while (rdr.Read())
        //            {
        //                Contract c = new Contract();
        //                c.ContractID = rdr.GetString(0);
        //                c.ContractType = rdr.GetString(1);
        //                c.ContractDesc = rdr.GetString(2);
        //                c.IPrice = rdr.GetDouble(3);
        //                c.BPrice = rdr.GetDouble(4);
        //                c.ContractAvailable = rdr.GetBoolean(5);
        //                contractList.Add(c);
        //            }
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        MessageBox.Show($"cant get individual contract list {e.Message}");
        //    }
        //    return contractList;
        //}
        //list of all business contracts
        //public List<Contract> GetBusinessContracts()
        //{
        //    List<Contract> bContractList = new List<Contract>();
        //    try
        //    {
        //        string query = "select * From Contracts";
        //        SqlCommand cmd = new SqlCommand(query, conn);   
        //        SqlDataReader rdr = cmd.ExecuteReader();

        //        if (rdr.HasRows)
        //        {
        //            while (rdr.Read())
        //            {
        //                Contract c = new Contract();
        //                c.ContractType = rdr.GetString(0);
        //                c.ContractDesc = rdr.GetString(1);
        //                c.ContractPrice = rdr.GetDouble(2);
        //                BContractList.Add(c);
        //            }
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        MessageBox.Show($"cant get business contract list {e.Message}");
        //    }
        //    return BContractList;
        //} 

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
        public void InsertConract(Contract cont) 
        {

            try
            {
                conn.Open();
                string query = $"Insert Into Contracts(ContractID, ContractType, ContractDescription, IndividualPrice, BusinessPrice, ContractAvailable) values('{cont.ContractID}', '{cont.ContractType}', '{cont.ContractDesc}', '{cont.IPrice}', '{cont.BPrice}','{cont.ContractAvailable}')";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show($"Successfully Added Contract ");
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
