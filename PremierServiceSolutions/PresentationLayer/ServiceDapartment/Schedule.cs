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
using PremierServiceSolutions.BusinessLogicLayer;

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

            this.Hide();
            Technicians tec = new Technicians();
            tec.Show();

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

        private void Schedule_Load(object sender, EventArgs e)
        {
            
        }
    }
}
