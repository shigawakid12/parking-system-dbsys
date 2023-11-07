namespace Park_System.Forms
{
    partial class Frm_SignUp
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.log_btnlogin = new System.Windows.Forms.Button();
            this.lblrole = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblconfirmpassword = new System.Windows.Forms.Label();
            this.sign_txtconfirmpass = new System.Windows.Forms.TextBox();
            this.lblpassword = new System.Windows.Forms.Label();
            this.lblusername = new System.Windows.Forms.Label();
            this.sign_txtPassword = new System.Windows.Forms.TextBox();
            this.sign_txtUsername = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.sign_txtName = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.log_btnlogin);
            this.groupBox1.Controls.Add(this.lblrole);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.lblconfirmpassword);
            this.groupBox1.Controls.Add(this.sign_txtconfirmpass);
            this.groupBox1.Controls.Add(this.lblpassword);
            this.groupBox1.Controls.Add(this.lblusername);
            this.groupBox1.Controls.Add(this.sign_txtPassword);
            this.groupBox1.Controls.Add(this.sign_txtUsername);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Controls.Add(this.sign_txtName);
            this.groupBox1.Location = new System.Drawing.Point(22, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(257, 385);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // log_btnlogin
            // 
            this.log_btnlogin.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.log_btnlogin.Location = new System.Drawing.Point(29, 330);
            this.log_btnlogin.Name = "log_btnlogin";
            this.log_btnlogin.Size = new System.Drawing.Size(193, 28);
            this.log_btnlogin.TabIndex = 12;
            this.log_btnlogin.Text = "Register";
            this.log_btnlogin.UseVisualStyleBackColor = true;
            this.log_btnlogin.Click += new System.EventHandler(this.log_btnlogin_Click);
            // 
            // lblrole
            // 
            this.lblrole.AutoSize = true;
            this.lblrole.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrole.Location = new System.Drawing.Point(26, 257);
            this.lblrole.Name = "lblrole";
            this.lblrole.Size = new System.Drawing.Size(34, 17);
            this.lblrole.TabIndex = 11;
            this.lblrole.Text = "Role";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(29, 277);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(193, 29);
            this.comboBox1.TabIndex = 10;
            // 
            // lblconfirmpassword
            // 
            this.lblconfirmpassword.AutoSize = true;
            this.lblconfirmpassword.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblconfirmpassword.Location = new System.Drawing.Point(26, 198);
            this.lblconfirmpassword.Name = "lblconfirmpassword";
            this.lblconfirmpassword.Size = new System.Drawing.Size(112, 17);
            this.lblconfirmpassword.TabIndex = 9;
            this.lblconfirmpassword.Text = "Confirm Password";
            // 
            // sign_txtconfirmpass
            // 
            this.sign_txtconfirmpass.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sign_txtconfirmpass.Location = new System.Drawing.Point(29, 218);
            this.sign_txtconfirmpass.Name = "sign_txtconfirmpass";
            this.sign_txtconfirmpass.Size = new System.Drawing.Size(193, 27);
            this.sign_txtconfirmpass.TabIndex = 8;
            // 
            // lblpassword
            // 
            this.lblpassword.AutoSize = true;
            this.lblpassword.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpassword.Location = new System.Drawing.Point(26, 139);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(63, 17);
            this.lblpassword.TabIndex = 7;
            this.lblpassword.Text = "Password";
            // 
            // lblusername
            // 
            this.lblusername.AutoSize = true;
            this.lblusername.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusername.Location = new System.Drawing.Point(26, 83);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(67, 17);
            this.lblusername.TabIndex = 6;
            this.lblusername.Text = "Username";
            // 
            // sign_txtPassword
            // 
            this.sign_txtPassword.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sign_txtPassword.Location = new System.Drawing.Point(29, 159);
            this.sign_txtPassword.Name = "sign_txtPassword";
            this.sign_txtPassword.Size = new System.Drawing.Size(193, 27);
            this.sign_txtPassword.TabIndex = 5;
            // 
            // sign_txtUsername
            // 
            this.sign_txtUsername.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sign_txtUsername.Location = new System.Drawing.Point(29, 103);
            this.sign_txtUsername.Name = "sign_txtUsername";
            this.sign_txtUsername.Size = new System.Drawing.Size(193, 27);
            this.sign_txtUsername.TabIndex = 4;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(26, 29);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(44, 17);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Name";
            // 
            // sign_txtName
            // 
            this.sign_txtName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sign_txtName.Location = new System.Drawing.Point(29, 49);
            this.sign_txtName.Name = "sign_txtName";
            this.sign_txtName.Size = new System.Drawing.Size(193, 27);
            this.sign_txtName.TabIndex = 1;
            // 
            // Frm_SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 458);
            this.Controls.Add(this.groupBox1);
            this.Name = "Frm_SignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_SignUp";
            this.Load += new System.EventHandler(this.Frm_SignUp_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button log_btnlogin;
        private System.Windows.Forms.Label lblrole;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblconfirmpassword;
        private System.Windows.Forms.TextBox sign_txtconfirmpass;
        private System.Windows.Forms.Label lblpassword;
        private System.Windows.Forms.Label lblusername;
        private System.Windows.Forms.TextBox sign_txtPassword;
        private System.Windows.Forms.TextBox sign_txtUsername;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox sign_txtName;
    }
}