namespace Park_System.Forms
{
    partial class Frm_Employee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Employee));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Emp_txtPlateno = new System.Windows.Forms.TextBox();
            this.Emp_txtCarbrand = new System.Windows.Forms.TextBox();
            this.Emp_txtDateEnter = new System.Windows.Forms.TextBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.userManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.parkingDataSet = new Park_System.ParkingDataSet();
            this.parkSlotTableAdapter = new Park_System.ParkingDataSetTableAdapters.ParkSlotTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_print = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.Emp_cbSlot = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.parkSlotDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.auserPlatenumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.auserTypeCarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.auserTimeArriveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parkSlotBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parkingDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parkSlotBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 79);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Plate No.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 154);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Car Brand";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 228);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Date Entered";
            // 
            // Emp_txtPlateno
            // 
            this.Emp_txtPlateno.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Emp_txtPlateno.Location = new System.Drawing.Point(37, 108);
            this.Emp_txtPlateno.Margin = new System.Windows.Forms.Padding(4);
            this.Emp_txtPlateno.Name = "Emp_txtPlateno";
            this.Emp_txtPlateno.Size = new System.Drawing.Size(341, 32);
            this.Emp_txtPlateno.TabIndex = 4;
            // 
            // Emp_txtCarbrand
            // 
            this.Emp_txtCarbrand.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Emp_txtCarbrand.Location = new System.Drawing.Point(37, 183);
            this.Emp_txtCarbrand.Margin = new System.Windows.Forms.Padding(4);
            this.Emp_txtCarbrand.Name = "Emp_txtCarbrand";
            this.Emp_txtCarbrand.Size = new System.Drawing.Size(341, 32);
            this.Emp_txtCarbrand.TabIndex = 5;
            this.Emp_txtCarbrand.TextChanged += new System.EventHandler(this.Emp_txtCarbrand_TextChanged);
            // 
            // Emp_txtDateEnter
            // 
            this.Emp_txtDateEnter.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Emp_txtDateEnter.Location = new System.Drawing.Point(36, 257);
            this.Emp_txtDateEnter.Margin = new System.Windows.Forms.Padding(4);
            this.Emp_txtDateEnter.Name = "Emp_txtDateEnter";
            this.Emp_txtDateEnter.Size = new System.Drawing.Size(343, 32);
            this.Emp_txtDateEnter.TabIndex = 7;
            // 
            // btn_Save
            // 
            this.btn_Save.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.Location = new System.Drawing.Point(33, 401);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(115, 39);
            this.btn_Save.TabIndex = 8;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update.Location = new System.Drawing.Point(160, 401);
            this.btn_Update.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(115, 39);
            this.btn_Update.TabIndex = 9;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(119)))), ((int)(((byte)(195)))));
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1124, 31);
            this.toolStrip1.TabIndex = 15;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userManagementToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(49, 28);
            this.toolStripDropDownButton1.Text = "Edit";
            // 
            // userManagementToolStripMenuItem
            // 
            this.userManagementToolStripMenuItem.Name = "userManagementToolStripMenuItem";
            this.userManagementToolStripMenuItem.Size = new System.Drawing.Size(213, 26);
            this.userManagementToolStripMenuItem.Text = "User Management";
            this.userManagementToolStripMenuItem.Click += new System.EventHandler(this.userManagementToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(213, 26);
            this.logOutToolStripMenuItem.Text = "Log Out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click_1);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // parkingDataSet
            // 
            this.parkingDataSet.DataSetName = "ParkingDataSet";
            this.parkingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // parkSlotTableAdapter
            // 
            this.parkSlotTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.parkSlotDataGridViewTextBoxColumn,
            this.auserPlatenumDataGridViewTextBoxColumn,
            this.auserTypeCarDataGridViewTextBoxColumn,
            this.auserTimeArriveDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.parkSlotBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(408, 108);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(700, 287);
            this.dataGridView1.TabIndex = 18;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // btn_print
            // 
            this.btn_print.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_print.Location = new System.Drawing.Point(283, 401);
            this.btn_print.Margin = new System.Windows.Forms.Padding(4);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(115, 39);
            this.btn_print.TabIndex = 19;
            this.btn_print.Text = "Print";
            this.btn_print.UseVisualStyleBackColor = true;
            // 
            // Emp_cbSlot
            // 
            this.Emp_cbSlot.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Emp_cbSlot.FormattingEnabled = true;
            this.Emp_cbSlot.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.Emp_cbSlot.Location = new System.Drawing.Point(33, 332);
            this.Emp_cbSlot.Margin = new System.Windows.Forms.Padding(4);
            this.Emp_cbSlot.Name = "Emp_cbSlot";
            this.Emp_cbSlot.Size = new System.Drawing.Size(341, 31);
            this.Emp_cbSlot.TabIndex = 20;
            this.Emp_cbSlot.SelectedIndexChanged += new System.EventHandler(this.Emp_cbSlot_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 303);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 23);
            this.label3.TabIndex = 21;
            this.label3.Text = "Park Slot";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // parkSlotDataGridViewTextBoxColumn
            // 
            this.parkSlotDataGridViewTextBoxColumn.DataPropertyName = "parkSlot";
            this.parkSlotDataGridViewTextBoxColumn.HeaderText = "Slot No.";
            this.parkSlotDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.parkSlotDataGridViewTextBoxColumn.Name = "parkSlotDataGridViewTextBoxColumn";
            this.parkSlotDataGridViewTextBoxColumn.Width = 125;
            // 
            // auserPlatenumDataGridViewTextBoxColumn
            // 
            this.auserPlatenumDataGridViewTextBoxColumn.DataPropertyName = "AuserPlatenum";
            this.auserPlatenumDataGridViewTextBoxColumn.HeaderText = "Plate Number";
            this.auserPlatenumDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.auserPlatenumDataGridViewTextBoxColumn.Name = "auserPlatenumDataGridViewTextBoxColumn";
            this.auserPlatenumDataGridViewTextBoxColumn.Width = 130;
            // 
            // auserTypeCarDataGridViewTextBoxColumn
            // 
            this.auserTypeCarDataGridViewTextBoxColumn.DataPropertyName = "AuserTypeCar";
            this.auserTypeCarDataGridViewTextBoxColumn.HeaderText = "Car Type";
            this.auserTypeCarDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.auserTypeCarDataGridViewTextBoxColumn.Name = "auserTypeCarDataGridViewTextBoxColumn";
            this.auserTypeCarDataGridViewTextBoxColumn.Width = 130;
            // 
            // auserTimeArriveDataGridViewTextBoxColumn
            // 
            this.auserTimeArriveDataGridViewTextBoxColumn.DataPropertyName = "AuserTimeArrive";
            this.auserTimeArriveDataGridViewTextBoxColumn.HeaderText = "Time Arrive";
            this.auserTimeArriveDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.auserTimeArriveDataGridViewTextBoxColumn.Name = "auserTimeArriveDataGridViewTextBoxColumn";
            this.auserTimeArriveDataGridViewTextBoxColumn.Width = 135;
            // 
            // parkSlotBindingSource
            // 
            this.parkSlotBindingSource.DataSource = typeof(Park_System.Model.ParkSlot);
            // 
            // Frm_Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(169)))), ((int)(((byte)(219)))));
            this.ClientSize = new System.Drawing.Size(1124, 481);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Emp_cbSlot);
            this.Controls.Add(this.btn_print);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.Emp_txtDateEnter);
            this.Controls.Add(this.Emp_txtCarbrand);
            this.Controls.Add(this.Emp_txtPlateno);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_Employee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Dashboard";
            this.Load += new System.EventHandler(this.Frm_Employee_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parkingDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parkSlotBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Emp_txtPlateno;
        private System.Windows.Forms.TextBox Emp_txtCarbrand;
        private System.Windows.Forms.TextBox Emp_txtDateEnter;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem userManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private ParkingDataSet parkingDataSet;
        private ParkingDataSetTableAdapters.ParkSlotTableAdapter parkSlotTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_print;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.DataGridViewTextBoxColumn userPlatenumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userTypeCarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userTimeArriveDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userTimeOutDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource parkSlotBindingSource;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Emp_cbSlot;
        private System.Windows.Forms.DataGridViewTextBoxColumn parkSlotDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn auserPlatenumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn auserTypeCarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn auserTimeArriveDataGridViewTextBoxColumn;
    }
}