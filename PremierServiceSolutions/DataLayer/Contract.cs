using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PremierServiceSolutions
{
     class Contract
    {
        string contractID;
        string contractType;
        string contractDesc;
        double iPrice;
        double bPrice;
        bool contractAvailable;

        public string ContractID { get => contractID; set => contractID = value; }
        public string ContractType { get => contractType; set => contractType = value; }
        public string ContractDesc { get => contractDesc; set => contractDesc = value; }
        public double IPrice { get => iPrice; set => iPrice = value; }
        public double BPrice { get => bPrice; set => bPrice = value; }
        public bool ContractAvailable { get => contractAvailable; set => contractAvailable = value; }

        //string serviceLevel;



        public Contract(string contractID, string contractType,  string contractDesc, double iPrice, double bPrice) 
        {
            this.ContractID = contractID;
            this.ContractType = contractType;
            this.ContractDesc = contractType;
            this.IPrice = iPrice;
            this.BPrice = bPrice;
            //this.ServiceLevel = serviceLevel;
        }

        public Contract() { }

        //string contractId,contractType, serviceLevel, contractDescription;
        //double individualPrice, businessPrice;
        //bool available;

        //public string ContractId { get => contractId; set => contractId = value; }
        //public string ContractType { get => contractType; set => contractType = value; }
        //public string ServiceLevel { get => serviceLevel; set => serviceLevel = value; }
        //public string ContractDescription { get => contractDescription; set => contractDescription = value; }
        //public double IndividualPrice { get => individualPrice; set => individualPrice = value; }
        //public double BusinessPrice { get => businessPrice; set => businessPrice = value; }
        //public bool Available { get => available; set => available = value; }

        //public Contract(string contractId, string contractType, string contractDescription, double individualPrice, double businessPrice, string serviceLevel, bool available)
        //{
        //    this.ContractId = contractId;
        //    this.ContractType = contractType;
        //    this.ServiceLevel = serviceLevel;
        //    this.ContractDescription = contractDescription;
        //    this.IndividualPrice = individualPrice;
        //    this.BusinessPrice = businessPrice;
        //    this.Available = available;
        //}
        //public Contract()
        //{

        //}



    }
}
