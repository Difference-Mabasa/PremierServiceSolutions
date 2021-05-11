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

        private void lblContract_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Contract contract = new Contract(txtID.Text, txtName.Text, txtSurname.Text, decimal.Parse(txtPhone.Text), decimal.Parse(txtEmail.Text));
            BusinessLogicLayer.ContractBLL contractBLL = new BusinessLogicLayer.ContractBLL();
            contractBLL.AddContract(contract);
            
        }
    }
}
