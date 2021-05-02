﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PremierServiceSolutions.BusinessLogicLayer;


namespace PremierServiceSolutions.PresentationLayer.ClientMaintanance
{
    public partial class ClientDetails : Form
    {
        BindingSource source = new BindingSource();
        BusinessClientBLL business = new BusinessClientBLL();
        IndividualClientBLL individual = new IndividualClientBLL();
        IndividualClient ic = new IndividualClient();
        BusinessClient bc = new BusinessClient();
        
        
        public ClientDetails()
        {
            InitializeComponent();
        }

        private void ClientDetails_Load(object sender, EventArgs e)
        {
            source.DataSource = individual.GetAllIndividualClients();
            dgvDisplay.DataSource = source;
        }

    }
}
