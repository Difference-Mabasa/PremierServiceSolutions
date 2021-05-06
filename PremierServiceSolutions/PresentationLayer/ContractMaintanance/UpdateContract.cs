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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Contract contract = new Contract();
            BusinessLogicLayer.ContractBLL contractBLL = new BusinessLogicLayer.ContractBLL();

            contract.ContractID = txtID.Text;
            contract.ContractType = txtName.Text;
            contract.ContractDesc = txtSurname.Text;
            contract.IPrice = decimal.Parse(txtPhone.Text);
            contract.BPrice = decimal.Parse(txtEmail.Text);
            //contract.ContractAvailable = bool.Parse(txtContract.Text);
            contractBLL.UpdateContract(contract);
        }
    }
}
