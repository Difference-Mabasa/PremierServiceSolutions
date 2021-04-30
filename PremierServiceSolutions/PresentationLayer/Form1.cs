using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;

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

            

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPassword.Clear();
            txtPassword.PasswordChar = '*';
            pictureBox2.BackgroundImage = Properties.Resources.pass1;
            panel3.ForeColor = Color.FromArgb(78, 184, 206);
            txtPassword.ForeColor = Color.FromArgb(78, 184, 206);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //need to have a forgot password and maybe a sign up with a hover effect

        private void btnEXIT_Click(object sender, EventArgs e)
        {
            //exit

            Environment.Exit(0);
        }
    }
}
