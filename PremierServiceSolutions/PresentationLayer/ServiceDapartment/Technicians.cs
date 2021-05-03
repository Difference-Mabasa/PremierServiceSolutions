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
        Job myjob = new Job();

        public Technicians()
        {
            InitializeComponent();
        }

        private void Technicians_Load(object sender, EventArgs e)
        {
            EmployeeBLL emp = new EmployeeBLL();
            BusinessClientJobsBLL business = new BusinessClientJobsBLL();
            BindingSource source = new BindingSource();
            source.DataSource = business.GetAllJobs();
            dataGridView1.DataSource = source;
            BindingSource source1 = new BindingSource();
            source1.DataSource = emp.GetTechnicians();
            cbTech.DataSource =source1;
        }

        private void btnAllTech_Click(object sender, EventArgs e)
        {
            ServiceDapartment service = new ServiceDapartment();
            service.Show();
            service.OpenChildForm(new Schedule());
        }
        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        
        
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
                EmployeeBLL employee = new EmployeeBLL();
                BindingSource source2 = new BindingSource();
                source2.DataSource = employee.GetTechnicianDetails(jb);
                DGVTechDetails.DataSource = source2;
            }
        }
        private void btnAssign_Click(object sender, EventArgs e)
        {
            DBOperations operations = new DBOperations();
            operations.AssignTechnician(myjob);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
