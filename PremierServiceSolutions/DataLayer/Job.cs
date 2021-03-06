using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PremierServiceSolutions
{
    class Job
    {
        string jobID, clientID, technician, description, status, employeeID;
        int duration;
        bool finished;

        public string JobID { get => jobID; set => jobID = value; }
        public string ClientID { get => clientID; set => clientID = value; }
        public string Technician { get => technician; set => technician = value; }
        public bool Finished { get => finished; set => finished = value; }
        public int Duration { get => duration; set => duration = value; }
        public string Description { get => description; set => description = value; }
        public string Status { get => status; set => status = value; }
        public string EmployeeID { get => employeeID; set => employeeID = value; }

        public Job() { }

        public Job(string jobID, string clientID, string technician, int duration)
        {
            this.JobID = jobID;
            this.ClientID = clientID;
            this.Technician = technician;
            this.Duration = duration;
            
        }

        public void StartJob()
        {

        }

        public void FinishJob()
        {

        }

        public override string ToString()
        {
            return base.ToString();
        }


    }
}
