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
    public partial class ClientDetails : Form
    {
        BindingSource source = new BindingSource();
        BusinessClientBLL business = new BusinessClientBLL();
        IndividualClientBLL individual = new IndividualClientBLL();
        IndividualClient ic = new IndividualClient();
        BusinessClient bc = new BusinessClient();
        DBOperations DB = new DBOperations();
        
        
        public ClientDetails()
        {
            InitializeComponent();
        }

        private void ClientDetails_Load(object sender, EventArgs e)
        {
            DBOperations db = new DBOperations();
            db.ViewAllClients(dgvIndividualClients, dgvBusinessClients);


        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearchClient.Text.Contains("I"))
            {
                ic = individual.GetIndividualClientByID(txtSearchClient.Text);
                lblClientID.Text = ic.clientID;
                lblName.Text = ic.Name;
                lblSurname.Text = ic.Surname;
                lblPhone.Text = ic.Phone;
                lblEmail.Text = ic.Email;
                lblAddress.Text = ic.AddressID;
                lblContract.Text = ic.ContractID;
            }
            else
            {
                bc = business.GetBusinessClientByID(txtSearchClient.Text);
                lblClientID.Text = bc.clientID;
                lblName.Text = bc.CompanyName;
                lblPhone.Text = bc.Phone;
                lblEmail.Text = bc.Email;
                lblAddress.Text = bc.AddressID;
                lblContract.Text = bc.ContractID;
            }
        }

        private void btnViewAll_Click(object sender, EventArgs e)
        {
            
        }
    }
}
