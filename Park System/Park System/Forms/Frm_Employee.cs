using Park_System.Model;
using Park_System.Repository;
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
        UserRepository userRepo;
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

        public void loadUser()
        {
            dataGridView1.DataSource = userRepo.GetUserInfo();
        }

       

        private void btn_Save_Click(object sender, EventArgs e)
        {
            Emp_txtDateEnter.Text = Convert.ToString(DateTime.Now);

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

            ParkSlot Slots = new ParkSlot();
            Slots.userPlatenum = Emp_txtPlateno.Text;
            Slots.userTypeCar = Emp_txtCarbrand.Text;
            Slots.userTimeArrive = Emp_txtDateEnter.Text;
            Slots.userTimeOut = " ";
            //Slots.parkSlot= 
          
            db.ParkSlot.Add(Slots);
            db.SaveChanges();

            Emp_txtPlateno.Clear();
            Emp_txtCarbrand.Clear();
            MessageBox.Show("Successfully Registered!");
            loadUser();




        }

        private void Frm_Employee_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'parkingDataSet.ParkSlot' table. You can move, or remove it, as needed.
           // this.parkSlotTableAdapter.Fill(this.parkingDataSet.ParkSlot);
            userRepo = new UserRepository();
            loadUser();
            Emp_txtDateEnter.Text = Convert.ToString(DateTime.Now);

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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
