using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PremierServiceSolutions
{
    class JobRequest
    {
        string requestID, clientName, employeeName, date;
        DateTime dt = new DateTime();

        public JobRequest(string requestID, string clientName, string employeeName, string date)
        {
            RequestID = requestID;
            ClientName = clientName;
            EmployeeName = employeeName;
            Date = date;
        }

        public string RequestID { get => requestID; set => requestID = value; }
        public string ClientName { get => clientName; set => clientName = value; }
        public string EmployeeName { get => employeeName; set => employeeName = value; }
        public string Date { get => date; set => date = value; }

        public void SendRequest()
        {

        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
