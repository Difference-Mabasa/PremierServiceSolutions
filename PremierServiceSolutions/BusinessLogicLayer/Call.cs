﻿using System;
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
        public string StartTime { get => time; set => time = value; }
        public string EndTime { get => time; set => time = value; }
        public string Duration { get => duration; set => duration = value; }

        public Call(string clientName, string employeeName, string startTime, string endTime, string duration)
        {
            ClientName = clientName;
            EmployeeName = employeeName;
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
        
    }
}
