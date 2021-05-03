using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PremierServiceSolutions.BusinessLogicLayer
{
    class ClientSatisfaction
    {
        public void FollowUp(Job Job) 
        {
            CallBLL call = new CallBLL();
            call.MakeCall(Job.ClientID);
        }
    }
}
