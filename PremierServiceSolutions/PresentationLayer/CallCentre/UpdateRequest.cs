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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //this goes to the database

        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            //Drops the call

            frmCall call = new frmCall();

            this.Hide();
            call.Show();
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            
        }
    }
}
