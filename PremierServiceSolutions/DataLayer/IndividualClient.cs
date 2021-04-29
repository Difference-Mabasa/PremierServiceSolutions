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

        public IndividualClient(string clientID) : base()
        {
            this.clientID = clientID;
        }

        public string clientID { get; set; }

        public override void Regiter()
        {
            try
            {
                IndividualClient client = new IndividualClient();
                client.clientID = this.clientID;
                client.Name = this.Name;
                client.Surname = this.Surname;
                client.Phone = this.Phone;
                client.Email = this.Email;
                client.AddressID = this.AddressID;
                client.ContractID = this.ContractID;

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
