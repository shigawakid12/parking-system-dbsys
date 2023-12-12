using Park_System.Model;
using Park_System.Repository;
using Park_System.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Park_System.Forms
{
    public partial class Frm_User : Form
    {
        ParkingEntities db = new ParkingEntities();
        UserRepository userRepo;
        int? userSelectedId = null;
        public Frm_User()
        {
            

            InitializeComponent();
        }
        public void LoadData()
        {
            dataGridView1.DataSource = userRepo.GetUserInfo();
        }

        private void Frm_User_Load(object sender, EventArgs e)
        { 
            SqlConnection conn = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=Parking;Integrated Security=True");
            userRepo = new UserRepository();
            LoadData();

            //conn.Open();
        }

        private void btn_slot1_Click(object sender, EventArgs e)
        {

        }

        private void dgv_motorcycle_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            db.Database.Connection.Open();
            userSelectedId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            //ParkSlot park = new ParkSlot();
            
          //  SqlCommand sqlCommand = new SqlCommand("Delete ParkSlot where parkSlot = '" + userSelectedId + "'");
            db.Database.ExecuteSqlCommand("Delete ParkSlot where parkSlot = '" + userSelectedId + "'");
            db.Database.Connection.Close();
            MessageBox.Show("Successfully Deleted!");
            LoadData();


            //SqlConnection conn = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=Parking;Integrated Security=True");
            //conn.Open();
            //SqlCommand cmd = new SqlCommand("Delete ParkSlot where parkSlot = '" + userSelectedId + "'");
            //conn.Close();
            //MessageBox.Show("Successfully Deleted!");
            //LoadData();




        }
        private void parkSlotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_Employee employee = new Frm_Employee();
            employee.Show();
        }

        private void logoutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Frm_Login frm_Login = new Frm_Login();
            frm_Login.Show();
        }
    }
}
