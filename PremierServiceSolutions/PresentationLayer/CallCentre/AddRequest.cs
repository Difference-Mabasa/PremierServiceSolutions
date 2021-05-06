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
    public partial class AddRequest : Form
    {
        public AddRequest()
        {
            InitializeComponent();
        }

        private void AddRequest_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ////Needs to cater for both business and Individual Clients
            //BusinessClientJobsBLL add = new BusinessClientJobsBLL();
            //Job job = new Job();
            //job.ClientID = txtClientID.Text;
            //job.Description = rtbdescrip.Text;
            //job.Duration = int.Parse(txtdur.Text);
            //job.Status = "0";
            //job.JobID = txtJobId.Text;
            //add.InsertBusinessClientJob(job);
            BusinessClientJobsBLL busiJob = new BusinessClientJobsBLL();
            IndividualClientJobsBLL indiJob = new IndividualClientJobsBLL();
            Job job = new Job();
            job.ClientID = txtClientID.Text;
            job.JobID = txtJobId.Text;
            job.Duration = int.Parse(txtdur.Text);
            job.Description = rtbdescrip.Text;
            job.Status = "0";
            //Checking if it is a business or individual client
            if (job.ClientID.Contains('I'))
            {
                indiJob.InsertIndividualClientJob(job);
            }
            else
            {
                busiJob.InsertBusinessClientJob(job);
            }
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            ObjectSerializer serializer = new ObjectSerializer();
            Call call = serializer.DeSerializeCall();
            call.EndCall();

            if (call.ClientID.Contains("I"))
            {
                IndividualClientCallReportsBLL report = new IndividualClientCallReportsBLL();
                report.InsertIndividualCallReport(call);
            }

            else if (call.ClientID.Contains("B"))
            {
                BusinessClientCallReportsBLL report = new BusinessClientCallReportsBLL();
                report.InsertBusinessCallReport(call);
            }
        }
    }
}
