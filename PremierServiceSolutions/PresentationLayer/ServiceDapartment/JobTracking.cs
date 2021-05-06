﻿using PremierServiceSolutions.BusinessLogicLayer;
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
            //this will update the job status
            //check the logic of combobox first

            if (String.IsNullOrEmpty(comboBox1.Text))
            {
                MessageBox.Show("Please select a job status from the dropdown menu");
            }
        }

        private void JobTracking_Load(object sender, EventArgs e)
        {
            //combobox
            comboBox1.Items.Add("Not assigned");
            comboBox1.Items.Add("Started");
            comboBox1.Items.Add("In progress");
            comboBox1.Items.Add("Completed");
            comboBox1.Items.Add("Sent to client satisfaction");

            //populating the datagrid

            DBOperations alljobs = new DBOperations();
            

            //dataGridView1.DataSource = alljobs.GetAllJobs();
        }

        //below will be 2 methods that will populate datagrid according to a buton call

        public void ALL()
        {
            //method populates the datagrid to have all jobs
            lblStatus.Text = "ALL";
        }

        public void Business()
        {
            //method populates the datagrid to have ONLY business related jobs
            lblStatus.Text = "Business";
        }

        public void Individual()
        {
            //method populates the datagrid to have ONLY Individual related jobs
            lblStatus.Text = "Individual";
        }
    }
}
