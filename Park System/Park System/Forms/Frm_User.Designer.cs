namespace Park_System.Forms
{
    partial class Frm_User
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_User));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.parkSlotBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.parkSlotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parkSlotDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.auserPlatenumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.auserTypeCarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.auserTimeArriveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AuserTimeOut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parkSlotBindingSource)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.parkSlotDataGridViewTextBoxColumn,
            this.auserPlatenumDataGridViewTextBoxColumn,
            this.auserTypeCarDataGridViewTextBoxColumn,
            this.auserTimeArriveDataGridViewTextBoxColumn,
            this.AuserTimeOut});
            this.dataGridView1.DataSource = this.parkSlotBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(16, 174);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(732, 394);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_motorcycle_CellContentClick);
            // 
            // parkSlotBindingSource
            // 
            this.parkSlotBindingSource.DataSource = typeof(Park_System.Model.ParkSlot);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.Location = new System.Drawing.Point(268, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 47);
            this.label1.TabIndex = 14;
            this.label1.Text = "LEAVING ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(292, 98);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 23);
            this.label2.TabIndex = 15;
            this.label2.Text = "Parking Slots";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(764, 27);
            this.toolStrip1.TabIndex = 16;
            this.toolStrip1.Text = "Edit";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.parkSlotToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(49, 24);
            this.toolStripDropDownButton1.Text = "Edit";
            this.toolStripDropDownButton1.ToolTipText = "Edit";
            // 
            // parkSlotToolStripMenuItem
            // 
            this.parkSlotToolStripMenuItem.Name = "parkSlotToolStripMenuItem";
            this.parkSlotToolStripMenuItem.Size = new System.Drawing.Size(149, 26);
            this.parkSlotToolStripMenuItem.Text = "Park Slot";
            this.parkSlotToolStripMenuItem.Click += new System.EventHandler(this.parkSlotToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(149, 26);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click_1);
            // 
            // parkSlotDataGridViewTextBoxColumn
            // 
            this.parkSlotDataGridViewTextBoxColumn.DataPropertyName = "parkSlot";
            this.parkSlotDataGridViewTextBoxColumn.HeaderText = "Slot No.";
            this.parkSlotDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.parkSlotDataGridViewTextBoxColumn.Name = "parkSlotDataGridViewTextBoxColumn";
            this.parkSlotDataGridViewTextBoxColumn.Width = 50;
            // 
            // auserPlatenumDataGridViewTextBoxColumn
            // 
            this.auserPlatenumDataGridViewTextBoxColumn.DataPropertyName = "AuserPlatenum";
            this.auserPlatenumDataGridViewTextBoxColumn.HeaderText = "Plate No.";
            this.auserPlatenumDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.auserPlatenumDataGridViewTextBoxColumn.Name = "auserPlatenumDataGridViewTextBoxColumn";
            this.auserPlatenumDataGridViewTextBoxColumn.Width = 120;
            // 
            // auserTypeCarDataGridViewTextBoxColumn
            // 
            this.auserTypeCarDataGridViewTextBoxColumn.DataPropertyName = "AuserTypeCar";
            this.auserTypeCarDataGridViewTextBoxColumn.HeaderText = "Car Type";
            this.auserTypeCarDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.auserTypeCarDataGridViewTextBoxColumn.Name = "auserTypeCarDataGridViewTextBoxColumn";
            this.auserTypeCarDataGridViewTextBoxColumn.Width = 120;
            // 
            // auserTimeArriveDataGridViewTextBoxColumn
            // 
            this.auserTimeArriveDataGridViewTextBoxColumn.DataPropertyName = "AuserTimeArrive";
            this.auserTimeArriveDataGridViewTextBoxColumn.HeaderText = "Time Arrive";
            this.auserTimeArriveDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.auserTimeArriveDataGridViewTextBoxColumn.Name = "auserTimeArriveDataGridViewTextBoxColumn";
            this.auserTimeArriveDataGridViewTextBoxColumn.Width = 200;
            // 
            // AuserTimeOut
            // 
            this.AuserTimeOut.DataPropertyName = "AuserTimeOut";
            this.AuserTimeOut.HeaderText = "Time Out";
            this.AuserTimeOut.MinimumWidth = 6;
            this.AuserTimeOut.Name = "AuserTimeOut";
            this.AuserTimeOut.Width = 200;
            // 
            // Frm_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(103)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(764, 636);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_User";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.Frm_User_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parkSlotBindingSource)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn userPlatenumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userTypeCarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userTimeArriveDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.BindingSource parkSlotBindingSource;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem parkSlotToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn parkSlotDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn auserPlatenumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn auserTypeCarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn auserTimeArriveDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AuserTimeOut;
    }
}