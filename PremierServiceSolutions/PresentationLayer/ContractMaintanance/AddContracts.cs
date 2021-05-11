using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PremierServiceSolutions.PresentationLayer.ContractMaintanance
{
    public partial class AddContracts : Form
    {
        public AddContracts()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ContractMaintenance maintanance = new ContractMaintenance();
            maintanance.Show();
            maintanance.OpenChildForm(new Contracts());
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }
    }
}
