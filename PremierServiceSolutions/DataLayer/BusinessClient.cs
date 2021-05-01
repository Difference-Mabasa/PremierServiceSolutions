using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PremierServiceSolutions
{
    class BusinessClient : IClient
    {
        String companyName, phone, email, addressID, contractID;

        public BusinessClient() { }

        public string clientID { get; set ; }
        public string CompanyName { get => companyName; set => companyName = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Email { get => email; set => email = value; }
        public string AddressID { get => addressID; set => addressID = value; }
        public string ContractID { get => contractID; set => contractID = value; }

        public void sendRequest()
        {
            throw new NotImplementedException();
        }
    }
}
