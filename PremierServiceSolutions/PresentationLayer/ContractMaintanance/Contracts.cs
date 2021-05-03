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
    public partial class Contracts : Form
    {
       
        public Contracts()
        {
            InitializeComponent();
        }
       

        private void Contracts_Load(object sender, EventArgs e)
        {           
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {       
            ContractMaintenance contracts = new ContractMaintenance();         
            contracts.OpenChildForm(new UpdateContract());
            this.Hide();
        }
    }
}
