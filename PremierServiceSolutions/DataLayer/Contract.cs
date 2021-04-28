using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PremierServiceSolutions
{
    abstract class Contract
    {
        string contractId, serviceLevel;
        double price;

        public string ContractId { get => contractId; set => contractId = value; }
        public string ServiceLevel { get => serviceLevel; set => serviceLevel = value; } 
        public abstract double Price { get ; set; }
        //anything


    }
}
