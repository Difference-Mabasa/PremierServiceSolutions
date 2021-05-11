using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PremierServiceSolutions.BusinessLogicLayer;

namespace PremierServiceSolutions.PresentationLayer.ContractMaintanance
{
    public partial class AddContracts : Form
    {
        public AddContracts()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Contract con = new Contract();
            con.ContractID = txtID.Text;
            con.ContractType = txtType.Text;
            con.ContractDesc = txtDescrip.Text;
            con.IPrice = decimal.Parse(txtIndivP.Text);
            con.BPrice = decimal.Parse(txtBusinessPrice.Text);
            ContractBLL contract = new ContractBLL();
            contract.InsertContract(con);
        }
    }
}
