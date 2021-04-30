
namespace PremierServiceSolutions.PresentationLayer.ClientSatisfaction
{
    partial class ClientSatisfaction
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
            this.rtbMessage = new System.Windows.Forms.RichTextBox();
            this.btnAnswer = new System.Windows.Forms.Button();
            this.btnEndCall = new System.Windows.Forms.Button();
            this.GbDisplayButtons = new System.Windows.Forms.GroupBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnReopen = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.GbDisplayButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // rtbMessage
            // 
            this.rtbMessage.Location = new System.Drawing.Point(395, 280);
            this.rtbMessage.Name = "rtbMessage";
            this.rtbMessage.Size = new System.Drawing.Size(187, 96);
            this.rtbMessage.TabIndex = 54;
            this.rtbMessage.Text = "Message box to hear why client is not happy";
            // 
            // btnAnswer
            // 
            this.btnAnswer.Location = new System.Drawing.Point(211, 343);
            this.btnAnswer.Name = "btnAnswer";
            this.btnAnswer.Size = new System.Drawing.Size(163, 33);
            this.btnAnswer.TabIndex = 53;
            this.btnAnswer.Text = "Initiate Call";
            this.btnAnswer.UseVisualStyleBackColor = true;
            // 
            // btnEndCall
            // 
            this.btnEndCall.Location = new System.Drawing.Point(28, 343);
            this.btnEndCall.Name = "btnEndCall";
            this.btnEndCall.Size = new System.Drawing.Size(163, 33);
            this.btnEndCall.TabIndex = 49;
            this.btnEndCall.Text = "End Call";
            this.btnEndCall.UseVisualStyleBackColor = true;
            // 
            // GbDisplayButtons
            // 
            this.GbDisplayButtons.Controls.Add(this.comboBox2);
            this.GbDisplayButtons.Controls.Add(this.comboBox1);
            this.GbDisplayButtons.Controls.Add(this.btnReopen);
            this.GbDisplayButtons.Location = new System.Drawing.Point(612, 49);
            this.GbDisplayButtons.Name = "GbDisplayButtons";
            this.GbDisplayButtons.Size = new System.Drawing.Size(181, 144);
            this.GbDisplayButtons.TabIndex = 52;
            this.GbDisplayButtons.TabStop = false;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(12, 108);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(163, 21);
            this.comboBox2.TabIndex = 31;
            this.comboBox2.Text = "Rate Call";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 71);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(163, 21);
            this.comboBox1.TabIndex = 30;
            this.comboBox1.Text = "Forward/Close Job";
            // 
            // btnReopen
            // 
            this.btnReopen.Location = new System.Drawing.Point(12, 24);
            this.btnReopen.Name = "btnReopen";
            this.btnReopen.Size = new System.Drawing.Size(163, 33);
            this.btnReopen.TabIndex = 0;
            this.btnReopen.Text = "Re-open";
            this.btnReopen.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(28, 49);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(554, 216);
            this.dataGridView1.TabIndex = 50;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 24);
            this.label1.TabIndex = 55;
            this.label1.Text = "Client Satisfaction";
            // 
            // ClientSatisfaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 479);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtbMessage);
            this.Controls.Add(this.btnAnswer);
            this.Controls.Add(this.btnEndCall);
            this.Controls.Add(this.GbDisplayButtons);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ClientSatisfaction";
            this.Text = "ClientSatisfaction";
            this.GbDisplayButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbMessage;
        private System.Windows.Forms.Button btnAnswer;
        private System.Windows.Forms.Button btnEndCall;
        private System.Windows.Forms.GroupBox GbDisplayButtons;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnReopen;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
    }
}