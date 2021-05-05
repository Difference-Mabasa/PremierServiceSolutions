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

            bc = business.GetBusinessClientByID(txtSearchClient.Text);
            txtID.Text = bc.clientID;
            txtName.Text = bc.CompanyName;
            txtPhone.Text = bc.Phone;
            txtEmail.Text = bc.Email;
            txtAddress.Text = bc.AddressID;
            txtContract.Text = bc.ContractID;

            ic = individual.GetIndividualClientByID(txtSearchClient.Text);
            txtID.Text = ic.clientID;
            txtName.Text = ic.Name;
            txtSurname.Text = ic.Surname;
            txtPhone.Text = ic.Phone;
            txtEmail.Text = ic.Email;
            txtAddress.Text = ic.AddressID;
            txtContract.Text = ic.ContractID;


        }

        private void btnViewAll_Click(object sender, EventArgs e)
        {
            
        }
    }
}
