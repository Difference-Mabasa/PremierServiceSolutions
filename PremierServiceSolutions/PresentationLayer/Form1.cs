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

namespace PremierServiceSolutions.PresentationLayer
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtEmployeeID_Click(object sender, EventArgs e)
        {
            txtEmployeeID.Clear();
            pbID.BackgroundImage = Properties.Resources.user2;
            panel1.ForeColor = Color.FromArgb(78, 184, 206);
            txtEmployeeID.ForeColor = Color.LightCyan;

            pbPass.BackgroundImage = Properties.Resources.pass3;
            panel1.ForeColor = Color.WhiteSmoke;
            txtPassword.ForeColor = Color.WhiteSmoke;
        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            txtPassword.Clear();
            txtPassword.PasswordChar = '*';
            pbPass.BackgroundImage = Properties.Resources.pass;
            panel2.ForeColor = Color.FromArgb(78, 184, 206);
            txtPassword.ForeColor = Color.Cyan;

            pbID.BackgroundImage = Properties.Resources.user;
            panel2.ForeColor = Color.WhiteSmoke;
            txtEmployeeID.ForeColor = Color.WhiteSmoke;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool authenticationSuccessful = false;
            string id = txtEmployeeID.Text;
            string pass = txtPassword.Text;
            //we need to verify if fields are empty or not

            if (String.IsNullOrEmpty(id) && String.IsNullOrEmpty(pass))
            {
                MessageBox.Show("Fields cannot be left empty!");
            }
            else if (String.IsNullOrEmpty(id))
            {
                MessageBox.Show("Please enter employee ID");
            }
            else if (String.IsNullOrEmpty(pass))
            {
                MessageBox.Show("Please enter password");
            }

            EmployeeBLL bll = new EmployeeBLL();
            List<Employee> employees = bll.GetAllEmployees();

            //must iterate through the list of ALL employees to find the details
            foreach (Employee item in employees)
            {
                if (item.EmployeeID == id && item.Password == pass)
                {
                    authenticationSuccessful = true;
                    break;
                }
            }

            //once the employee has been found then we move onto receiving the call
            if (authenticationSuccessful)
            {
                this.Hide();
                CallCentre.CallCentre frm = new CallCentre.CallCentre();
                frm.Show();
            }
            else
            {
                MessageBox.Show("Incorrect username or password");
            }
            //checking for empty fields

            if (String.IsNullOrEmpty(txtEmployeeID.Text) && String.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Fields cannot be left empty");
            }
            else if (String.IsNullOrEmpty(txtEmployeeID.Text))
            {
                MessageBox.Show("Employee ID cannot be empty");
                txtPassword.Clear();

            }
            else if (String.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Password field cannot be left empty");
                txtEmployeeID.Clear();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
           
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
