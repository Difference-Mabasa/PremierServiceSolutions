
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
            this.lblCall = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDeclineCall = new System.Windows.Forms.PictureBox();
            this.btnAcceptCall = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnDeclineCall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAcceptCall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.btnAcceptCall.Image = global::PremierServiceSolutions.Properties.Resources.acceptCall;
            this.btnAcceptCall.Location = new System.Drawing.Point(330, 230);
            this.btnAcceptCall.Name = "btnAcceptCall";
            this.btnAcceptCall.Size = new System.Drawing.Size(70, 70);
            this.btnAcceptCall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnAcceptCall.TabIndex = 19;
            this.btnAcceptCall.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PremierServiceSolutions.Properties.Resources.call;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(79, 53);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Call
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(660, 449);
            this.Controls.Add(this.btnDeclineCall);
            this.Controls.Add(this.btnAcceptCall);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblCall);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Call";
            this.Text = "Call";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnDeclineCall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAcceptCall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox lblCall;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox btnAcceptCall;
        private System.Windows.Forms.PictureBox btnDeclineCall;
    }
}