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

        public bool onCall = false;

        List<CallBLL> callLog = new List<CallBLL>();

        public void MakeCall()
        {
            onCall = true;
            CallStartTime = DateTime.Now.ToString();
            //call client
            // maybe open an outgoing call form
        }
        public void AcceptCall()
        {
            onCall = true;
            CallStartTime = DateTime.Now.ToString();
            
            bool isClient = false;

            while(){
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
