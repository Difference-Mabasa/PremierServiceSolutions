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

namespace PremierServiceSolutions.PresentationLayer.CallCentre
{
    public partial class ClientDetails : Form
    {
        public ClientDetails()
        {
            InitializeComponent();
        }

        private void txtSearchClient_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPhone_Click(object sender, EventArgs e)
        {
            //chec
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //drops the call

            Call call = new Call();

            this.Hide();
            call.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //allows to search the database for a client
            string id = txtSearchClient.Text;
            IndividualClientBLL bll = new IndividualClientBLL();

            IndividualClient ic = bll.GetIndividualClientByID(id);

            BindingSource source = new BindingSource();
            source.Add(ic);

            dgvClientDetails.DataSource = source;
        }

        private void dgvClientDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvPreviousRequest_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //request update
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //adding a request
        }
    }
}
