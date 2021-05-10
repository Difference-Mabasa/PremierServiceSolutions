﻿namespace PremierServiceSolutions.PresentationLayer.ContractMaintanance
{
    partial class UpdateContract
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
            this.btnBack = new FontAwesome.Sharp.IconButton();
            this.btnUpdate = new FontAwesome.Sharp.IconButton();
            this.GbCD = new System.Windows.Forms.GroupBox();
            this.txtContract = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblBP = new System.Windows.Forms.Label();
            this.lblContract = new System.Windows.Forms.Label();
            this.lblIP = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblDes = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.ContractID = new System.Windows.Forms.Label();
            this.GbCD.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.IconChar = FontAwesome.Sharp.IconChar.Backward;
            this.btnBack.IconColor = System.Drawing.Color.White;
            this.btnBack.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBack.IconSize = 30;
            this.btnBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBack.Location = new System.Drawing.Point(407, 140);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(271, 52);
            this.btnBack.TabIndex = 66;
            this.btnBack.Text = "Back";
            this.btnBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.IconChar = FontAwesome.Sharp.IconChar.Wrench;
            this.btnUpdate.IconColor = System.Drawing.Color.White;
            this.btnUpdate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUpdate.IconSize = 30;
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Location = new System.Drawing.Point(407, 63);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(269, 52);
            this.btnUpdate.TabIndex = 64;
            this.btnUpdate.Text = "Update Contract";
            this.btnUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
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
            this.GbCD.Controls.Add(this.lblBP);
            this.GbCD.Controls.Add(this.lblContract);
            this.GbCD.Controls.Add(this.lblIP);
            this.GbCD.Controls.Add(this.lblAddress);
            this.GbCD.Controls.Add(this.lblDes);
            this.GbCD.Controls.Add(this.lblType);
            this.GbCD.Controls.Add(this.ContractID);
            this.GbCD.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbCD.ForeColor = System.Drawing.Color.White;
            this.GbCD.Location = new System.Drawing.Point(45, 50);
            this.GbCD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GbCD.Name = "GbCD";
            this.GbCD.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GbCD.Size = new System.Drawing.Size(353, 350);
            this.GbCD.TabIndex = 63;
            this.GbCD.TabStop = false;
            this.GbCD.Text = "Contract Details";
            // 
            // txtContract
            // 
            this.txtContract.Location = new System.Drawing.Point(179, 283);
            this.txtContract.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtContract.Name = "txtContract";
            this.txtContract.Size = new System.Drawing.Size(132, 26);
            this.txtContract.TabIndex = 18;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(179, 197);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(132, 26);
            this.txtEmail.TabIndex = 17;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(179, 69);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(132, 26);
            this.txtName.TabIndex = 16;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(179, 105);
            this.txtSurname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(132, 26);
            this.txtSurname.TabIndex = 15;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(179, 239);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(132, 26);
            this.txtAddress.TabIndex = 14;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(179, 150);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(132, 26);
            this.txtPhone.TabIndex = 13;
            // 
            // txtID
            // 
            this.txtID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtID.Location = new System.Drawing.Point(179, 27);
            this.txtID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(132, 26);
            this.txtID.TabIndex = 12;
            // 
            // lblBP
            // 
            this.lblBP.AutoSize = true;
            this.lblBP.Location = new System.Drawing.Point(20, 197);
            this.lblBP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBP.Name = "lblBP";
            this.lblBP.Size = new System.Drawing.Size(130, 20);
            this.lblBP.TabIndex = 11;
            this.lblBP.Text = "Business Price";
            // 
            // lblContract
            // 
            this.lblContract.AutoSize = true;
            this.lblContract.Location = new System.Drawing.Point(19, 283);
            this.lblContract.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContract.Name = "lblContract";
            this.lblContract.Size = new System.Drawing.Size(81, 20);
            this.lblContract.TabIndex = 10;
            this.lblContract.Text = "Contract";
            // 
            // lblIP
            // 
            this.lblIP.AutoSize = true;
            this.lblIP.Location = new System.Drawing.Point(20, 150);
            this.lblIP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIP.Name = "lblIP";
            this.lblIP.Size = new System.Drawing.Size(137, 20);
            this.lblIP.TabIndex = 4;
            this.lblIP.Text = "Individual Price";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(19, 242);
            this.lblAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(78, 20);
            this.lblAddress.TabIndex = 3;
            this.lblAddress.Text = "Address";
            // 
            // lblDes
            // 
            this.lblDes.AutoSize = true;
            this.lblDes.Location = new System.Drawing.Point(20, 105);
            this.lblDes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDes.Name = "lblDes";
            this.lblDes.Size = new System.Drawing.Size(105, 20);
            this.lblDes.TabIndex = 2;
            this.lblDes.Text = "Description";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(20, 69);
            this.lblType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(126, 20);
            this.lblType.TabIndex = 1;
            this.lblType.Text = "Contract Type";
            // 
            // ContractID
            // 
            this.ContractID.AutoSize = true;
            this.ContractID.Location = new System.Drawing.Point(19, 36);
            this.ContractID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ContractID.Name = "ContractID";
            this.ContractID.Size = new System.Drawing.Size(99, 20);
            this.ContractID.TabIndex = 0;
            this.ContractID.Text = "ContractID";
            // 
            // UpdateContract
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(1041, 651);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.GbCD);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UpdateContract";
            this.Text = "UpdateContract";
            this.GbCD.ResumeLayout(false);
            this.GbCD.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnBack;
        private FontAwesome.Sharp.IconButton btnUpdate;
        private System.Windows.Forms.GroupBox GbCD;
        private System.Windows.Forms.TextBox txtContract;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblBP;
        private System.Windows.Forms.Label lblContract;
        private System.Windows.Forms.Label lblIP;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblDes;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label ContractID;
    }
}