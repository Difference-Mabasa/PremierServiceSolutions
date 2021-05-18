using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PremierServiceSolutions
{
    [Serializable]

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

        public string GenerateClientID()
        {
            Random rand = new Random();
            int letter = rand.Next(1, 3);

            string id = "";
            int upper = rand.Next(10000000, 100000000);

            switch (letter)
            {
                case 1:
                    id += 'D';
                    break;
                case 2:
                    id += 'E';
                    break;
               
            }

            id += Convert.ToString(upper);

            return id;
        }

        public void sendRequest()
        {
            throw new NotImplementedException();
        }
    }
}
