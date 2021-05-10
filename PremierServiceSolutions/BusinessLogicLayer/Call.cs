using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

using PremierServiceSolutions.DataAccessLayer;


namespace PremierServiceSolutions
{
    [Serializable]

    class Call
    {
        
        string callID, clientID, employeeID;
        int duration;
        DateTime startTime, endTime, callDate;

        public string ClientID{ get => clientID; set => clientID = value; }
        public string EmployeeID { get => employeeID; set => employeeID = value; }
        public DateTime StartTime { get => startTime; set => startTime = value; }
        public DateTime EndTime { get => endTime; set => endTime = value; }
        public int Duration { get => duration; set => duration = value; }
        public string CallID { get => callID; set => callID = value; }
        public DateTime CallDate { get => callDate; set => callDate = value; }

        
        public Call() { }
        
        public void MakeCall(string ClientID)
        {
            //open outgoing call form
        }

        public int GenerateCallID(IClient caller)
        {

            int total = 0, currentCallNumber = 0;

            if (caller is IndividualClient)
            {             

                IndividualClientCallReportsDAL dal = new IndividualClientCallReportsDAL();
                total = dal.CountIndividualClientCallReports();

                currentCallNumber = total + 1;

            }

            else if(caller is BusinessClient)
            {
                BusinessClientCallReportsDAL dal = new BusinessClientCallReportsDAL();
                total = dal.CountBusinessClientCallReports();

                currentCallNumber = total + 1;

            }

            return currentCallNumber;
        }

        public void AcceptCall(IClient caller, Employee employee)
        {
            int callNumber = GenerateCallID(caller);

            CallID = $"C{callNumber}";
            StartTime = DateTime.Now;
            ClientID = caller.clientID;
            EmployeeID = employee.EmployeeID;
            CallDate = DateTime.Now;
            
        }

        public void EndCall()
        {
            EndTime = DateTime.Now;
            TimeSpan ts = EndTime - StartTime;

            Duration = (int)ts.TotalMinutes;
            
        }

        public void RecordCall(string clientName, string employeeName, string duration)
        {

            Console.WriteLine("Call Report:/n" +
                "Call from: {0}/n" +
                "Call To: {1}/n" +
                "Duration: {2}", clientName, employeeName, duration);
        }

        
        public IndividualClient RandomizeCall()
        {
            IndividualClientDAL dal = new IndividualClientDAL();
            Random ran = new Random();
            int index = ran.Next(0, dal.CountIndividualClients());

            List<IndividualClient> clients = dal.GetAllIndividualClients();
            //DataRow row = table.Rows[index];

            IndividualClient client = clients[index];

            //client.clientID = row[0].ToString();
            //client.Name = row[1].ToString();
            //client.Surname = row[2].ToString();
            //client.Phone = row[3].ToString();
            //client.Email = row[4].ToString();

            //The rest of the field will be added

            return client;
        }

        

    }
}
