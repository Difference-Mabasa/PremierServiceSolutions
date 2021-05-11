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
    public partial class frmCall: Form
    {
        public frmCall()
        {
            InitializeComponent();
            //this is to initiate the call
            timer1.Start();
        }
        //just a variable
        int counter = 0;
        public string caller;

        private void Call_Load(object sender, EventArgs e)
        {
            //Randomize call

            Call c = new Call();
            IndividualClient client = c.RandomizeCall();
            caller = client.Name;

            ObjectSerializer serializer = new ObjectSerializer();
            serializer.SerializeIndividualClient(client);
            
            //label1.Text


            //this is to initiate the call
            timer1.Start();
        }

        private void btnAcceptCall_Click(object sender, EventArgs e)
        {
            ObjectSerializer serializer = new ObjectSerializer();

            Call call = new Call();
            call.AcceptCall(serializer.DeSerializeIndividualClient(), serializer.DeSerializeEmployee());
            serializer.SerializeCall(call);

            CallCentre callC = new CallCentre();
            callC.ibtnClientDetails.PerformClick();

            

            ClientDetails frm = new ClientDetails();
            frm.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            counter++;

            //a call will only come in after 3 seconds once you succesfully logged in
            //you will only answer the call after 1 second
            if (counter == 3)
            {
                pictureBox3.Visible = true;
                label4.Visible = true;
                label4.Text = $"Incoming call from {caller}";
                btnDeclineCall.Visible = true;
                btnAcceptCall.Visible = true;
                label2.Visible = true;
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
