using PremierServiceSolutions.BusinessLogicLayer;
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
    public partial class Schedule : Form
    {
        
        public Schedule()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ServiceDapartment service = new ServiceDapartment();
            service.Show();
            service.OpenChildForm(new Technicians());
        }

        private void Schedule_Load(object sender, EventArgs e)
        {
            //
            EmployeeBLL workers = new EmployeeBLL();

            List<Employee> technoguys = new List<Employee>();


            foreach (var item in workers.GetAllEmployees())
            {
                if (item.JobTitle == "Technician" || item.JobTitle == "technician")
                {
                    technoguys.Add(item);
                }
            }
            
            dgbDisplay.DataSource = technoguys;
        }

        private void btnJob_Click(object sender, EventArgs e)
        {
            //JobTracking

            JobTracking jobs = new JobTracking();

            this.Hide();
            jobs.Show();
        }
    }
}
