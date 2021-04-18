using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PremierServiceSolutions
{
    abstract class Person
    {
        string name, surname, phone, email, addressID, contractID;

        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Email { get => email; set => email = value; }
        public string AddressID { get => addressID; set => addressID = value; }
        public string ContractID { get => contractID; set => contractID = value; }

        public abstract void Regiter();

        public abstract override string ToString();

    }
}
