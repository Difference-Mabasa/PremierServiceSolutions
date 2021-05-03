﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PremierServiceSolutions.DataAccessLayer;

namespace PremierServiceSolutions.BusinessLogicLayer
{
    class IndividualClientJobsBLL
    {
        public List<Job> GetIndividualClientJobByClientID(string id)
        {
            List<Job> jobs = new List<Job>();
            try
            {
                IndividualClientJobsDAL clientData = new IndividualClientJobsDAL();
                jobs = clientData.GetIndividualClientJobsByClientID(id);
            }
            catch (Exception e)
            {
                MessageBox.Show($"Error: {e.Message}");
            }

            return jobs;
        }

        public void InsertIndividualClientJob(Job job)
        {
            try
            {
                IndividualClientJobsDAL clientData = new IndividualClientJobsDAL();
                clientData.InsertIndividualClientJob(job);
            }
            catch (Exception e)
            {
                MessageBox.Show($"Error: {e.Message}");
            }
        }

        public void UpdateIndividualClientJob(Job job)
        {
            try
            {
                IndividualClientJobsDAL clientData = new IndividualClientJobsDAL();
                clientData.UpdateIndividualClientJob(job);
            }
            catch (Exception e)
            {
                MessageBox.Show($"Error: {e.Message}");
            }
        }

        public List<Job> GetAllIndividualClientsJobs()
        {
            List<Job> jobs = new List<Job>();
            try
            {
                IndividualClientJobsDAL getClients = new IndividualClientJobsDAL();
                jobs = getClients.GetAllIndividualJobs();
            }
            catch (Exception e)
            {
                MessageBox.Show($"Error on Business Client Jobs {e.Message}");
            }
            return jobs;
        }

        public void UpdateIndividualClientJobTech(Job job)
        {
            try
            {
                IndividualClientJobsDAL clientData = new IndividualClientJobsDAL();
                clientData.UpdateIndividualClientJobTech(job);
            }
            catch (Exception e)
            {
                MessageBox.Show($"Error: {e.Message}");
            }
        }
    }
}
