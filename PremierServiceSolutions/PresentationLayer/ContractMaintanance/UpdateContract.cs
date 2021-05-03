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
    public partial class UpdateContract : Form
    {
        public UpdateContract()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ContractMaintenance contracts = new ContractMaintenance();
            contracts.Show();
            contracts.OpenChildForm(new Contracts());
        }
    }
}
