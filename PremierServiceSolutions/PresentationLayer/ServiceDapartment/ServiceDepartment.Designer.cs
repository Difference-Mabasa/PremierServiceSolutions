
namespace PremierServiceSolutions.PresentationLayer.ServiceDapartment
{
    partial class ServiceDepartment
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
            this.Gbnav = new System.Windows.Forms.GroupBox();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnJobCompleted = new System.Windows.Forms.Button();
            this.btnAllTech = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.GbDisplayButtons = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbTech = new System.Windows.Forms.ComboBox();
            this.btnAssign = new System.Windows.Forms.Button();
            this.btnViewSchedule = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.Gbnav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.GbDisplayButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // Gbnav
            // 
            this.Gbnav.Controls.Add(this.btnLast);
            this.Gbnav.Controls.Add(this.btnNext);
            this.Gbnav.Controls.Add(this.btnPrevious);
            this.Gbnav.Controls.Add(this.btnFirst);
            this.Gbnav.Location = new System.Drawing.Point(28, 430);
            this.Gbnav.Name = "Gbnav";
            this.Gbnav.Size = new System.Drawing.Size(397, 47);
            this.Gbnav.TabIndex = 43;
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
            // btnJobCompleted
            // 
            this.btnJobCompleted.Location = new System.Drawing.Point(259, 285);
            this.btnJobCompleted.Name = "btnJobCompleted";
            this.btnJobCompleted.Size = new System.Drawing.Size(207, 33);
            this.btnJobCompleted.TabIndex = 42;
            this.btnJobCompleted.Text = "Job Completed";
            this.btnJobCompleted.UseVisualStyleBackColor = true;
            // 
            // btnAllTech
            // 
            this.btnAllTech.Location = new System.Drawing.Point(32, 285);
            this.btnAllTech.Name = "btnAllTech";
            this.btnAllTech.Size = new System.Drawing.Size(207, 33);
            this.btnAllTech.TabIndex = 40;
            this.btnAllTech.Text = "View all Technicians";
            this.btnAllTech.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(28, 51);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(554, 216);
            this.dataGridView1.TabIndex = 41;
            // 
            // GbDisplayButtons
            // 
            this.GbDisplayButtons.Controls.Add(this.label1);
            this.GbDisplayButtons.Controls.Add(this.cbTech);
            this.GbDisplayButtons.Controls.Add(this.btnAssign);
            this.GbDisplayButtons.Controls.Add(this.btnViewSchedule);
            this.GbDisplayButtons.Location = new System.Drawing.Point(605, 51);
            this.GbDisplayButtons.Name = "GbDisplayButtons";
            this.GbDisplayButtons.Size = new System.Drawing.Size(168, 152);
            this.GbDisplayButtons.TabIndex = 39;
            this.GbDisplayButtons.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 30;
            // 
            // cbTech
            // 
            this.cbTech.FormattingEnabled = true;
            this.cbTech.Location = new System.Drawing.Point(6, 19);
            this.cbTech.Name = "cbTech";
            this.cbTech.Size = new System.Drawing.Size(153, 21);
            this.cbTech.TabIndex = 29;
            this.cbTech.Text = "Available Technicians";
            // 
            // btnAssign
            // 
            this.btnAssign.Location = new System.Drawing.Point(6, 106);
            this.btnAssign.Name = "btnAssign";
            this.btnAssign.Size = new System.Drawing.Size(153, 33);
            this.btnAssign.TabIndex = 1;
            this.btnAssign.Text = "Assign";
            this.btnAssign.UseVisualStyleBackColor = true;
            // 
            // btnViewSchedule
            // 
            this.btnViewSchedule.Location = new System.Drawing.Point(6, 67);
            this.btnViewSchedule.Name = "btnViewSchedule";
            this.btnViewSchedule.Size = new System.Drawing.Size(153, 33);
            this.btnViewSchedule.TabIndex = 0;
            this.btnViewSchedule.Text = "View Schedule";
            this.btnViewSchedule.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 24);
            this.label5.TabIndex = 57;
            this.label5.Text = "Service Department";
            // 
            // ServiceDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 483);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Gbnav);
            this.Controls.Add(this.btnJobCompleted);
            this.Controls.Add(this.btnAllTech);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.GbDisplayButtons);
            this.Name = "ServiceDepartment";
            this.Text = "ServiceDepartment";
            this.Gbnav.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.GbDisplayButtons.ResumeLayout(false);
            this.GbDisplayButtons.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Gbnav;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnJobCompleted;
        private System.Windows.Forms.Button btnAllTech;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox GbDisplayButtons;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbTech;
        private System.Windows.Forms.Button btnAssign;
        private System.Windows.Forms.Button btnViewSchedule;
        private System.Windows.Forms.Label label5;
    }
}