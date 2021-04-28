
namespace PremierServiceSolutions.PresentationLayer.ClientMaintanance
{
    partial class AddClients
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
            this.btnAddBC = new System.Windows.Forms.Button();
            this.btnAddIC = new System.Windows.Forms.Button();
            this.GbSCD = new System.Windows.Forms.GroupBox();
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
            this.btnExit = new System.Windows.Forms.Button();
            this.GbSCD.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddBC
            // 
            this.btnAddBC.Location = new System.Drawing.Point(266, 91);
            this.btnAddBC.Name = "btnAddBC";
            this.btnAddBC.Size = new System.Drawing.Size(124, 33);
            this.btnAddBC.TabIndex = 42;
            this.btnAddBC.Text = "Add Bussiness Client";
            this.btnAddBC.UseVisualStyleBackColor = true;
            this.btnAddBC.Click += new System.EventHandler(this.btnAddBC_Click);
            // 
            // btnAddIC
            // 
            this.btnAddIC.Location = new System.Drawing.Point(266, 44);
            this.btnAddIC.Name = "btnAddIC";
            this.btnAddIC.Size = new System.Drawing.Size(124, 33);
            this.btnAddIC.TabIndex = 41;
            this.btnAddIC.Text = "Add Individual Client";
            this.btnAddIC.UseVisualStyleBackColor = true;
            this.btnAddIC.Click += new System.EventHandler(this.btnAddIC_Click);
            // 
            // GbSCD
            // 
            this.GbSCD.Controls.Add(this.txtContract);
            this.GbSCD.Controls.Add(this.txtEmail);
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
            this.GbSCD.Location = new System.Drawing.Point(25, 35);
            this.GbSCD.Name = "GbSCD";
            this.GbSCD.Size = new System.Drawing.Size(220, 284);
            this.GbSCD.TabIndex = 43;
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
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(95, 160);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 17;
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
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(266, 137);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(124, 33);
            this.btnExit.TabIndex = 44;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // AddClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.GbSCD);
            this.Controls.Add(this.btnAddBC);
            this.Controls.Add(this.btnAddIC);
            this.Name = "AddClients";
            this.Text = "AddClients";
            this.Load += new System.EventHandler(this.AddClients_Load);
            this.GbSCD.ResumeLayout(false);
            this.GbSCD.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddBC;
        private System.Windows.Forms.Button btnAddIC;
        private System.Windows.Forms.GroupBox GbSCD;
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
        private System.Windows.Forms.Button btnExit;
    }
}