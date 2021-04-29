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
            bool authenticationSuccessful = false;
            string id = txtID.Text;
            string pass = txtPassword.Text;

<<<<<<< HEAD
            EmployeeBLL bll = new EmployeeBLL();
            List<Employee> employees = bll.GetAllEmployees();

            foreach (Employee item in employees)
            {
                if (item.EmployeeID == id && item.Password == pass)
                {
                    authenticationSuccessful = true;
                    break;
                }
            }

            if (authenticationSuccessful)
            {
                this.Hide();
                CallCentre.Call frm = new CallCentre.Call();
                frm.Show();
            }

            else
            {
                MessageBox.Show("Incorrect username or password");
            }
=======
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

        //need to have a forgot password and maybe a sign up with a hover effect

        private void btnEXIT_Click(object sender, EventArgs e)
        {
            //exit

            Environment.Exit(0);
>>>>>>> develop
        }
    }
}
