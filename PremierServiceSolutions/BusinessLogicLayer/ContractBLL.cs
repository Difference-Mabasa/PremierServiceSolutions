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
        bool contractAvailable;
        Contract contract = new Contract();
        DataAccessLayer.ContractDAL contractDAL = new DataAccessLayer.ContractDAL();

        //insert contracts
        public void AddContract(Contract cont) 
        {
            ContractDAL contractDAL = new ContractDAL();
            contractDAL.InsertContract(cont);
        }
        
        //list of individual contracts
        public List<Contract> GetContacts()
        {
            ContractDAL dal = new ContractDAL();
            List<Contract> contracts =  dal.GetAllContracts();

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

            foreach (Contract item in contractDAL.GetAllContracts())
            {
                contracts.Add(item);
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
