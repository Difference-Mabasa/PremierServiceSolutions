
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
            this.btnBack = new FontAwesome.Sharp.IconButton();
            this.btnAddBC = new FontAwesome.Sharp.IconButton();
            this.btnAddIC = new FontAwesome.Sharp.IconButton();
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
            this.btnBack.Location = new System.Drawing.Point(266, 136);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(203, 42);
            this.btnBack.TabIndex = 62;
            this.btnBack.Text = "Back";
            this.btnBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // btnAddBC
            // 
            this.btnAddBC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddBC.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBC.ForeColor = System.Drawing.Color.White;
            this.btnAddBC.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.btnAddBC.IconColor = System.Drawing.Color.White;
            this.btnAddBC.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddBC.IconSize = 30;
            this.btnAddBC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddBC.Location = new System.Drawing.Point(266, 88);
            this.btnAddBC.Name = "btnAddBC";
            this.btnAddBC.Size = new System.Drawing.Size(203, 42);
            this.btnAddBC.TabIndex = 61;
            this.btnAddBC.Text = "Add Business Client";
            this.btnAddBC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddBC.UseVisualStyleBackColor = true;
            // 
            // btnAddIC
            // 
            this.btnAddIC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddIC.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddIC.ForeColor = System.Drawing.Color.White;
            this.btnAddIC.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.btnAddIC.IconColor = System.Drawing.Color.White;
            this.btnAddIC.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddIC.IconSize = 30;
            this.btnAddIC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddIC.Location = new System.Drawing.Point(267, 40);
            this.btnAddIC.Name = "btnAddIC";
            this.btnAddIC.Size = new System.Drawing.Size(202, 42);
            this.btnAddIC.TabIndex = 60;
            this.btnAddIC.Text = "Add Individual Client";
            this.btnAddIC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddIC.UseVisualStyleBackColor = true;
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
            this.GbCD.Location = new System.Drawing.Point(23, 30);
            this.GbCD.Name = "GbCD";
            this.GbCD.Size = new System.Drawing.Size(220, 284);
            this.GbCD.TabIndex = 59;
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
            // AddClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(781, 529);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnAddBC);
            this.Controls.Add(this.btnAddIC);
            this.Controls.Add(this.GbCD);
            this.Name = "AddClients";
            this.Text = "AddClients";
            this.Load += new System.EventHandler(this.AddClients_Load);
            this.GbCD.ResumeLayout(false);
            this.GbCD.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnBack;
        private FontAwesome.Sharp.IconButton btnAddBC;
        private FontAwesome.Sharp.IconButton btnAddIC;
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