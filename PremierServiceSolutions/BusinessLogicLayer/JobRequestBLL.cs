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
        string typeOfClient = " ";

        IndividualClientBLL individualClient = new IndividualClientBLL();
        IndividualClientJobsBLL individualClientJobsBLL = new IndividualClientJobsBLL();

        BusinessClientBLL businessClient = new BusinessClientBLL();
        BusinessClientJobsBLL businessClientJobsBLL = new BusinessClientJobsBLL();

        public void addRequest(string clientID, string jobType, string employeeName, string date) 
        {
            JobRequest jobRequest = new JobRequest(clientID, jobType, employeeName, date);
            // service department
           
        }

        public void updateRequest(Job job) 
        {
            string typeOfClient = " ";

            if(typeOfClient == "I")
            {
                
                individualClientJobsBLL.UpdateIndividualClientJob(job);
            }
            else if(typeOfClient == "B")
            {
                businessClientJobsBLL.UpdateBusinessClientJob(job);
            }

        }
    }
}
