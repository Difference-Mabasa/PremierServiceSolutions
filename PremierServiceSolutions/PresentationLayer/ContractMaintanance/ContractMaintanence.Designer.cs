
namespace PremierServiceSolutions.PresentationLayer.ContractMaintanance
{
    partial class ContractMaintanence
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
            this.components = new System.ComponentModel.Container();
            this.pnlDesktop = new System.Windows.Forms.Panel();
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.lblTitleChildForm = new System.Windows.Forms.Label();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ipbChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.ibtnUpdate = new FontAwesome.Sharp.IconButton();
            this.ibtnLogOout = new FontAwesome.Sharp.IconButton();
            this.ibtnContracts = new FontAwesome.Sharp.IconButton();
            this.btnHome = new System.Windows.Forms.PictureBox();
            this.pnlDesktop.SuspendLayout();
            this.pnlTitle.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            this.pnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ipbChildForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlDesktop
            // 
            this.pnlDesktop.Controls.Add(this.lblDate);
            this.pnlDesktop.Controls.Add(this.lblTime);
            this.pnlDesktop.Controls.Add(this.pictureBox1);
            this.pnlDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDesktop.Location = new System.Drawing.Point(188, 80);
            this.pnlDesktop.Name = "pnlDesktop";
            this.pnlDesktop.Size = new System.Drawing.Size(796, 681);
            this.pnlDesktop.TabIndex = 6;
            // 
            // pnlTitle
            // 
            this.pnlTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.pnlTitle.Controls.Add(this.lblTitleChildForm);
            this.pnlTitle.Controls.Add(this.ipbChildForm);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.Location = new System.Drawing.Point(188, 0);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(796, 80);
            this.pnlTitle.TabIndex = 5;
            // 
            // lblTitleChildForm
            // 
            this.lblTitleChildForm.AutoSize = true;
            this.lblTitleChildForm.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleChildForm.ForeColor = System.Drawing.Color.White;
            this.lblTitleChildForm.Location = new System.Drawing.Point(40, 33);
            this.lblTitleChildForm.Name = "lblTitleChildForm";
            this.lblTitleChildForm.Size = new System.Drawing.Size(54, 18);
            this.lblTitleChildForm.TabIndex = 1;
            this.lblTitleChildForm.Text = "Home";
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.pnlMenu.Controls.Add(this.ibtnUpdate);
            this.pnlMenu.Controls.Add(this.ibtnLogOout);
            this.pnlMenu.Controls.Add(this.ibtnContracts);
            this.pnlMenu.Controls.Add(this.pnlLogo);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(188, 761);
            this.pnlMenu.TabIndex = 4;
            // 
            // pnlLogo
            // 
            this.pnlLogo.Controls.Add(this.btnHome);
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.pnlLogo.Size = new System.Drawing.Size(188, 111);
            this.pnlLogo.TabIndex = 0;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.White;
            this.lblDate.Location = new System.Drawing.Point(292, 366);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(77, 32);
            this.lblDate.TabIndex = 5;
            this.lblDate.Text = "Date";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.White;
            this.lblTime.Location = new System.Drawing.Point(292, 319);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(79, 32);
            this.lblTime.TabIndex = 4;
            this.lblTime.Text = "Time";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PremierServiceSolutions.Properties.Resources.contract;
            this.pictureBox1.Location = new System.Drawing.Point(265, 143);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(215, 158);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // ipbChildForm
            // 
            this.ipbChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.ipbChildForm.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.ipbChildForm.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.ipbChildForm.IconColor = System.Drawing.Color.LightSeaGreen;
            this.ipbChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ipbChildForm.Location = new System.Drawing.Point(7, 27);
            this.ipbChildForm.Name = "ipbChildForm";
            this.ipbChildForm.Size = new System.Drawing.Size(32, 32);
            this.ipbChildForm.TabIndex = 0;
            this.ipbChildForm.TabStop = false;
            // 
            // ibtnUpdate
            // 
            this.ibtnUpdate.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtnUpdate.FlatAppearance.BorderSize = 0;
            this.ibtnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnUpdate.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnUpdate.ForeColor = System.Drawing.Color.White;
            this.ibtnUpdate.IconChar = FontAwesome.Sharp.IconChar.Wrench;
            this.ibtnUpdate.IconColor = System.Drawing.Color.White;
            this.ibtnUpdate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnUpdate.IconSize = 32;
            this.ibtnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnUpdate.Location = new System.Drawing.Point(0, 171);
            this.ibtnUpdate.Name = "ibtnUpdate";
            this.ibtnUpdate.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.ibtnUpdate.Size = new System.Drawing.Size(188, 60);
            this.ibtnUpdate.TabIndex = 6;
            this.ibtnUpdate.Text = "Update Contract";
            this.ibtnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnUpdate.UseVisualStyleBackColor = true;
            this.ibtnUpdate.Click += new System.EventHandler(this.ibtnUpdate_Click);
            // 
            // ibtnLogOout
            // 
            this.ibtnLogOout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ibtnLogOout.FlatAppearance.BorderSize = 0;
            this.ibtnLogOout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnLogOout.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnLogOout.ForeColor = System.Drawing.Color.White;
            this.ibtnLogOout.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.ibtnLogOout.IconColor = System.Drawing.Color.White;
            this.ibtnLogOout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnLogOout.IconSize = 40;
            this.ibtnLogOout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnLogOout.Location = new System.Drawing.Point(0, 701);
            this.ibtnLogOout.Name = "ibtnLogOout";
            this.ibtnLogOout.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.ibtnLogOout.Size = new System.Drawing.Size(188, 60);
            this.ibtnLogOout.TabIndex = 5;
            this.ibtnLogOout.Text = " Log Out";
            this.ibtnLogOout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnLogOout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnLogOout.UseVisualStyleBackColor = true;
            this.ibtnLogOout.Click += new System.EventHandler(this.ibtnLogOout_Click);
            // 
            // ibtnContracts
            // 
            this.ibtnContracts.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtnContracts.FlatAppearance.BorderSize = 0;
            this.ibtnContracts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnContracts.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnContracts.ForeColor = System.Drawing.Color.White;
            this.ibtnContracts.IconChar = FontAwesome.Sharp.IconChar.AddressCard;
            this.ibtnContracts.IconColor = System.Drawing.Color.White;
            this.ibtnContracts.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnContracts.IconSize = 40;
            this.ibtnContracts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnContracts.Location = new System.Drawing.Point(0, 111);
            this.ibtnContracts.Name = "ibtnContracts";
            this.ibtnContracts.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.ibtnContracts.Size = new System.Drawing.Size(188, 60);
            this.ibtnContracts.TabIndex = 2;
            this.ibtnContracts.Text = "Contracts";
            this.ibtnContracts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnContracts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnContracts.UseVisualStyleBackColor = true;
            this.ibtnContracts.Click += new System.EventHandler(this.ibtnContracts_Click);
            // 
            // btnHome
            // 
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnHome.Image = global::PremierServiceSolutions.Properties.Resources.call1;
            this.btnHome.Location = new System.Drawing.Point(10, 0);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(168, 111);
            this.btnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnHome.TabIndex = 0;
            this.btnHome.TabStop = false;
            // 
            // ContractMaintanence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(984, 761);
            this.Controls.Add(this.pnlDesktop);
            this.Controls.Add(this.pnlTitle);
            this.Controls.Add(this.pnlMenu);
            this.Name = "ContractMaintanence";
            this.Text = "ContractMaintanence";
            this.Load += new System.EventHandler(this.ContractMaintanence_Load);
            this.pnlDesktop.ResumeLayout(false);
            this.pnlDesktop.PerformLayout();
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            this.pnlMenu.ResumeLayout(false);
            this.pnlLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ipbChildForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDesktop;
        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Label lblTitleChildForm;
        private FontAwesome.Sharp.IconPictureBox ipbChildForm;
        private System.Windows.Forms.Panel pnlMenu;
        private FontAwesome.Sharp.IconButton ibtnLogOout;
        private FontAwesome.Sharp.IconButton ibtnContracts;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.PictureBox btnHome;
        private FontAwesome.Sharp.IconButton ibtnUpdate;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
    }
}