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
            List<Contract> lst = new List<Contract>();
            lst = con.GetContacts();
            source.DataSource = lst;
            dataGridView1.DataSource = source;
            List<string> package = new List<string>();
            foreach (Contract contract in lst)
            {
                package.Add(contract.ContractType);
            }
            cmbPackage.DataSource = package;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {       
            ContractMaintenance contracts = new ContractMaintenance();         
            contracts.OpenChildForm(new UpdateContract());
            this.Hide();
        }

        private void btnIndividual_Click(object sender, EventArgs e)
        {
            ContractBLL contractBLL = new ContractBLL();
            

            BindingSource binder = new BindingSource();
            binder.DataSource = contractBLL.ViewAllContracts();
            dataGridView1.DataSource = binder;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddContracts addContracts = new AddContracts();
            addContracts.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
