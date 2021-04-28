
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
            this.btnAcceptCall = new System.Windows.Forms.Button();
            this.lblCall = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAcceptCall
            // 
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
            // 
            // Call
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}