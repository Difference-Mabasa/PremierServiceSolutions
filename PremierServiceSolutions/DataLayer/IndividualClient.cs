using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PremierServiceSolutions
{
    class IndividualClient : Person, IClient
    {

        public IndividualClient() { }

        public IndividualClient(string clientID, string serviceLevel) : base()
        {
            this.clientID = clientID;
            this.serviceLevel = serviceLevel;
        }

        public string clientID { get; set; }
        public string serviceLevel { get;set; }

        public override void Regiter()
        {
            throw new NotImplementedException();
        }

        public void sendRequest()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }
}
