using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PremierServiceSolutions
{
    class BasicContract : Contract
    {
        //Set price

        public BasicContract(string contractId, string contractType, string serviceLevel, string contractDescription, double price, bool available) : base(contractId, contractType, serviceLevel, contractDescription, price, available)
        {
            this.ContractId = contractId;
            this.ContractType = contractType;
            this.ServiceLevel = serviceLevel;
            this.ContractDescription = contractDescription;
            this.Price = price;
            this.Available = available;
        }
        public BasicContract()
        {

        }

    }
}
