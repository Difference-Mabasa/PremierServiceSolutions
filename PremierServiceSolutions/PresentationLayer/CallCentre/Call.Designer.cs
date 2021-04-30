
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
            // lblCall
            // 
            this.lblCall.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.lblCall.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblCall.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCall.ForeColor = System.Drawing.Color.White;
            this.lblCall.Location = new System.Drawing.Point(238, 158);
            this.lblCall.Name = "lblCall";
            this.lblCall.Size = new System.Drawing.Size(190, 18);
            this.lblCall.TabIndex = 13;
            this.lblCall.Text = "Incomming Call...";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 53);
            this.panel1.TabIndex = 15;
            // 
            // btnDeclineCall
            // 
            this.btnDeclineCall.Image = global::PremierServiceSolutions.Properties.Resources.endCall;
            this.btnDeclineCall.Location = new System.Drawing.Point(225, 230);
            this.btnDeclineCall.Name = "btnDeclineCall";
            this.btnDeclineCall.Size = new System.Drawing.Size(70, 70);
            this.btnDeclineCall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnDeclineCall.TabIndex = 20;
            this.btnDeclineCall.TabStop = false;
            // 
            // btnAcceptCall
            // 
            this.btnAcceptCall.Location = new System.Drawing.Point(291, 230);
            this.btnAcceptCall.Name = "btnAcceptCall";
            this.btnAcceptCall.Size = new System.Drawing.Size(70, 70);
            this.btnAcceptCall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnAcceptCall.TabIndex = 19;
            this.btnAcceptCall.TabStop = false;
            // 
            // pictureBox1
            // 
            this.lblCall.AutoSize = true;
            this.lblCall.Location = new System.Drawing.Point(357, 154);
            this.lblCall.Name = "lblCall";
            this.lblCall.Size = new System.Drawing.Size(86, 13);
            this.lblCall.TabIndex = 4;
            this.lblCall.Text = "Incomming call...";
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
            this.Controls.Add(this.btnAcceptCall);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblCall);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Call";
            this.Text = "Call";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAcceptCall;
        private System.Windows.Forms.Label lblCall;
    }
}