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
        double contractPrice;
        bool contractAvailable;
        string serviceLevel;

        public string ContractID { get; set; }
        public string ContractType{ get; set;}
        public string ContractDesc { get; set; }
        public double ContractPrice { get; set; }
        public string ServiceLevel { get; set; }

        public Contract(string contractID, string contractType,  string contractDesc, double contractPrice, string serviceLevel) 
        {
            this.ContractID = contractID;
            this.ContractType = contractType;
            this.ContractDesc = contractType;
            this.ContractPrice = contractPrice;
            this.ServiceLevel = serviceLevel;
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
