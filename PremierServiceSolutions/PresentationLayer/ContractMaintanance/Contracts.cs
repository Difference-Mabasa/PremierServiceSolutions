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
    public partial class Contracts : Form
    {
       
        public Contracts()
        {
            InitializeComponent();
        }
       

        private void Contracts_Load(object sender, EventArgs e)
        {
            ContractBLL con = new ContractBLL();
            BindingSource source = new BindingSource();
            source.DataSource = con.GetContacts();
            dataGridView1.DataSource = source;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {       
            ContractMaintenance contracts = new ContractMaintenance();         
            contracts.OpenChildForm(new UpdateContract());
            this.Hide();
        }
    }
}
