﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Park_System.Forms
{
    public partial class Frm_Admin_Dashboard : Form
    {
        public Frm_Admin_Dashboard()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Frm_Admin_Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripLabel1_Click_1(object sender, EventArgs e)
        {

        }

        private void userManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_Employee frm_emp = new Frm_Employee();
            frm_emp.Show();


        }

        private void vehicleLeavingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_User frmuser = new Frm_User();
            frmuser.Show();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
