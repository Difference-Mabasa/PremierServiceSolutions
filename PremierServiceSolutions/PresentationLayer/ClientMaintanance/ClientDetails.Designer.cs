
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
            this.GbDisplayButtons = new System.Windows.Forms.GroupBox();
            this.btnViewBusiness = new System.Windows.Forms.Button();
            this.btnViewIndividual = new System.Windows.Forms.Button();
            this.btnViewAll = new System.Windows.Forms.Button();
            this.dgvDisplay = new System.Windows.Forms.DataGridView();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.Gbnav = new System.Windows.Forms.GroupBox();
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
            this.GbSearchStud.SuspendLayout();
            this.GbDisplayButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplay)).BeginInit();
            this.Gbnav.SuspendLayout();
            this.GbCD.SuspendLayout();
            this.SuspendLayout();
            // 
            // GbSearchStud
            // 
            this.GbSearchStud.Controls.Add(this.btnSearch);
            this.GbSearchStud.Controls.Add(this.txtSearchClient);
            this.GbSearchStud.Controls.Add(this.label2);
            this.GbSearchStud.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbSearchStud.ForeColor = System.Drawing.Color.White;
            this.GbSearchStud.Location = new System.Drawing.Point(566, 211);
            this.GbSearchStud.Name = "GbSearchStud";
            this.GbSearchStud.Size = new System.Drawing.Size(181, 111);
            this.GbSearchStud.TabIndex = 36;
            this.GbSearchStud.TabStop = false;
            this.GbSearchStud.Text = "Search Client";
            // 
            // btnSearch
            // 
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(6, 75);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(169, 30);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search client";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearchClient
            // 
            this.txtSearchClient.Location = new System.Drawing.Point(9, 38);
            this.txtSearchClient.Name = "txtSearchClient";
            this.txtSearchClient.Size = new System.Drawing.Size(166, 23);
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
            // GbDisplayButtons
            // 
            this.GbDisplayButtons.Controls.Add(this.btnViewBusiness);
            this.GbDisplayButtons.Controls.Add(this.btnViewIndividual);
            this.GbDisplayButtons.Controls.Add(this.btnViewAll);
            this.GbDisplayButtons.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbDisplayButtons.ForeColor = System.Drawing.Color.White;
            this.GbDisplayButtons.Location = new System.Drawing.Point(566, 37);
            this.GbDisplayButtons.Name = "GbDisplayButtons";
            this.GbDisplayButtons.Size = new System.Drawing.Size(181, 157);
            this.GbDisplayButtons.TabIndex = 35;
            this.GbDisplayButtons.TabStop = false;
            this.GbDisplayButtons.Text = "Display buttons";
            // 
            // btnViewBusiness
            // 
            this.btnViewBusiness.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewBusiness.Location = new System.Drawing.Point(12, 102);
            this.btnViewBusiness.Name = "btnViewBusiness";
            this.btnViewBusiness.Size = new System.Drawing.Size(163, 33);
            this.btnViewBusiness.TabIndex = 2;
            this.btnViewBusiness.Text = "View Business Clients";
            this.btnViewBusiness.UseVisualStyleBackColor = true;
            this.btnViewBusiness.Click += new System.EventHandler(this.btnViewBusiness_Click);
            // 
            // btnViewIndividual
            // 
            this.btnViewIndividual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewIndividual.Location = new System.Drawing.Point(12, 63);
            this.btnViewIndividual.Name = "btnViewIndividual";
            this.btnViewIndividual.Size = new System.Drawing.Size(163, 33);
            this.btnViewIndividual.TabIndex = 1;
            this.btnViewIndividual.Text = "View Individual Clients";
            this.btnViewIndividual.UseVisualStyleBackColor = true;
            this.btnViewIndividual.Click += new System.EventHandler(this.btnViewIndividual_Click);
            // 
            // btnViewAll
            // 
            this.btnViewAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewAll.Location = new System.Drawing.Point(12, 24);
            this.btnViewAll.Name = "btnViewAll";
            this.btnViewAll.Size = new System.Drawing.Size(163, 33);
            this.btnViewAll.TabIndex = 0;
            this.btnViewAll.Text = "View All Clients";
            this.btnViewAll.UseVisualStyleBackColor = true;
            // 
            // dgvDisplay
            // 
            this.dgvDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDisplay.Location = new System.Drawing.Point(26, 37);
            this.dgvDisplay.Name = "dgvDisplay";
            this.dgvDisplay.Size = new System.Drawing.Size(534, 256);
            this.dgvDisplay.TabIndex = 31;
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(15, 18);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(75, 23);
            this.btnFirst.TabIndex = 0;
            this.btnFirst.Text = "|<";
            this.btnFirst.UseVisualStyleBackColor = true;
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(304, 19);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(75, 23);
            this.btnPrevious.TabIndex = 1;
            this.btnPrevious.Text = "<<";
            this.btnPrevious.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(157, 18);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = ">>";
            this.btnNext.UseVisualStyleBackColor = true;
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(428, 18);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(75, 23);
            this.btnLast.TabIndex = 3;
            this.btnLast.Text = ">|";
            this.btnLast.UseVisualStyleBackColor = true;
            // 
            // Gbnav
            // 
            this.Gbnav.Controls.Add(this.btnLast);
            this.Gbnav.Controls.Add(this.btnNext);
            this.Gbnav.Controls.Add(this.btnPrevious);
            this.Gbnav.Controls.Add(this.btnFirst);
            this.Gbnav.Location = new System.Drawing.Point(26, 300);
            this.Gbnav.Name = "Gbnav";
            this.Gbnav.Size = new System.Drawing.Size(534, 47);
            this.Gbnav.TabIndex = 32;
            this.Gbnav.TabStop = false;
            this.Gbnav.Text = "Navigation";
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
            this.GbCD.Location = new System.Drawing.Point(26, 375);
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
            // ClientDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(800, 701);
            this.Controls.Add(this.GbCD);
            this.Controls.Add(this.GbSearchStud);
            this.Controls.Add(this.GbDisplayButtons);
            this.Controls.Add(this.Gbnav);
            this.Controls.Add(this.dgvDisplay);
            this.Name = "ClientDetails";
            this.Text = "ClientDetails";
            this.Load += new System.EventHandler(this.ClientDetails_Load);
            this.GbSearchStud.ResumeLayout(false);
            this.GbSearchStud.PerformLayout();
            this.GbDisplayButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplay)).EndInit();
            this.Gbnav.ResumeLayout(false);
            this.GbCD.ResumeLayout(false);
            this.GbCD.PerformLayout();
            this.ResumeLayout(false);

        }

        private void btnViewIndividual_Click(object sender, EventArgs e)
        {
            source.DataSource = individual.GetAllIndividualClients();
            dgvDisplay.DataSource = source;
        }

        private void btnViewBusiness_Click(object sender, EventArgs e)
        {
            source.DataSource = business.GetAllBusinessClients();
            dgvDisplay.DataSource = source;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
                
                bc = business.GetBusinessClientByID(txtSearchClient.Text);
                txtID.Text = bc.clientID;
                txtName.Text = bc.CompanyName;
                txtPhone.Text = bc.Phone;
                txtEmail.Text = bc.Email;
                txtAddress.Text = bc.AddressID;
                txtContract.Text = bc.ContractID;

                ic = individual.GetIndividualClientByID(txtSearchClient.Text);
                txtID.Text = ic.clientID;
                txtName.Text = ic.Name;
                txtSurname.Text = ic.Surname;
                txtPhone.Text = ic.Phone;
                txtEmail.Text = ic.Email;
                txtAddress.Text = ic.AddressID;
                txtContract.Text = ic.ContractID;


        }

        #endregion
        private System.Windows.Forms.GroupBox GbSearchStud;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearchClient;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox GbDisplayButtons;
        private System.Windows.Forms.Button btnViewBusiness;
        private System.Windows.Forms.Button btnViewIndividual;
        private System.Windows.Forms.Button btnViewAll;
        private System.Windows.Forms.DataGridView dgvDisplay;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.GroupBox Gbnav;
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
    }
}