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
            Call call = new Call();
            call.MakeCall(Job.ClientID);
        }
    }
}
