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
        
        string clientID, employeeID, time, duration;
        string callID;
        string callDate;

        public string ClientID{ get => clientID; set => clientID = value; }
        public string EmployeeID { get => employeeID; set => employeeID = value; }
        public string StartTime { get => time; set => time = value; }
        public string EndTime { get => time; set => time = value; }
        public string Duration { get => duration; set => duration = value; }
        public string CallID { get => callID; set => callID = value; }
        public string CallDate { get => callDate; set => callDate = value; }

        public Call(string clientName, string employeeName, string startTime, string endTime, string duration)
        {
            ClientID = clientName;
            EmployeeID = employeeName;
            StartTime = startTime;
            EndTime = endTime;
            Duration = duration;
        }
        public Call() { }
        
        public void MakeCall(string ClientID)
        {
            //open outgoing call form
        }

        public void AcceptCall()
        {
            StartTime = DateTime.Now.ToString();
            //opens form to search client using client ID
            PresentationLayer.CallCentre.ClientDetails clientDetails = new PresentationLayer.CallCentre.ClientDetails();
            clientDetails.Show();

            
        }

        public void EndCall()
        {
            string clientName = " ";
            string employeeName = " ";
            EndTime = DateTime.Now.ToString();
            Duration = (int.Parse(EndTime) - int.Parse(StartTime)).ToString();
            RecordCall(clientName, employeeName, Duration);
        }

        public void RecordCall(string clientName, string employeeName, string duration)
        {

            Console.WriteLine("Call Report:/n" +
                "Call from: {0}/n" +
                "Call To: {1}/n" +
                "Duration: {2}", clientName, employeeName, duration);
        }

        // Check castings , from list to datatable
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
