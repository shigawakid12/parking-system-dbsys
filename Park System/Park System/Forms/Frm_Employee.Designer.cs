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
            this.btn_Delete = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.userManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.Emp_lblslot = new System.Windows.Forms.Label();
            this.Emp_txtSlot = new System.Windows.Forms.TextBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.parkingDataSet = new Park_System.ParkingDataSet();
            this.parkSlotTableAdapter = new Park_System.ParkingDataSetTableAdapters.ParkSlotTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.parkSlotBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.parkSlotDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userPlatenumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userTypeCarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userTimeArriveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userTimeOutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.label1.Location = new System.Drawing.Point(24, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Plate No.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Car Brand";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Date Entered";
            // 
            // Emp_txtPlateno
            // 
            this.Emp_txtPlateno.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Emp_txtPlateno.Location = new System.Drawing.Point(28, 88);
            this.Emp_txtPlateno.Name = "Emp_txtPlateno";
            this.Emp_txtPlateno.Size = new System.Drawing.Size(257, 27);
            this.Emp_txtPlateno.TabIndex = 4;
            // 
            // Emp_txtCarbrand
            // 
            this.Emp_txtCarbrand.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Emp_txtCarbrand.Location = new System.Drawing.Point(28, 149);
            this.Emp_txtCarbrand.Name = "Emp_txtCarbrand";
            this.Emp_txtCarbrand.Size = new System.Drawing.Size(257, 27);
            this.Emp_txtCarbrand.TabIndex = 5;
            // 
            // Emp_txtDateEnter
            // 
            this.Emp_txtDateEnter.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Emp_txtDateEnter.Location = new System.Drawing.Point(27, 209);
            this.Emp_txtDateEnter.Name = "Emp_txtDateEnter";
            this.Emp_txtDateEnter.Size = new System.Drawing.Size(258, 27);
            this.Emp_txtDateEnter.TabIndex = 7;
            // 
            // btn_Save
            // 
            this.btn_Save.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.Location = new System.Drawing.Point(27, 335);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(86, 32);
            this.btn_Save.TabIndex = 8;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update.Location = new System.Drawing.Point(119, 335);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(86, 32);
            this.btn_Update.TabIndex = 9;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = true;
            // 
            // btn_Delete
            // 
            this.btn_Delete.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.Location = new System.Drawing.Point(211, 335);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(86, 32);
            this.btn_Delete.TabIndex = 10;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(589, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 21);
            this.label5.TabIndex = 12;
            this.label5.Text = "Search";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(659, 28);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(172, 27);
            this.txtSearch.TabIndex = 13;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(119)))), ((int)(((byte)(195)))));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(843, 25);
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
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(40, 22);
            this.toolStripDropDownButton1.Text = "Edit";
            // 
            // userManagementToolStripMenuItem
            // 
            this.userManagementToolStripMenuItem.Name = "userManagementToolStripMenuItem";
            this.userManagementToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.userManagementToolStripMenuItem.Text = "User Management";
            this.userManagementToolStripMenuItem.Click += new System.EventHandler(this.userManagementToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.logOutToolStripMenuItem.Text = "Log Out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click_1);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Emp_lblslot
            // 
            this.Emp_lblslot.AutoSize = true;
            this.Emp_lblslot.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Emp_lblslot.Location = new System.Drawing.Point(24, 249);
            this.Emp_lblslot.Name = "Emp_lblslot";
            this.Emp_lblslot.Size = new System.Drawing.Size(99, 21);
            this.Emp_lblslot.TabIndex = 16;
            this.Emp_lblslot.Text = "Parking Slot";
            // 
            // Emp_txtSlot
            // 
            this.Emp_txtSlot.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Emp_txtSlot.Location = new System.Drawing.Point(28, 273);
            this.Emp_txtSlot.Name = "Emp_txtSlot";
            this.Emp_txtSlot.Size = new System.Drawing.Size(258, 27);
            this.Emp_txtSlot.TabIndex = 17;
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
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.parkSlotDataGridViewTextBoxColumn,
            this.userPlatenumDataGridViewTextBoxColumn,
            this.userTypeCarDataGridViewTextBoxColumn,
            this.userTimeArriveDataGridViewTextBoxColumn,
            this.userTimeOutDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.parkSlotBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(306, 88);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(525, 233);
            this.dataGridView1.TabIndex = 18;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // parkSlotBindingSource
            // 
            this.parkSlotBindingSource.DataSource = typeof(Park_System.Model.ParkSlot);
            // 
            // parkSlotDataGridViewTextBoxColumn
            // 
            this.parkSlotDataGridViewTextBoxColumn.DataPropertyName = "parkSlot";
            this.parkSlotDataGridViewTextBoxColumn.HeaderText = "Slot No.";
            this.parkSlotDataGridViewTextBoxColumn.Name = "parkSlotDataGridViewTextBoxColumn";
            // 
            // userPlatenumDataGridViewTextBoxColumn
            // 
            this.userPlatenumDataGridViewTextBoxColumn.DataPropertyName = "userPlatenum";
            this.userPlatenumDataGridViewTextBoxColumn.HeaderText = "Plate No.";
            this.userPlatenumDataGridViewTextBoxColumn.Name = "userPlatenumDataGridViewTextBoxColumn";
            // 
            // userTypeCarDataGridViewTextBoxColumn
            // 
            this.userTypeCarDataGridViewTextBoxColumn.DataPropertyName = "userTypeCar";
            this.userTypeCarDataGridViewTextBoxColumn.HeaderText = "Car Type";
            this.userTypeCarDataGridViewTextBoxColumn.Name = "userTypeCarDataGridViewTextBoxColumn";
            // 
            // userTimeArriveDataGridViewTextBoxColumn
            // 
            this.userTimeArriveDataGridViewTextBoxColumn.DataPropertyName = "userTimeArrive";
            this.userTimeArriveDataGridViewTextBoxColumn.HeaderText = "Time Arrive";
            this.userTimeArriveDataGridViewTextBoxColumn.Name = "userTimeArriveDataGridViewTextBoxColumn";
            // 
            // userTimeOutDataGridViewTextBoxColumn
            // 
            this.userTimeOutDataGridViewTextBoxColumn.DataPropertyName = "userTimeOut";
            this.userTimeOutDataGridViewTextBoxColumn.HeaderText = "Time Out";
            this.userTimeOutDataGridViewTextBoxColumn.Name = "userTimeOutDataGridViewTextBoxColumn";
            // 
            // Frm_Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(169)))), ((int)(((byte)(219)))));
            this.ClientSize = new System.Drawing.Size(843, 516);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Emp_txtSlot);
            this.Controls.Add(this.Emp_lblslot);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.Emp_txtDateEnter);
            this.Controls.Add(this.Emp_txtCarbrand);
            this.Controls.Add(this.Emp_txtPlateno);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem userManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label Emp_lblslot;
        private System.Windows.Forms.TextBox Emp_txtSlot;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private ParkingDataSet parkingDataSet;
        private ParkingDataSetTableAdapters.ParkSlotTableAdapter parkSlotTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource parkSlotBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn parkSlotDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userPlatenumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userTypeCarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userTimeArriveDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userTimeOutDataGridViewTextBoxColumn;
    }
}