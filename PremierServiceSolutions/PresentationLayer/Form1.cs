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

namespace PremierServiceSolutions
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            IndividualClientBLL bl = new IndividualClientBLL();
            IndividualClient client = bl.GetIndividualClientByID("I001");

            MessageBox.Show("Name: " + client.Name);
        }
    }
}
