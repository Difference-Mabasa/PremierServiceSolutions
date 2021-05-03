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
using static PremierServiceSolutions.PresentationLayer.CallCentre.CallCentre;
using PremierServiceSolutions.BusinessLogicLayer;

namespace PremierServiceSolutions.PresentationLayer.CallCentre
{
    public partial class Call: Form
    {
        public Call()
        {
            InitializeComponent();
            //this is to initiate the call
            timer1.Start();
        }
        //just a variable
        int counter = 0;

        private void Call_Load(object sender, EventArgs e)
        {
            //Randomize call

            CallBLL call = new CallBLL();
            IndividualClient client = call.RandomizeCall();

            //lblCall.Text = $"Incoming cass from {client.Name}";
            //label1.Text
            label4.Text = $"Incoming cass from {client.Name}";


            //this is to initiate the call
            timer1.Start();
        }

        private void btnAcceptCall_Click(object sender, EventArgs e)
        {
            counter = 0;

            CallCentre call = new CallCentre();
            call.ibtnClientDetails.PerformClick();











            //ClientDetails frm = new ClientDetails();
            //frm.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            counter++;

            //a call will only come in after 3 seconds once you succesfully logged in
            //you will only answer the call after 1 second
            if (counter == 3)
            {
                label1.Visible = true;

            }

            //this will come after 1 second after the call notification
            if (counter == 4)
            {
                btnAcceptCall.Enabled = true;
            }
        }

        private void lblCall_Click(object sender, EventArgs e)
        {

        }
    }
}
