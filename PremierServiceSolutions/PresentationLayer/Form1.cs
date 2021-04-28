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

namespace PremierServiceSolutions.PresentationLayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string id = txtID.Text;
            string pass = txtPassword.Text;

            //checking for empty fields

            if (String.IsNullOrEmpty(txtID.Text) && String.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Fields cannot be left empty");
            }
            else if (String.IsNullOrEmpty(txtID.Text))
            {
                MessageBox.Show("Employee ID cannot be empty");
                txtPassword.Clear();

            }
            else if (String.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Password field cannot be left empty");
                txtID.Clear();
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtID.Clear();
            txtPassword.Clear();
        }
    }
}
