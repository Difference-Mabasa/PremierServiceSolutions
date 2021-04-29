using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

            Call call = new Call();

            this.Hide();
            call.Show();
        }
    }
}
