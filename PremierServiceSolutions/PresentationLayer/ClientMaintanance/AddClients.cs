using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PremierServiceSolutions.BusinessLogicLayer;

namespace PremierServiceSolutions.PresentationLayer.ClientMaintanance
{
    public partial class AddClients : Form
    {
        public AddClients()
        {
            InitializeComponent();
        }

        private void AddClients_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAddIC_Click(object sender, EventArgs e)
        {
            try
            {
                IndividualClientBLL clientData = new IndividualClientBLL();
                IndividualClient client = new IndividualClient();
                client.clientID = txtID.Text;
                client.Name = txtName.Text;
                client.Surname = txtSurname.Text;
                client.Phone = txtPhone.Text;
                client.Email = txtEmail.Text;
                client.AddressID = txtAddress.Text;
                client.ContractID = txtContract.Text;
                clientData.InsertIndividualClient(client);
            }
            catch(Exception exp)
            {
                MessageBox.Show($"Error AddClient Form {exp.Message}");
            }
        }

        private void btnAddBC_Click(object sender, EventArgs e)
        {
            try
            {
                BusinessClientBLL clientData = new BusinessClientBLL();
                BusinessClient client = new BusinessClient();
                client.clientID = txtID.Text;
                client.CompanyName = txtName.Text;
                client.Phone = txtPhone.Text;
                client.Email = txtEmail.Text;
                client.AddressID = txtAddress.Text;
                client.ContractID = txtContract.Text;
                clientData.InsertBusinessClient(client);
            }
            catch (Exception exp)
            {
                MessageBox.Show($"Error AddClient Form {exp.Message}");
            }
        }
    }
}
