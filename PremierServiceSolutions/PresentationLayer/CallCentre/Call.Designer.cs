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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnAcceptCall = new System.Windows.Forms.PictureBox();
            this.btnDeclineCall = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAcceptCall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDeclineCall)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(289, 261);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Decline";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(358, 261);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Accept";
            this.label2.Visible = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::PremierServiceSolutions.Properties.Resources.user1;
            this.pictureBox3.Location = new System.Drawing.Point(310, 75);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(70, 70);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Visible = false;
            // 
            // btnAcceptCall
            // 
            this.btnAcceptCall.Image = global::PremierServiceSolutions.Properties.Resources.acceptCall;
            this.btnAcceptCall.Location = new System.Drawing.Point(359, 209);
            this.btnAcceptCall.Name = "btnAcceptCall";
            this.btnAcceptCall.Size = new System.Drawing.Size(40, 40);
            this.btnAcceptCall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnAcceptCall.TabIndex = 2;
            this.btnAcceptCall.TabStop = false;
            this.btnAcceptCall.Visible = false;
            this.btnAcceptCall.Click += new System.EventHandler(this.btnAcceptCall_Click);
            // 
            // btnDeclineCall
            // 
            this.btnDeclineCall.Image = global::PremierServiceSolutions.Properties.Resources.endCall;
            this.btnDeclineCall.Location = new System.Drawing.Point(292, 209);
            this.btnDeclineCall.Name = "btnDeclineCall";
            this.btnDeclineCall.Size = new System.Drawing.Size(40, 40);
            this.btnDeclineCall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnDeclineCall.TabIndex = 1;
            this.btnDeclineCall.TabStop = false;
            this.btnDeclineCall.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(288, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 24);
            this.label4.TabIndex = 7;
            this.label4.Visible = false;
            // 
            // Call
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.btnAcceptCall);
            this.Controls.Add(this.btnDeclineCall);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Call";
            this.Text = "Call";
            this.Load += new System.EventHandler(this.Call_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAcceptCall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDeclineCall)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btnDeclineCall;
        private System.Windows.Forms.PictureBox btnAcceptCall;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label4;
    }
}