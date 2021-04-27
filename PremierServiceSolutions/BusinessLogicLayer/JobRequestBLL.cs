using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PremierServiceSolutions.BusinessLogicLayer
{
    class JobRequestBLL
    {
        public void addRequest(string clientID, string jobType, string employeeName, string date) 
        {
            JobRequest jobRequest = new JobRequest(clientID, jobType, employeeName, date);

            MessageBox.Show("Job Request Sent");
            //notify service department?
        }

        public void updateRequest() 
        { 
            //Search job request by job ID
            //then modify
            //class that contains all clients and jobs

        }
    }
}
