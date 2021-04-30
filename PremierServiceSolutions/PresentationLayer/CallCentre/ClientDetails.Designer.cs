
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
            this.dgvClientDetails = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPreviousRequest)).BeginInit();
            this.GbSearchStud.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPhone
            // 
            this.btnPhone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPhone.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhone.ForeColor = System.Drawing.Color.White;
            this.btnPhone.Location = new System.Drawing.Point(625, 104);
            this.btnPhone.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnPhone.Name = "btnPhone";
            this.btnPhone.Size = new System.Drawing.Size(166, 44);
            this.btnPhone.TabIndex = 54;
            this.btnPhone.Text = "View by Phone number";
            this.btnPhone.UseVisualStyleBackColor = true;
            this.btnPhone.Click += new System.EventHandler(this.btnPhone_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(625, 406);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(157, 60);
            this.btnAdd.TabIndex = 53;
            this.btnAdd.Text = "Add Request";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(625, 325);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(157, 60);
            this.btnUpdate.TabIndex = 52;
            this.btnUpdate.Text = "Update Request";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(43, 279);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 24);
            this.label3.TabIndex = 51;
            this.label3.Text = "Previous Request";
            // 
            // dgvPreviousRequest
            // 
            this.dgvPreviousRequest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPreviousRequest.Location = new System.Drawing.Point(48, 310);
            this.dgvPreviousRequest.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvPreviousRequest.Name = "dgvPreviousRequest";
            this.dgvPreviousRequest.Size = new System.Drawing.Size(559, 175);
            this.dgvPreviousRequest.TabIndex = 50;
            this.dgvPreviousRequest.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPreviousRequest_CellContentClick);
            // 
            // GbSearchStud
            // 
            this.GbSearchStud.Controls.Add(this.btnSearch);
            this.GbSearchStud.Controls.Add(this.txtSearchClient);
            this.GbSearchStud.Controls.Add(this.label2);
            this.GbSearchStud.ForeColor = System.Drawing.Color.White;
            this.GbSearchStud.Location = new System.Drawing.Point(625, 160);
            this.GbSearchStud.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.GbSearchStud.Name = "GbSearchStud";
            this.GbSearchStud.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.GbSearchStud.Size = new System.Drawing.Size(166, 135);
            this.GbSearchStud.TabIndex = 49;
            this.GbSearchStud.TabStop = false;
            this.GbSearchStud.Text = "Search Client";
            // 
            // btnSearch
            // 
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(12, 74);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(145, 38);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search client";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearchClient
            // 
            this.txtSearchClient.Location = new System.Drawing.Point(12, 44);
            this.txtSearchClient.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSearchClient.Name = "txtSearchClient";
            this.txtSearchClient.Size = new System.Drawing.Size(145, 23);
            this.txtSearchClient.TabIndex = 1;
            this.txtSearchClient.TextChanged += new System.EventHandler(this.txtSearchClient_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Enter Client Details";
            // 
            // btnExit
            // 
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(625, 54);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(166, 44);
            this.btnExit.TabIndex = 48;
            this.btnExit.Text = "End";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // dgvClientDetails
            // 
            this.dgvClientDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientDetails.Location = new System.Drawing.Point(48, 55);
            this.dgvClientDetails.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvClientDetails.Name = "dgvClientDetails";
            this.dgvClientDetails.Size = new System.Drawing.Size(559, 175);
            this.dgvClientDetails.TabIndex = 46;
            this.dgvClientDetails.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientDetails_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(48, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 24);
            this.label1.TabIndex = 45;
            this.label1.Text = "Client Details";
            // 
            // ClientDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(797, 568);
            this.Controls.Add(this.btnPhone);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvPreviousRequest);
            this.Controls.Add(this.GbSearchStud);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.dgvClientDetails);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "ClientDetails";
            this.Text = "ClientDetails";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPreviousRequest)).EndInit();
            this.GbSearchStud.ResumeLayout(false);
            this.GbSearchStud.PerformLayout();
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
        private System.Windows.Forms.DataGridView dgvClientDetails;
        private System.Windows.Forms.Label label1;
    }
}