﻿
using System;

namespace PremierServiceSolutions.PresentationLayer.ClientMaintanance
{
    partial class ClientDetails
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.GbSearchStud = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearchClient = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvIndividualClients = new System.Windows.Forms.DataGridView();
            this.GbCD = new System.Windows.Forms.GroupBox();
            this.txtContract = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblContract = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblClientID = new System.Windows.Forms.Label();
            this.dgvBusinessClients = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.GbSearchStud.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIndividualClients)).BeginInit();
            this.GbCD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBusinessClients)).BeginInit();
            this.SuspendLayout();
            // 
            // GbSearchStud
            // 
            this.GbSearchStud.Controls.Add(this.btnSearch);
            this.GbSearchStud.Controls.Add(this.txtSearchClient);
            this.GbSearchStud.Controls.Add(this.label2);
            this.GbSearchStud.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbSearchStud.ForeColor = System.Drawing.Color.White;
            this.GbSearchStud.Location = new System.Drawing.Point(568, 37);
            this.GbSearchStud.Name = "GbSearchStud";
            this.GbSearchStud.Size = new System.Drawing.Size(220, 111);
            this.GbSearchStud.TabIndex = 36;
            this.GbSearchStud.TabStop = false;
            this.GbSearchStud.Text = "Search Client";
            // 
            // btnSearch
            // 
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(18, 67);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(185, 30);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search client";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearchClient
            // 
            this.txtSearchClient.Location = new System.Drawing.Point(17, 38);
            this.txtSearchClient.Name = "txtSearchClient";
            this.txtSearchClient.Size = new System.Drawing.Size(186, 23);
            this.txtSearchClient.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Enter Client ID";
            // 
            // dgvIndividualClients
            // 
            this.dgvIndividualClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIndividualClients.Location = new System.Drawing.Point(26, 66);
            this.dgvIndividualClients.Name = "dgvIndividualClients";
            this.dgvIndividualClients.Size = new System.Drawing.Size(534, 256);
            this.dgvIndividualClients.TabIndex = 31;
            // 
            // GbCD
            // 
            this.GbCD.Controls.Add(this.txtContract);
            this.GbCD.Controls.Add(this.txtEmail);
            this.GbCD.Controls.Add(this.txtName);
            this.GbCD.Controls.Add(this.txtSurname);
            this.GbCD.Controls.Add(this.txtAddress);
            this.GbCD.Controls.Add(this.txtPhone);
            this.GbCD.Controls.Add(this.txtID);
            this.GbCD.Controls.Add(this.lblEmail);
            this.GbCD.Controls.Add(this.lblContract);
            this.GbCD.Controls.Add(this.lblPhone);
            this.GbCD.Controls.Add(this.lblAddress);
            this.GbCD.Controls.Add(this.lblSurname);
            this.GbCD.Controls.Add(this.lblName);
            this.GbCD.Controls.Add(this.lblClientID);
            this.GbCD.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbCD.ForeColor = System.Drawing.Color.White;
            this.GbCD.Location = new System.Drawing.Point(568, 185);
            this.GbCD.Name = "GbCD";
            this.GbCD.Size = new System.Drawing.Size(220, 284);
            this.GbCD.TabIndex = 47;
            this.GbCD.TabStop = false;
            this.GbCD.Text = "Client Details";
            // 
            // txtContract
            // 
            this.txtContract.Location = new System.Drawing.Point(95, 230);
            this.txtContract.Name = "txtContract";
            this.txtContract.Size = new System.Drawing.Size(100, 23);
            this.txtContract.TabIndex = 18;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(95, 160);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 23);
            this.txtEmail.TabIndex = 17;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(95, 56);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 23);
            this.txtName.TabIndex = 16;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(95, 85);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(100, 23);
            this.txtSurname.TabIndex = 15;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(95, 194);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(100, 23);
            this.txtAddress.TabIndex = 14;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(95, 122);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(100, 23);
            this.txtPhone.TabIndex = 13;
            // 
            // txtID
            // 
            this.txtID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtID.Location = new System.Drawing.Point(95, 22);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 23);
            this.txtID.TabIndex = 12;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(15, 160);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(44, 15);
            this.lblEmail.TabIndex = 11;
            this.lblEmail.Text = "Email";
            // 
            // lblContract
            // 
            this.lblContract.AutoSize = true;
            this.lblContract.Location = new System.Drawing.Point(14, 230);
            this.lblContract.Name = "lblContract";
            this.lblContract.Size = new System.Drawing.Size(65, 15);
            this.lblContract.TabIndex = 10;
            this.lblContract.Text = "Contract";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(15, 122);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(48, 15);
            this.lblPhone.TabIndex = 4;
            this.lblPhone.Text = "Phone";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(14, 197);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(60, 15);
            this.lblAddress.TabIndex = 3;
            this.lblAddress.Text = "Address";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(15, 85);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(66, 15);
            this.lblSurname.TabIndex = 2;
            this.lblSurname.Text = "Surname";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(15, 56);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(45, 15);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            // 
            // lblClientID
            // 
            this.lblClientID.AutoSize = true;
            this.lblClientID.Location = new System.Drawing.Point(14, 29);
            this.lblClientID.Name = "lblClientID";
            this.lblClientID.Size = new System.Drawing.Size(58, 15);
            this.lblClientID.TabIndex = 0;
            this.lblClientID.Text = "clientID";
            // 
            // dgvBusinessClients
            // 
            this.dgvBusinessClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBusinessClients.Location = new System.Drawing.Point(26, 371);
            this.dgvBusinessClients.Name = "dgvBusinessClients";
            this.dgvBusinessClients.Size = new System.Drawing.Size(534, 256);
            this.dgvBusinessClients.TabIndex = 48;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(23, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 22);
            this.label1.TabIndex = 49;
            this.label1.Text = "Individual Clients";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(23, 346);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 22);
            this.label3.TabIndex = 50;
            this.label3.Text = "Business Clients";
            // 
            // ClientDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(800, 701);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvBusinessClients);
            this.Controls.Add(this.GbCD);
            this.Controls.Add(this.GbSearchStud);
            this.Controls.Add(this.dgvIndividualClients);
            this.Name = "ClientDetails";
            this.Text = "ClientDetails";
            this.Load += new System.EventHandler(this.ClientDetails_Load);
            this.GbSearchStud.ResumeLayout(false);
            this.GbSearchStud.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIndividualClients)).EndInit();
            this.GbCD.ResumeLayout(false);
            this.GbCD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBusinessClients)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void btnViewIndividual_Click(object sender, EventArgs e)
        {
            source.DataSource = individual.GetAllIndividualClients();
            dgvIndividualClients.DataSource = source;
        }

        private void btnViewBusiness_Click(object sender, EventArgs e)
        {
            source.DataSource = business.GetAllBusinessClients();
            dgvIndividualClients.DataSource = source;
        }

        //private void btnSearch_Click(object sender, EventArgs e)
        //{

        //    bc = business.GetBusinessClientByID(txtSearchClient.Text);
        //    txtID.Text = bc.clientID;
        //    txtName.Text = bc.CompanyName;
        //    txtPhone.Text = bc.Phone;
        //    txtEmail.Text = bc.Email;
        //    txtAddress.Text = bc.AddressID;
        //    txtContract.Text = bc.ContractID;

        //    ic = individual.GetIndividualClientByID(txtSearchClient.Text);
        //    txtID.Text = ic.clientID;
        //    txtName.Text = ic.Name;
        //    txtSurname.Text = ic.Surname;
        //    txtPhone.Text = ic.Phone;
        //    txtEmail.Text = ic.Email;
        //    txtAddress.Text = ic.AddressID;
        //    txtContract.Text = ic.ContractID;


        //}

        #endregion
        private System.Windows.Forms.GroupBox GbSearchStud;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearchClient;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvIndividualClients;
        private System.Windows.Forms.GroupBox GbCD;
        private System.Windows.Forms.TextBox txtContract;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblContract;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblClientID;
        private System.Windows.Forms.DataGridView dgvBusinessClients;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}