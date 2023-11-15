namespace Park_System.Forms
{
    partial class Frm_Login
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lnklbl_singup = new System.Windows.Forms.LinkLabel();
            this.log_btnlogin = new System.Windows.Forms.Button();
            this.log_txtusername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.log_txtpassword = new System.Windows.Forms.TextBox();
            this.lblusername = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(169)))), ((int)(((byte)(219)))));
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lnklbl_singup);
            this.groupBox1.Controls.Add(this.log_btnlogin);
            this.groupBox1.Controls.Add(this.log_txtusername);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.log_txtpassword);
            this.groupBox1.Controls.Add(this.lblusername);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.Location = new System.Drawing.Point(447, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(353, 450);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(83, 357);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "I don\'t have an account";
            // 
            // lnklbl_singup
            // 
            this.lnklbl_singup.AutoSize = true;
            this.lnklbl_singup.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnklbl_singup.Location = new System.Drawing.Point(230, 357);
            this.lnklbl_singup.Name = "lnklbl_singup";
            this.lnklbl_singup.Size = new System.Drawing.Size(52, 17);
            this.lnklbl_singup.TabIndex = 5;
            this.lnklbl_singup.TabStop = true;
            this.lnklbl_singup.Text = "Sign Up";
            this.lnklbl_singup.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklbl_singup_LinkClicked);
            // 
            // log_btnlogin
            // 
            this.log_btnlogin.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.log_btnlogin.Location = new System.Drawing.Point(247, 216);
            this.log_btnlogin.Name = "log_btnlogin";
            this.log_btnlogin.Size = new System.Drawing.Size(79, 28);
            this.log_btnlogin.TabIndex = 4;
            this.log_btnlogin.Text = "Log In";
            this.log_btnlogin.UseVisualStyleBackColor = true;
            this.log_btnlogin.Click += new System.EventHandler(this.log_btnlogin_Click);
            // 
            // log_txtusername
            // 
            this.log_txtusername.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.log_txtusername.Location = new System.Drawing.Point(133, 118);
            this.log_txtusername.Name = "log_txtusername";
            this.log_txtusername.Size = new System.Drawing.Size(193, 27);
            this.log_txtusername.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Password :";
            // 
            // log_txtpassword
            // 
            this.log_txtpassword.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.log_txtpassword.Location = new System.Drawing.Point(133, 172);
            this.log_txtpassword.Name = "log_txtpassword";
            this.log_txtpassword.Size = new System.Drawing.Size(193, 27);
            this.log_txtpassword.TabIndex = 1;
            // 
            // lblusername
            // 
            this.lblusername.AutoSize = true;
            this.lblusername.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusername.Location = new System.Drawing.Point(31, 121);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(96, 21);
            this.lblusername.TabIndex = 2;
            this.lblusername.Text = "Username :";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Park_System.Properties.Resources.Untitled_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(12, 70);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(417, 143);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(119)))), ((int)(((byte)(195)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Frm_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Log In";
            this.Load += new System.EventHandler(this.Frm_Login_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel lnklbl_singup;
        private System.Windows.Forms.Button log_btnlogin;
        private System.Windows.Forms.TextBox log_txtusername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox log_txtpassword;
        private System.Windows.Forms.Label lblusername;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}