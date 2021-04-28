using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PremierServiceSolutions
{
    abstract class Contract
    {
        string contractId;
        double price;

        public string ContractId { get => contractId; set => contractId = value; }
        public abstract double Price { get ; set; }

        //anything


    }
}
