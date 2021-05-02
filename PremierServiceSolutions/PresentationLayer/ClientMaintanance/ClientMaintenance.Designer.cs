
namespace PremierServiceSolutions.PresentationLayer.ClientMaintanance
{
    partial class ClientMaintenance
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
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.btnMax = new FontAwesome.Sharp.IconButton();
            this.btnMin = new FontAwesome.Sharp.IconButton();
            this.lblTitleChildForm = new System.Windows.Forms.Label();
            this.ipbChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.ibtnLogOout = new FontAwesome.Sharp.IconButton();
            this.ibtnUpdateClients = new FontAwesome.Sharp.IconButton();
            this.ibtnAddClients = new FontAwesome.Sharp.IconButton();
            this.ibtnClientDetails = new FontAwesome.Sharp.IconButton();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnlDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ipbChildForm)).BeginInit();
            this.pnlMenu.SuspendLayout();
            this.pnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlDesktop
            // 
            this.pnlDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.pnlDesktop.Controls.Add(this.lblDate);
            this.pnlDesktop.Controls.Add(this.lblTime);
            this.pnlDesktop.Controls.Add(this.pictureBox1);
            this.pnlDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDesktop.Location = new System.Drawing.Point(188, 80);
            this.pnlDesktop.Name = "pnlDesktop";
            this.pnlDesktop.Size = new System.Drawing.Size(796, 581);
            this.pnlDesktop.TabIndex = 6;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.White;
            this.lblDate.Location = new System.Drawing.Point(258, 336);
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
            this.lblTime.Location = new System.Drawing.Point(258, 289);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(79, 32);
            this.lblTime.TabIndex = 4;
            this.lblTime.Text = "Time";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PremierServiceSolutions.Properties.Resources.client;
            this.pictureBox1.Location = new System.Drawing.Point(231, 113);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(215, 158);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pnlTitle
            // 
            this.pnlTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.pnlTitle.Controls.Add(this.btnClose);
            this.pnlTitle.Controls.Add(this.btnMax);
            this.pnlTitle.Controls.Add(this.btnMin);
            this.pnlTitle.Controls.Add(this.lblTitleChildForm);
            this.pnlTitle.Controls.Add(this.ipbChildForm);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.Location = new System.Drawing.Point(188, 0);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(796, 80);
            this.pnlTitle.TabIndex = 5;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Transparent;
            this.btnClose.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnClose.IconColor = System.Drawing.Color.White;
            this.btnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClose.IconSize = 15;
            this.btnClose.Location = new System.Drawing.Point(756, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(39, 15);
            this.btnClose.TabIndex = 63;
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMax
            // 
            this.btnMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMax.FlatAppearance.BorderSize = 0;
            this.btnMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMax.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMax.ForeColor = System.Drawing.Color.Transparent;
            this.btnMax.IconChar = FontAwesome.Sharp.IconChar.Square;
            this.btnMax.IconColor = System.Drawing.Color.White;
            this.btnMax.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMax.IconSize = 15;
            this.btnMax.Location = new System.Drawing.Point(730, 0);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(39, 15);
            this.btnMax.TabIndex = 62;
            this.btnMax.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMax.UseVisualStyleBackColor = true;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // btnMin
            // 
            this.btnMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMin.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMin.ForeColor = System.Drawing.Color.Transparent;
            this.btnMin.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.btnMin.IconColor = System.Drawing.Color.White;
            this.btnMin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMin.IconSize = 15;
            this.btnMin.Location = new System.Drawing.Point(701, 0);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(39, 15);
            this.btnMin.TabIndex = 61;
            this.btnMin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
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
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.pnlMenu.Controls.Add(this.ibtnLogOout);
            this.pnlMenu.Controls.Add(this.ibtnUpdateClients);
            this.pnlMenu.Controls.Add(this.ibtnAddClients);
            this.pnlMenu.Controls.Add(this.ibtnClientDetails);
            this.pnlMenu.Controls.Add(this.pnlLogo);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(188, 661);
            this.pnlMenu.TabIndex = 4;
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
            this.ibtnLogOout.Location = new System.Drawing.Point(0, 601);
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
            // ibtnUpdateClients
            // 
            this.ibtnUpdateClients.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtnUpdateClients.FlatAppearance.BorderSize = 0;
            this.ibtnUpdateClients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnUpdateClients.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnUpdateClients.ForeColor = System.Drawing.Color.White;
            this.ibtnUpdateClients.IconChar = FontAwesome.Sharp.IconChar.Wrench;
            this.ibtnUpdateClients.IconColor = System.Drawing.Color.White;
            this.ibtnUpdateClients.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnUpdateClients.IconSize = 35;
            this.ibtnUpdateClients.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnUpdateClients.Location = new System.Drawing.Point(0, 266);
            this.ibtnUpdateClients.Name = "ibtnUpdateClients";
            this.ibtnUpdateClients.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.ibtnUpdateClients.Size = new System.Drawing.Size(188, 60);
            this.ibtnUpdateClients.TabIndex = 4;
            this.ibtnUpdateClients.Text = "Update Clients";
            this.ibtnUpdateClients.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnUpdateClients.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnUpdateClients.UseVisualStyleBackColor = true;
            this.ibtnUpdateClients.Click += new System.EventHandler(this.ibtnUpdateClients_Click);
            // 
            // ibtnAddClients
            // 
            this.ibtnAddClients.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtnAddClients.FlatAppearance.BorderSize = 0;
            this.ibtnAddClients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnAddClients.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnAddClients.ForeColor = System.Drawing.Color.White;
            this.ibtnAddClients.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.ibtnAddClients.IconColor = System.Drawing.Color.White;
            this.ibtnAddClients.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnAddClients.IconSize = 40;
            this.ibtnAddClients.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnAddClients.Location = new System.Drawing.Point(0, 206);
            this.ibtnAddClients.Name = "ibtnAddClients";
            this.ibtnAddClients.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.ibtnAddClients.Size = new System.Drawing.Size(188, 60);
            this.ibtnAddClients.TabIndex = 3;
            this.ibtnAddClients.Text = "Add Clients";
            this.ibtnAddClients.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnAddClients.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnAddClients.UseVisualStyleBackColor = true;
            this.ibtnAddClients.Click += new System.EventHandler(this.ibtnAddClients_Click);
            // 
            // ibtnClientDetails
            // 
            this.ibtnClientDetails.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtnClientDetails.FlatAppearance.BorderSize = 0;
            this.ibtnClientDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnClientDetails.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnClientDetails.ForeColor = System.Drawing.Color.White;
            this.ibtnClientDetails.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.ibtnClientDetails.IconColor = System.Drawing.Color.White;
            this.ibtnClientDetails.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnClientDetails.IconSize = 40;
            this.ibtnClientDetails.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnClientDetails.Location = new System.Drawing.Point(0, 146);
            this.ibtnClientDetails.Name = "ibtnClientDetails";
            this.ibtnClientDetails.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.ibtnClientDetails.Size = new System.Drawing.Size(188, 60);
            this.ibtnClientDetails.TabIndex = 2;
            this.ibtnClientDetails.Text = "Client Details";
            this.ibtnClientDetails.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnClientDetails.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnClientDetails.UseVisualStyleBackColor = true;
            this.ibtnClientDetails.Click += new System.EventHandler(this.ibtnClientDetails_Click);
            // 
            // pnlLogo
            // 
            this.pnlLogo.Controls.Add(this.btnHome);
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.pnlLogo.Size = new System.Drawing.Size(188, 146);
            this.pnlLogo.TabIndex = 0;
            // 
            // btnHome
            // 
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnHome.Image = global::PremierServiceSolutions.Properties.Resources.pss2;
            this.btnHome.Location = new System.Drawing.Point(10, 0);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(168, 146);
            this.btnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnHome.TabIndex = 0;
            this.btnHome.TabStop = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ClientMaintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.pnlDesktop);
            this.Controls.Add(this.pnlTitle);
            this.Controls.Add(this.pnlMenu);
            this.Name = "ClientMaintenance";
            this.Text = "ClientMaintenance";
            this.Load += new System.EventHandler(this.ClientMaintenance_Load);
            this.pnlDesktop.ResumeLayout(false);
            this.pnlDesktop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ipbChildForm)).EndInit();
            this.pnlMenu.ResumeLayout(false);
            this.pnlLogo.ResumeLayout(false);
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
        private FontAwesome.Sharp.IconButton ibtnUpdateClients;
        private FontAwesome.Sharp.IconButton ibtnAddClients;
        private FontAwesome.Sharp.IconButton ibtnClientDetails;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.PictureBox btnHome;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private FontAwesome.Sharp.IconButton btnClose;
        private FontAwesome.Sharp.IconButton btnMax;
        private FontAwesome.Sharp.IconButton btnMin;
    }
}