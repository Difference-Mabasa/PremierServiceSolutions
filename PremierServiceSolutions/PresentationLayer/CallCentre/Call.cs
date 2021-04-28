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
    public partial class Call : Form
    {
        public Call()
        {
            InitializeComponent();
        }

        private void btnAcceptCall_Click(object sender, EventArgs e)
        {
            this.Hide();
            ClientDetails frm = new ClientDetails();
            frm.Show();
        }

        private void Call_Load(object sender, EventArgs e)
        {
            //Randomize call
            

        }
    }
}
