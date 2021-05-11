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

        //list of individual contracts
        public List<Contract> GetContacts()
        {
            ContractDAL dal = new ContractDAL();
            List<Contract> contracts =  dal.GetAllContracts();

            return contracts;
        }
        //list of business contracts
        //public void Bcontact()
        //{
        //     DataAccessLayer.ContractDAL contractDAL = new DataAccessLayer.ContractDAL();
        //    contractDAL.BusinessContracts();
        //}
       
        //update contract method to connect to update contract form
        public void UpdateContract(Contract cont)
        {
            ContractDAL contractDAL = new ContractDAL();
            contractDAL.UpdateContract(cont);
        }

        //public void NewIndividualContract(string contractID, string contractType, string contractDesc, double contractPrice, string serviceLevel)
        //{
        //    int cAvail = 50;

        //    if (contractType == "standard")
        //    {
        //        contractPrice = 700;
        //    }
        //    else if(contractType == "premium")
        //    {
        //        contractPrice = 1400;
        //    }
        //    if (cAvail > 0 && cAvail < 50)
        //    {
        //        contractAvailable = true;
        //        contract = new Contract(contractID, contractType, contractDesc, contractPrice, serviceLevel);
        //        //contractDAL.InsertContract(contractID, contractType, contractDesc, contractPrice, serviceLevel);
        //    }
        //    else 
        //    {
        //        contractAvailable = false;
        //        MessageBox.Show("failed to mak econtract");
        //    }
            
        //}
        //public void NewBusinessContract(string contractID, string contractType, string contractDesc, double contractPrice, string serviceLevel)
        //{

        //    if (contractType == "standard")
        //    {
        //        contractPrice = 1400;
        //    }
        //    else if (contractType == "premium")
        //    {
        //        contractPrice = 2800;
        //    }
            
        //    int cAvail = 50;
        //    if (cAvail > 0 && cAvail < 50)
        //    {
        //        contractAvailable = true;
        //        contract = new Contract(contractID, contractType, contractDesc, contractPrice, serviceLevel);
        //        //contractDAL.InsertContract(contractID, contractType, contractDesc, contractPrice, serviceLevel);
        //    }
        //    else
        //    {
        //        contractAvailable = false;
        //        MessageBox.Show("failed to mak econtract");
        //    }
        //}
        public void ViewAllContracts() 
        {
            List<Contract> contracts = new List<Contract>();

            foreach (Contract item in contractDAL.GetAllContracts())
            {
                contracts.Add(item);
            }
           
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
