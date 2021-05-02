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
            //needs Job ID
            BusinessClientJobsBLL add = new BusinessClientJobsBLL();
            Job job = new Job();
            job.ClientID = txtClientID.Text;
            job.Description = rtbdescrip.Text;
            job.Duration = int.Parse(txtdur.Text);
            job.Status = "0";
            //add.InsertBusinessClientJob(j);
        }
    }
}
