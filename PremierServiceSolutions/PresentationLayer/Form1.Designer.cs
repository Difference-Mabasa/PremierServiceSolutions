
namespace PremierServiceSolutions.PresentationLayer
{
    partial class Form1
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
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblPass = new System.Windows.Forms.Label();
            this.lblEmpID = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
<<<<<<< HEAD
            this.btnEXIT = new System.Windows.Forms.Button();
=======
            this.btnexit = new System.Windows.Forms.Button();
>>>>>>> 988147847a7aba145285e418ef5c37e913eff339
            this.SuspendLayout();
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(147, 115);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(100, 20);
            this.txtPassword.TabIndex = 12;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(147, 50);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 11;
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Location = new System.Drawing.Point(31, 115);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(53, 13);
            this.lblPass.TabIndex = 10;
            this.lblPass.Text = "Password";
            // 
            // lblEmpID
            // 
            this.lblEmpID.AutoSize = true;
            this.lblEmpID.Location = new System.Drawing.Point(31, 57);
            this.lblEmpID.Name = "lblEmpID";
            this.lblEmpID.Size = new System.Drawing.Size(67, 13);
            this.lblEmpID.TabIndex = 9;
            this.lblEmpID.Text = "Employee ID";
            // 
            // btnLogin
            // 
<<<<<<< HEAD
            this.btnLogin.Location = new System.Drawing.Point(34, 208);
=======
            this.btnLogin.Location = new System.Drawing.Point(34, 196);
>>>>>>> 988147847a7aba145285e418ef5c37e913eff339
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(84, 34);
            this.btnLogin.TabIndex = 8;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
<<<<<<< HEAD
            // btnEXIT
            // 
            this.btnEXIT.Location = new System.Drawing.Point(163, 208);
            this.btnEXIT.Name = "btnEXIT";
            this.btnEXIT.Size = new System.Drawing.Size(84, 34);
            this.btnEXIT.TabIndex = 13;
            this.btnEXIT.Text = "EXIT";
            this.btnEXIT.UseVisualStyleBackColor = true;
            this.btnEXIT.Click += new System.EventHandler(this.btnEXIT_Click);
=======
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(163, 196);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(84, 34);
            this.btnexit.TabIndex = 13;
            this.btnexit.Text = "EXIT";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
>>>>>>> 988147847a7aba145285e418ef5c37e913eff339
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 286);
<<<<<<< HEAD
            this.Controls.Add(this.btnEXIT);
=======
            this.Controls.Add(this.btnexit);
>>>>>>> 988147847a7aba145285e418ef5c37e913eff339
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.lblEmpID);
            this.Controls.Add(this.btnLogin);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Label lblEmpID;
        private System.Windows.Forms.Button btnLogin;
<<<<<<< HEAD
        private System.Windows.Forms.Button btnEXIT;
=======
        private System.Windows.Forms.Button btnexit;
>>>>>>> 988147847a7aba145285e418ef5c37e913eff339
    }
}