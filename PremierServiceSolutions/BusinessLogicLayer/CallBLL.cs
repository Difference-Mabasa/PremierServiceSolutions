using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PremierServiceSolutions.BusinessLogicLayer
{
    class CallBLL
    {
        string callStartTime;
        string callEndTime;

        public string CallStartTime{ get; set; }
        public string CallEndTime { get; set; }

        List<CallBLL> callLog = new List<CallBLL>();

        public void MakeCall()
        {
            CallStartTime = DateTime.Now.ToString();
            //call client
        }
        public void AcceptCall()
        {
            CallStartTime = DateTime.Now.ToString();
            
            bool isClient = false;


            if (isClient == true) 
            {
                PresentationLayer.CallCentre.ClientDetails clientDetails = new PresentationLayer.CallCentre.ClientDetails() ;
                clientDetails.Show();
            }
            else 
            { 
                //register & login
            }
        }

        public void EndCall()
        {
            //end call
            CallEndTime = DateTime.Now.ToString();
            Console.WriteLine("Duration: {0} - {1}", CallEndTime, CallStartTime);
        }

        public void RecordCall()
        {
            //call record

        }
    }
}
