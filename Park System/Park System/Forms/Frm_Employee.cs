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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Park_System.Forms
{
    public partial class Frm_Employee : Form
    {
        ParkingEntities db = new ParkingEntities();
        UserRepository userRepo;
        int? userSelectedId = null;
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

           

            ParkSlot Slots = new ParkSlot();
            Slots.AuserPlatenum = Emp_txtPlateno.Text;
            Slots.AuserTypeCar = Emp_txtCarbrand.Text;
            Slots.AuserTimeArrive = Emp_txtDateEnter.Text;
            Slots.AuserTimeOut = " ";
            Slots.parkSlot = (Int32)Emp_cbSlot.SelectedValue;
          
            db.ParkSlot.Add(Slots);
            db.SaveChanges();

            Emp_txtPlateno.Clear();
            Emp_txtCarbrand.Clear();
            MessageBox.Show("Successfully Registered!");
            loadUser();

            


        }

        

        private void Frm_Employee_Load(object sender, EventArgs e)
        {
           
            userRepo = new UserRepository();
            loadUser();
            Emp_txtDateEnter.Text = Convert.ToString(DateTime.Now);

        }
        private void loadcomboBox1()
        {
            var roles = db.ParkSlot.ToList();

            Emp_cbSlot.ValueMember = "";
            Emp_cbSlot.DisplayMember = "roleName";
            Emp_cbSlot.DataSource = roles;
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
            try
            {
                userSelectedId = (Int32)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
                Emp_txtPlateno.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value as String;
                Emp_txtCarbrand.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value as String;
            }
            catch { }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                userSelectedId = (Int32)dataGridView1[0,e.RowIndex].Value;
                Emp_txtPlateno.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value as String;
                Emp_txtCarbrand.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value as String;
            }
            catch { }


        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            userSelectedId = (Int32)dataGridView1[0, e.RowIndex].Value;
            Emp_txtPlateno.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value as String;
            Emp_txtCarbrand.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value as String;
            Emp_txtDateEnter.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value as String;
           
           // Sqlcommand c = new Sqlcommand("select * from ParkSlot");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Emp_cbSlot_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
