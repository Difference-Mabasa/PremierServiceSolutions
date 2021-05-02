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

namespace PremierServiceSolutions.PresentationLayer.ServiceDapartment
{
    public partial class Technicians : Form
    {
        public Technicians()
        {
            InitializeComponent();
        }

        private void Technicians_Load(object sender, EventArgs e)
        {
            EmployeeBLL emp = new EmployeeBLL();
            BusinessClientJobsBLL business = new BusinessClientJobsBLL();
            BindingSource source = new BindingSource();
            source.DataSource = business.GetAllBusinessClientsJobs();
            dataGridView1.DataSource = source;
            BindingSource source1 = new BindingSource();
            source1.DataSource = emp.GetTechnicians();
            cbTech.DataSource =source1;
        }

        private void btnAllTech_Click(object sender, EventArgs e)
        {
            Schedule ss = new Schedule();
            ss.Show();
            this.Hide();
        }
        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        
        Job myjob=new Job();
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected == true)
            {
                Job jb = new Job();
                jb.JobID = dataGridView1.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                jb.ClientID = dataGridView1.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                jb.Duration = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[4].FormattedValue.ToString());
                jb.Description = dataGridView1.Rows[e.RowIndex].Cells[5].FormattedValue.ToString();
                jb.Status = dataGridView1.Rows[e.RowIndex].Cells[6].FormattedValue.ToString();
                jb.EmployeeID = dataGridView1.Rows[e.RowIndex].Cells[7].FormattedValue.ToString();
                jb.Technician = cbTech.Text;
                myjob = jb;
                MessageBox.Show(myjob.EmployeeID + ";" + myjob.Technician);
            }
        }
        private void btnAssign_Click(object sender, EventArgs e)
        {
            BusinessClientJobsBLL businessClient = new BusinessClientJobsBLL();
            businessClient.UpdateBusinessClientJobTech(myjob);
        }
    }
}
