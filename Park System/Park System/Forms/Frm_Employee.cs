using Park_System.Model;
using System;
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
    public partial class Frm_Employee : Form
    {
        ParkingEntities db = new ParkingEntities();
        public Frm_Employee()
        {
            InitializeComponent();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_Login log = new Frm_Login();
            log.Show();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            

            if (String.IsNullOrEmpty(Emp_txtPlateno.Text))
            {
                errorProvider1.SetError(Emp_txtPlateno, "Empty Field!");
                return;
            }
            if (String.IsNullOrEmpty(Emp_txtDateEnter.Text))
            {
                errorProvider1.SetError(Emp_txtCarbrand, "Empty Field!");
                return;
            }
            if (String.IsNullOrEmpty(Emp_txtDateEnter.Text))
            {
                errorProvider1.SetError(Emp_txtDateEnter, "Empty Field!");
                return;
            }
            if (String.IsNullOrEmpty(Emp_lblslot.Text))
            {
                errorProvider1.SetError(Emp_lblslot, "Empty Field!");
                return;
            }

            UserInformation UserInfo = new UserInformation();
            UserInfo.userPlatenum = Emp_txtPlateno.Text;
            UserInfo.userTypeCar = Emp_txtCarbrand.Text;
            UserInfo.userTimeArrive = Emp_txtDateEnter.Text;
            int text1 = (int)Emp_txtSlot.Text;
            UserInfo.parkSlot = text1;
            


        }

        private void Frm_Employee_Load(object sender, EventArgs e)
        {
            Emp_txtDateEnter.Text = DateTime.Now.ToString();
        }

        private void userManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_User frm_User = new Frm_User();
            frm_User.Show();
        }

        private void logOutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Frm_Login frm_Login = new Frm_Login();
            frm_Login.Show();
        }
    }
}
