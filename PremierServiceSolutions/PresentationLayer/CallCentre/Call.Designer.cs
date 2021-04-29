
namespace PremierServiceSolutions.PresentationLayer.CallCentre
{
    partial class Call
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
            this.btnAcceptCall = new System.Windows.Forms.Button();
            this.lblCall = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAcceptCall
            // 
            this.btnAcceptCall.Enabled = false;
            this.btnAcceptCall.Location = new System.Drawing.Point(291, 230);
            this.btnAcceptCall.Name = "btnAcceptCall";
            this.btnAcceptCall.Size = new System.Drawing.Size(219, 66);
            this.btnAcceptCall.TabIndex = 5;
            this.btnAcceptCall.Text = "Accept call";
            this.btnAcceptCall.UseVisualStyleBackColor = true;
            this.btnAcceptCall.Click += new System.EventHandler(this.btnAcceptCall_Click);
            // 
            // lblCall
            // 
            this.lblCall.AutoSize = true;
            this.lblCall.Location = new System.Drawing.Point(357, 154);
            this.lblCall.Name = "lblCall";
            this.lblCall.Size = new System.Drawing.Size(86, 13);
            this.lblCall.TabIndex = 4;
            this.lblCall.Text = "Incomming call...";
            this.lblCall.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(259, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 22);
            this.label1.TabIndex = 6;
            this.label1.Text = "Premier Service Solution Call center";
            this.label1.Visible = false;
            // 
            // Call
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAcceptCall);
            this.Controls.Add(this.lblCall);
            this.Name = "Call";
            this.Text = "Call";
            this.Load += new System.EventHandler(this.Call_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAcceptCall;
        private System.Windows.Forms.Label lblCall;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
    }
}