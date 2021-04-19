using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PremierServiceSolutions
{
    class Call
    {
        string clientName, employeeName, time, duration;

        public string ClientName { get => clientName; set => clientName = value; }
        public string EmployeeName { get => employeeName; set => employeeName = value; }
        public string Time { get => time; set => time = value; }
        public string Duration { get => duration; set => duration = value; }

        public Call(string clientName, string employeeName, string time, string duration)
        {
            ClientName = clientName;
            EmployeeName = employeeName;
            Time = time;
            Duration = duration;
        }

        public void AcceptCall()
        {

        }

        public void EndCall()
        {

        }

        public void RecordCall()
        {

        }
    }
}
