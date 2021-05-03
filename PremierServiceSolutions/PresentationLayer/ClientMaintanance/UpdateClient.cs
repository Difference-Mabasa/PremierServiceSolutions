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
    public partial class UpdateClient : Form
    {
        public UpdateClient()
        {
            InitializeComponent();
        }

        private void btnUpdateIC_Click(object sender, EventArgs e)
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
                clientData.UpdateIndividualClient(client);

                MessageBox.Show("Individual Client Saved");
            }
            catch (Exception exp)
            {
                MessageBox.Show($"Error AddClient Form {exp.Message}");
            }
        }

        private void btnUpdateBC_Click(object sender, EventArgs e)
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
                clientData.UpdateBusinessClient(client);

                MessageBox.Show("Business Client Saved");
            }
            catch (Exception exp)
            {
                MessageBox.Show($"Error AddClient Form {exp.Message}");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ClientMaintenance maintanance = new ClientMaintenance();
            maintanance.Show();
            maintanance.OpenChildForm(new ClientDetails());
        }
    }
}
