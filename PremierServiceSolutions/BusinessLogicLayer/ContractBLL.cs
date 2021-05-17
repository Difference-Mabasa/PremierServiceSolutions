using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using PremierServiceSolutions.DataAccessLayer;

namespace PremierServiceSolutions.BusinessLogicLayer
{
    class ContractBLL
    {

      
        //list of individual contracts
        public List<Contract> GetContacts()
        {
            List<Contract> contracts = new List<Contract>();
            try
            {
                ContractDAL dal = new ContractDAL();
                contracts = dal.GetAllContracts();
            }
            catch (Exception e)
            {
                MessageBox.Show($"Error: {e.Message}");
            }
            return contracts;
        }
       
        //update contract method to connect to update contract form
        public void UpdateContract(Contract cont)
        {
            ContractDAL contractDAL = new ContractDAL();
            contractDAL.UpdateContract(cont);
        }

    
        public List<Contract> ViewAllContracts() 
        {
            List<Contract> contracts = new List<Contract>();
            ContractDAL contractDAL = new ContractDAL();
            try
            {
                contracts = contractDAL.GetAllContracts();
            }
            catch (Exception e)
            {
                MessageBox.Show($"Error: {e.Message}");
            }
            return contracts;
            
        }

        public void InsertContract(Contract con)
        {
            try
            {
                ContractDAL contracts = new ContractDAL();
                contracts.InsertConract(con);
            }
            catch (Exception e)
            {
                MessageBox.Show($"Error: {e.Message}");
            }
        }
    }
}
