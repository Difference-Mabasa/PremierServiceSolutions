using PremierServiceSolutions.BusinessLogicLayer;
using PremierServiceSolutions.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PremierServiceSolutions.PresentationLayer.ServiceDapartment
{
    public partial class JobTracking : Form
    {
        public JobTracking()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Technicians technicians = new Technicians();

            this.Hide();
            technicians.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this will populate the datagridview accordingily

            if (button1.Text == "Individuals")
            {
                button1.Text = "Business";
                //call method
                Individual();

            }
            else if (button1.Text == "Business")
            {
                button1.Text = "All";
                //call method
                Business();
            }
            else
            {
                button1.Text = "Individuals";
                //call method
                ALL();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            IndividualClientJobsBLL indiv = new IndividualClientJobsBLL();
            BusinessClientJobsBLL busin = new BusinessClientJobsBLL();

             DataGridViewRow row = dataGridView1.Rows[rowindexa];

            Job jobb = new Job();

            jobb.JobID = row.Cells[0].Value.ToString();
            jobb.ClientID = row.Cells[1].Value.ToString();
            jobb.Technician = row.Cells[2].Value.ToString();
            jobb.Finished = bool.Parse(row.Cells[3].Value.ToString());
            jobb.Duration = int.Parse(row.Cells[4].Value.ToString());
            jobb.Description = row.Cells[5].Value.ToString();
            jobb.Status = row.Cells[6].Value.ToString();
            jobb.EmployeeID = row.Cells[7].Value.ToString();
            

            if (row.Cells[1].Value.ToString().Contains("IC"))
            {
                indiv.UpdateIndividualClientJob(jobb);
            }
            else
            {
                busin.UpdateBusinessClientJob(jobb);
            }

        }
        DBOperations data = new DBOperations();

        private void JobTracking_Load(object sender, EventArgs e)
        {

            dataGridView1.DataSource = data.GetAllJobs();
        }

        //below will be 2 methods that will populate datagrid according to a buton call

        public void ALL()
        {
            //method populates the datagrid to have all jobs

            dataGridView1.DataSource = data.GetAllJobs();
        }

        public void Business()
        {
            
            //method populates the datagrid to have ONLY business related jobs

            dataGridView1.DataSource = data.Bjobs;

        }

        public void Individual()
        {
            //method populates the datagrid to have ONLY Individual related jobs
            
            dataGridView1.DataSource = data.Ijobs;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            rowindexa = e.RowIndex;

            DataGridViewRow row = dataGridView1.Rows[rowindexa];

            lbltest.Text = row.Cells[0].Value.ToString();
            label1.Text = row.Cells[1].Value.ToString();
            label3.Text = row.Cells[3].Value.ToString();
            label4.Text = row.Cells[4].Value.ToString();
            label5.Text = row.Cells[5].Value.ToString();
            label6.Text = row.Cells[6].Value.ToString();
            label7.Text = row.Cells[7].Value.ToString();
        }

        int rowindexa;

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            ServiceDapartment service = new ServiceDapartment();
            service.Show();
            service.OpenChildForm(new Technicians());
        }
    }
}
