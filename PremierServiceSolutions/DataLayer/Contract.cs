using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PremierServiceSolutions
{
    abstract class Contract
    {
        string contractId,contractType, serviceLevel, contractDescription;
        double price;
        bool available;

        public string ContractId { get => contractId; set => contractId = value; }
        public string ContractType { get => contractType; set => contractType = value; }
        public string ServiceLevel { get => serviceLevel; set => serviceLevel = value; }
        public string ContractDescription { get => contractDescription; set => contractDescription = value; }
        public double Price { get => price; set => price = value; }
        public bool Available { get => available; set => available = value; }

        protected Contract(string contractId, string contractType, string serviceLevel, string contractDescription, double price, bool available)
        {
            ContractId = contractId;
            ContractType = contractType;
            ServiceLevel = serviceLevel;
            ContractDescription = contractDescription;
            Price = price;
            Available = available;
        }
        protected Contract()
        {

        }

        //anything


    }
}
