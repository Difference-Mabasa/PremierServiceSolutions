using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PremierServiceSolutions.BusinessLogicLayer
{
    class CallBLL
    {

        public void IncomingCall()
        {

            Console.WriteLine("incoming call, press 'a' to accept or 'd' to decline call ");

            string key = Console.ReadLine();

            if (key == "a")
            {
               AcceptCall();
            }
            else if (key == "d")
            {
               EndCall();
            }
            else
            {
                Console.WriteLine("call missed");
            }

        }
        public void MakeCall()
        {

        }
        public void AcceptCall()
        {
            RecordCall();

            //we assume user is not a client 
            bool isClient = false;

            //Console.WriteLine("client or not?");
            //how/

            if (isClient == true)
            {
                //enter client ID from presentation
                //BusinessClientBLL BCbll = new BusinessClientBLL();
                //search client by id? and view details

                //the log job request
            }
            else 
            { 
                //register new client
            }

        }

        public void EndCall()
        {

        }

        public void RecordCall()
        {


        }
    }
}
