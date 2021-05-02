
namespace PremierServiceSolutions.PresentationLayer.ServiceDapartment
{
    partial class Technicians
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
            this.btnJobCompleted = new System.Windows.Forms.Button();
            this.btnAllTech = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.GbDisplayButtons = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbTech = new System.Windows.Forms.ComboBox();
            this.btnAssign = new System.Windows.Forms.Button();
            this.btnViewSchedule = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.GbDisplayButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnJobCompleted
            // 
            this.btnJobCompleted.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJobCompleted.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJobCompleted.ForeColor = System.Drawing.Color.White;
            this.btnJobCompleted.Location = new System.Drawing.Point(345, 351);
            this.btnJobCompleted.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnJobCompleted.Name = "btnJobCompleted";
            this.btnJobCompleted.Size = new System.Drawing.Size(276, 41);
            this.btnJobCompleted.TabIndex = 42;
            this.btnJobCompleted.Text = "Job Completed";
            this.btnJobCompleted.UseVisualStyleBackColor = true;
            // 
            // btnAllTech
            // 
            this.btnAllTech.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAllTech.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllTech.ForeColor = System.Drawing.Color.White;
            this.btnAllTech.Location = new System.Drawing.Point(43, 351);
            this.btnAllTech.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAllTech.Name = "btnAllTech";
            this.btnAllTech.Size = new System.Drawing.Size(276, 41);
            this.btnAllTech.TabIndex = 40;
            this.btnAllTech.Text = "View all Technicians";
            this.btnAllTech.UseVisualStyleBackColor = true;
            this.btnAllTech.Click += new System.EventHandler(this.btnAllTech_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(37, 63);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(739, 266);
            this.dataGridView1.TabIndex = 41;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // GbDisplayButtons
            // 
            this.GbDisplayButtons.Controls.Add(this.label1);
            this.GbDisplayButtons.Controls.Add(this.cbTech);
            this.GbDisplayButtons.Controls.Add(this.btnAssign);
            this.GbDisplayButtons.Controls.Add(this.btnViewSchedule);
            this.GbDisplayButtons.Cursor = System.Windows.Forms.Cursors.Default;
            this.GbDisplayButtons.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GbDisplayButtons.Location = new System.Drawing.Point(807, 63);
            this.GbDisplayButtons.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GbDisplayButtons.Name = "GbDisplayButtons";
            this.GbDisplayButtons.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GbDisplayButtons.Size = new System.Drawing.Size(224, 187);
            this.GbDisplayButtons.TabIndex = 39;
            this.GbDisplayButtons.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 30;
            // 
            // cbTech
            // 
            this.cbTech.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTech.FormattingEnabled = true;
            this.cbTech.Location = new System.Drawing.Point(8, 23);
            this.cbTech.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbTech.Name = "cbTech";
            this.cbTech.Size = new System.Drawing.Size(203, 26);
            this.cbTech.TabIndex = 29;
            this.cbTech.Text = "Available Technicians";
            // 
            // btnAssign
            // 
            this.btnAssign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAssign.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAssign.ForeColor = System.Drawing.Color.White;
            this.btnAssign.Location = new System.Drawing.Point(8, 130);
            this.btnAssign.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAssign.Name = "btnAssign";
            this.btnAssign.Size = new System.Drawing.Size(204, 41);
            this.btnAssign.TabIndex = 1;
            this.btnAssign.Text = "Assign";
            this.btnAssign.UseVisualStyleBackColor = true;
            this.btnAssign.Click += new System.EventHandler(this.btnAssign_Click);
            // 
            // btnViewSchedule
            // 
            this.btnViewSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewSchedule.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewSchedule.ForeColor = System.Drawing.Color.White;
            this.btnViewSchedule.Location = new System.Drawing.Point(8, 82);
            this.btnViewSchedule.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnViewSchedule.Name = "btnViewSchedule";
            this.btnViewSchedule.Size = new System.Drawing.Size(204, 41);
            this.btnViewSchedule.TabIndex = 0;
            this.btnViewSchedule.Text = "View Schedule";
            this.btnViewSchedule.UseVisualStyleBackColor = true;
            // 
            // Technicians
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(1067, 594);
            this.Controls.Add(this.btnJobCompleted);
            this.Controls.Add(this.btnAllTech);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.GbDisplayButtons);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Technicians";
            this.Text = "Technicians";
            this.Load += new System.EventHandler(this.Technicians_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.GbDisplayButtons.ResumeLayout(false);
            this.GbDisplayButtons.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnJobCompleted;
        private System.Windows.Forms.Button btnAllTech;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox GbDisplayButtons;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbTech;
        private System.Windows.Forms.Button btnAssign;
        private System.Windows.Forms.Button btnViewSchedule;
    }
}