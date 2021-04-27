
namespace PremierServiceSolutions.PresentationLayer.ClientMaintanance
{
    partial class ClientMaintanance
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
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.GbSCD = new System.Windows.Forms.GroupBox();
            this.txtContract = new System.Windows.Forms.TextBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
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
            this.GbSearchStud = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearchClient = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.GbDisplayButtons = new System.Windows.Forms.GroupBox();
            this.btnViewBusiness = new System.Windows.Forms.Button();
            this.btnViewIndividual = new System.Windows.Forms.Button();
            this.btnViewAll = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.Gbnav = new System.Windows.Forms.GroupBox();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.dgvDisplay = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.GbSCD.SuspendLayout();
            this.GbSearchStud.SuspendLayout();
            this.GbDisplayButtons.SuspendLayout();
            this.Gbnav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(268, 375);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(163, 33);
            this.btnUpdate.TabIndex = 37;
            this.btnUpdate.Text = "Update Client";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(268, 431);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(163, 33);
            this.btnAdd.TabIndex = 29;
            this.btnAdd.Text = "Add Client";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // GbSCD
            // 
            this.GbSCD.Controls.Add(this.txtContract);
            this.GbSCD.Controls.Add(this.txtStatus);
            this.GbSCD.Controls.Add(this.txtName);
            this.GbSCD.Controls.Add(this.txtSurname);
            this.GbSCD.Controls.Add(this.txtAddress);
            this.GbSCD.Controls.Add(this.txtPhone);
            this.GbSCD.Controls.Add(this.txtID);
            this.GbSCD.Controls.Add(this.lblEmail);
            this.GbSCD.Controls.Add(this.lblContract);
            this.GbSCD.Controls.Add(this.lblPhone);
            this.GbSCD.Controls.Add(this.lblAddress);
            this.GbSCD.Controls.Add(this.lblSurname);
            this.GbSCD.Controls.Add(this.lblName);
            this.GbSCD.Controls.Add(this.lblClientID);
            this.GbSCD.Location = new System.Drawing.Point(26, 366);
            this.GbSCD.Name = "GbSCD";
            this.GbSCD.Size = new System.Drawing.Size(220, 284);
            this.GbSCD.TabIndex = 33;
            this.GbSCD.TabStop = false;
            this.GbSCD.Text = "Client Details";
            // 
            // txtContract
            // 
            this.txtContract.Location = new System.Drawing.Point(95, 230);
            this.txtContract.Name = "txtContract";
            this.txtContract.Size = new System.Drawing.Size(100, 20);
            this.txtContract.TabIndex = 18;
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(95, 160);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(100, 20);
            this.txtStatus.TabIndex = 17;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(95, 56);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 16;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(95, 85);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(100, 20);
            this.txtSurname.TabIndex = 15;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(95, 194);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(100, 20);
            this.txtAddress.TabIndex = 14;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(95, 122);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(100, 20);
            this.txtPhone.TabIndex = 13;
            // 
            // txtID
            // 
            this.txtID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtID.Location = new System.Drawing.Point(95, 22);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 12;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(15, 160);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 11;
            this.lblEmail.Text = "Email";
            // 
            // lblContract
            // 
            this.lblContract.AutoSize = true;
            this.lblContract.Location = new System.Drawing.Point(14, 230);
            this.lblContract.Name = "lblContract";
            this.lblContract.Size = new System.Drawing.Size(47, 13);
            this.lblContract.TabIndex = 10;
            this.lblContract.Text = "Contract";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(15, 122);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(38, 13);
            this.lblPhone.TabIndex = 4;
            this.lblPhone.Text = "Phone";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(14, 197);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(45, 13);
            this.lblAddress.TabIndex = 3;
            this.lblAddress.Text = "Address";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(15, 85);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(49, 13);
            this.lblSurname.TabIndex = 2;
            this.lblSurname.Text = "Surname";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(15, 56);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            // 
            // lblClientID
            // 
            this.lblClientID.AutoSize = true;
            this.lblClientID.Location = new System.Drawing.Point(14, 29);
            this.lblClientID.Name = "lblClientID";
            this.lblClientID.Size = new System.Drawing.Size(43, 13);
            this.lblClientID.TabIndex = 0;
            this.lblClientID.Text = "clientID";
            // 
            // GbSearchStud
            // 
            this.GbSearchStud.Controls.Add(this.btnSearch);
            this.GbSearchStud.Controls.Add(this.txtSearchClient);
            this.GbSearchStud.Controls.Add(this.label2);
            this.GbSearchStud.Location = new System.Drawing.Point(566, 236);
            this.GbSearchStud.Name = "GbSearchStud";
            this.GbSearchStud.Size = new System.Drawing.Size(181, 101);
            this.GbSearchStud.TabIndex = 36;
            this.GbSearchStud.TabStop = false;
            this.GbSearchStud.Text = "Search Client";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(9, 64);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(130, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search client";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtSearchClient
            // 
            this.txtSearchClient.Location = new System.Drawing.Point(9, 38);
            this.txtSearchClient.Name = "txtSearchClient";
            this.txtSearchClient.Size = new System.Drawing.Size(130, 20);
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
            this.GbDisplayButtons.Location = new System.Drawing.Point(566, 66);
            this.GbDisplayButtons.Name = "GbDisplayButtons";
            this.GbDisplayButtons.Size = new System.Drawing.Size(181, 157);
            this.GbDisplayButtons.TabIndex = 35;
            this.GbDisplayButtons.TabStop = false;
            this.GbDisplayButtons.Text = "Display buttons";
            // 
            // btnViewBusiness
            // 
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
            this.btnViewAll.Location = new System.Drawing.Point(12, 24);
            this.btnViewAll.Name = "btnViewAll";
            this.btnViewAll.Size = new System.Drawing.Size(163, 33);
            this.btnViewAll.TabIndex = 0;
            this.btnViewAll.Text = "View All Clients";
            this.btnViewAll.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(566, 22);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(181, 38);
            this.btnExit.TabIndex = 34;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = true;
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
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(428, 18);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(75, 23);
            this.btnLast.TabIndex = 3;
            this.btnLast.Text = ">|";
            this.btnLast.UseVisualStyleBackColor = true;
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
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(304, 19);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(75, 23);
            this.btnPrevious.TabIndex = 1;
            this.btnPrevious.Text = "<<";
            this.btnPrevious.UseVisualStyleBackColor = true;
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
            // dgvDisplay
            // 
            this.dgvDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDisplay.Location = new System.Drawing.Point(26, 37);
            this.dgvDisplay.Name = "dgvDisplay";
            this.dgvDisplay.Size = new System.Drawing.Size(534, 256);
            this.dgvDisplay.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 24);
            this.label1.TabIndex = 30;
            this.label1.Text = "Client Maintance";
            // 
            // ClientMaintanance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 701);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.GbSCD);
            this.Controls.Add(this.GbSearchStud);
            this.Controls.Add(this.GbDisplayButtons);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.Gbnav);
            this.Controls.Add(this.dgvDisplay);
            this.Controls.Add(this.label1);
            this.Name = "ClientMaintanance";
            this.Text = "ClientMaintanance";
            this.GbSCD.ResumeLayout(false);
            this.GbSCD.PerformLayout();
            this.GbSearchStud.ResumeLayout(false);
            this.GbSearchStud.PerformLayout();
            this.GbDisplayButtons.ResumeLayout(false);
            this.Gbnav.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox GbSCD;
        private System.Windows.Forms.TextBox txtContract;
        private System.Windows.Forms.TextBox txtStatus;
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
        private System.Windows.Forms.GroupBox GbSearchStud;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearchClient;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox GbDisplayButtons;
        private System.Windows.Forms.Button btnViewBusiness;
        private System.Windows.Forms.Button btnViewIndividual;
        private System.Windows.Forms.Button btnViewAll;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox Gbnav;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.DataGridView dgvDisplay;
        private System.Windows.Forms.Label label1;
    }
}