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
    }
}
