﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using PremierServiceSolutions.DataAccessLayer;

namespace PremierServiceSolutions.BusinessLogicLayer
{
    class DBOperations
    {
        public void AssignTechnician(Job job)
        {
            if (job.ClientID.Contains("BC"))
            {
                BusinessClientJobsDAL business = new BusinessClientJobsDAL();
                business.UpdateBusinessClientJobTech(job);

            }
            else if (job.ClientID.Contains("IC"))
            {
                IndividualClientJobsDAL individual = new IndividualClientJobsDAL();
                individual.UpdateIndividualClientJobTech(job);
            }
            else
            {
                MessageBox.Show("Unable To assign Technician");
            }
        }

        public void ViewAllClients(DataGridView dgvIndividualClients, DataGridView dgvBusinessClients)
        {

            //Get lists of individual clients and business clients
            IndividualClientDAL id = new IndividualClientDAL();
            List<IndividualClient> individualClients = id.GetAllIndividualClients();

            BusinessClientDAL bd = new BusinessClientDAL();
            List<BusinessClient> businessClients = bd.GetAllBusinessClients();

            //Create binding sources for both lists
            BindingSource sourceI = new BindingSource();
            sourceI.DataSource = individualClients;

            BindingSource sourceB = new BindingSource();
            sourceB.DataSource = businessClients;

            //bind datagridviews to lists
            dgvIndividualClients.DataSource = sourceI;

            dgvBusinessClients.DataSource = sourceB;

        }

    }
}
