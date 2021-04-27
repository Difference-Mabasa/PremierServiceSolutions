
namespace PremierServiceSolutions.PresentationLayer.CallCentre
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
            this.btnPhone = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvPreviousRequest = new System.Windows.Forms.DataGridView();
            this.GbSearchStud = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearchClient = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.Gbnav = new System.Windows.Forms.GroupBox();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.dgvClientDetails = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPreviousRequest)).BeginInit();
            this.GbSearchStud.SuspendLayout();
            this.Gbnav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPhone
            // 
            this.btnPhone.Location = new System.Drawing.Point(576, 68);
            this.btnPhone.Name = "btnPhone";
            this.btnPhone.Size = new System.Drawing.Size(148, 38);
            this.btnPhone.TabIndex = 54;
            this.btnPhone.Text = "View by Phone number";
            this.btnPhone.UseVisualStyleBackColor = true;
            this.btnPhone.Click += new System.EventHandler(this.btnPhone_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(237, 437);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(118, 52);
            this.btnAdd.TabIndex = 53;
            this.btnAdd.Text = "Add Request";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(36, 437);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(118, 52);
            this.btnUpdate.TabIndex = 52;
            this.btnUpdate.Text = "Update Request";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 24);
            this.label3.TabIndex = 51;
            this.label3.Text = "Previous Request";
            // 
            // dgvPreviousRequest
            // 
            this.dgvPreviousRequest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPreviousRequest.Location = new System.Drawing.Point(36, 269);
            this.dgvPreviousRequest.Name = "dgvPreviousRequest";
            this.dgvPreviousRequest.Size = new System.Drawing.Size(508, 152);
            this.dgvPreviousRequest.TabIndex = 50;
            this.dgvPreviousRequest.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPreviousRequest_CellContentClick);
            // 
            // GbSearchStud
            // 
            this.GbSearchStud.Controls.Add(this.btnSearch);
            this.GbSearchStud.Controls.Add(this.txtSearchClient);
            this.GbSearchStud.Controls.Add(this.label2);
            this.GbSearchStud.Location = new System.Drawing.Point(576, 116);
            this.GbSearchStud.Name = "GbSearchStud";
            this.GbSearchStud.Size = new System.Drawing.Size(148, 117);
            this.GbSearchStud.TabIndex = 49;
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
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearchClient
            // 
            this.txtSearchClient.Location = new System.Drawing.Point(9, 38);
            this.txtSearchClient.Name = "txtSearchClient";
            this.txtSearchClient.Size = new System.Drawing.Size(130, 20);
            this.txtSearchClient.TabIndex = 1;
            this.txtSearchClient.TextChanged += new System.EventHandler(this.txtSearchClient_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Enter Client Details";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(576, 24);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(148, 38);
            this.btnExit.TabIndex = 48;
            this.btnExit.Text = "End";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Gbnav
            // 
            this.Gbnav.Controls.Add(this.btnLast);
            this.Gbnav.Controls.Add(this.btnNext);
            this.Gbnav.Controls.Add(this.btnPrevious);
            this.Gbnav.Controls.Add(this.btnFirst);
            this.Gbnav.Location = new System.Drawing.Point(27, 505);
            this.Gbnav.Name = "Gbnav";
            this.Gbnav.Size = new System.Drawing.Size(397, 47);
            this.Gbnav.TabIndex = 47;
            this.Gbnav.TabStop = false;
            this.Gbnav.Text = "Navigation";
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(303, 18);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(75, 23);
            this.btnLast.TabIndex = 3;
            this.btnLast.Text = ">|";
            this.btnLast.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(108, 19);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = ">>";
            this.btnNext.UseVisualStyleBackColor = true;
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(204, 19);
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
            // dgvClientDetails
            // 
            this.dgvClientDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientDetails.Location = new System.Drawing.Point(36, 48);
            this.dgvClientDetails.Name = "dgvClientDetails";
            this.dgvClientDetails.Size = new System.Drawing.Size(508, 152);
            this.dgvClientDetails.TabIndex = 46;
            this.dgvClientDetails.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientDetails_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 24);
            this.label1.TabIndex = 45;
            this.label1.Text = "Client Details";
            // 
            // ClientDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 574);
            this.Controls.Add(this.btnPhone);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvPreviousRequest);
            this.Controls.Add(this.GbSearchStud);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.Gbnav);
            this.Controls.Add(this.dgvClientDetails);
            this.Controls.Add(this.label1);
            this.Name = "ClientDetails";
            this.Text = "ClientDetails";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPreviousRequest)).EndInit();
            this.GbSearchStud.ResumeLayout(false);
            this.GbSearchStud.PerformLayout();
            this.Gbnav.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPhone;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvPreviousRequest;
        private System.Windows.Forms.GroupBox GbSearchStud;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearchClient;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox Gbnav;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.DataGridView dgvClientDetails;
        private System.Windows.Forms.Label label1;
    }
}