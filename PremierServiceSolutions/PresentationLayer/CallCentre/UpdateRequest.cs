using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using PremierServiceSolutions.BusinessLogicLayer;

namespace PremierServiceSolutions.PresentationLayer.CallCentre
{
    public partial class UpdateRequest : Form
    {
        public UpdateRequest()
        {
            InitializeComponent();
        }

        BindingSource source = new BindingSource();
        BusinessClientBLL business = new BusinessClientBLL();
        IndividualClientBLL individual = new IndividualClientBLL();
        IndividualClient ic = new IndividualClient();
        BusinessClient bc = new BusinessClient();
        DBOperations DB = new DBOperations();

        private void btnEnd_Click(object sender, EventArgs e)
        {
            CallCentre call = new CallCentre();
            call.Show();
            call.OpenChildForm(new ClientDetails());
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            BusinessClientJobsBLL busiJob = new BusinessClientJobsBLL();
            IndividualClientJobsBLL indiJob = new IndividualClientJobsBLL();
            Job job = new Job();
            job.ClientID = lblID.Text;
            job.Status = txtStatus.Text;
            job.Duration = int.Parse(txtDuration.Text);
            job.Description = rtbdescrip.Text;
            job.Status = "0";
            //Checking if it is a business or individual client
            if (job.ClientID.Contains('I'))
            {
                indiJob.UpdateIndividualClientJob(job);
            }
            else
            {
                busiJob.UpdateBusinessClientJob(job);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string id = txtSearchClient.Text;
            //searches client using client id
            if (id.Contains("I"))
            {
                ic = individual.GetIndividualClientByID(txtSearchClient.Text);
                lblID.Text = ic.clientID;
                lblClientName.Text = (ic.Name + " " + ic.Surname);              
            }
            else
            {
                bc = business.GetBusinessClientByID(txtSearchClient.Text);
                lblID.Text = bc.clientID;
                lblClientName.Text = bc.CompanyName;
            }

            //display client previous requests
            if (id.Contains("I"))
            {
                IndividualClientJobsBLL data = new IndividualClientJobsBLL();
                List<Job> clientJobs = data.GetIndividualClientJobByClientID(id);

                BindingSource source2 = new BindingSource();
                source2.DataSource = clientJobs;

                dgvPreviousRequests.DataSource = source2;
            }
            else
            {
                BusinessClientJobsBLL data = new BusinessClientJobsBLL();
                List<Job> clientJobs = data.GetBusinessClientJobByClientID(id);

                BindingSource source2 = new BindingSource();
                source2.DataSource = clientJobs;

                dgvPreviousRequests.DataSource = source2;
            }
           




        }

        private void dgvPreviousRequests_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            DataGridViewRow row = dgvPreviousRequests.Rows[rowIndex];

            txtStatus.Text = row.Cells[5].Value.ToString();
            txtDuration.Text = row.Cells[3].Value.ToString();
            rtbdescrip.Text = row.Cells[4].Value.ToString();

        }

        private void UpdateRequest_Load(object sender, EventArgs e)
        {

        }
    }
}
