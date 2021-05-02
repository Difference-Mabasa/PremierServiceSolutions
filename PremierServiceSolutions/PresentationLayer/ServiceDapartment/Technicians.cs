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
            BusinessClientBLL business = new BusinessClientBLL();
            BindingSource source = new BindingSource();
            source.DataSource = business.GetAllBusinessClientsJobs();
            dataGridView1.DataSource = source;
        }

        private void btnAllTech_Click(object sender, EventArgs e)
        {
            Schedule ss = new Schedule();
            ss.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected==true)
            {
                Job jb = new Job();
                jb.JobID = dataGridView1.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                jb.ClientID = dataGridView1.Rows[e.RowIndex].Cells[1].FormattedValue.ToString(); 
                jb.Duration = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[4].FormattedValue.ToString()); 
                jb.Description = dataGridView1.Rows[e.RowIndex].Cells[5].FormattedValue.ToString(); 
                jb.Status = dataGridView1.Rows[e.RowIndex].Cells[6].FormattedValue.ToString();
                jb.EmployeeID = dataGridView1.Rows[e.RowIndex].Cells[7].FormattedValue.ToString();
                jb.Technician = cbTech.Text;
                MessageBox.Show(jb.Technician);
            }
        }

        private void btnAssign_Click(object sender, EventArgs e)
        {

        }
    }
}
