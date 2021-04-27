using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PremierServiceSolutions.BusinessLogicLayer;

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
            try
            {
                IndividualClient client = new IndividualClient();
                this.clientID = client.clientID;
                this.Name = client.Name;
                this.Surname = client.Surname;
                this.Phone = client.Phone;
                this.Email = client.Email;
                this.AddressID = client.AddressID;
                this.ContractID = client.ContractID;

                IndividualClientBLL individualData = new IndividualClientBLL();
                individualData.InsertIndividualClient(client);
            }
            catch(Exception e)
            {
                MessageBox.Show($"Error on IndividualClient class : {e.Message}");
            }
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
