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
    public partial class Frm_Login : Form
    {
        
        public Frm_Login()
        {
            InitializeComponent();
        }

        private void Frm_Login_Load(object sender, EventArgs e)
        {

        }

        private void lnklbl_singup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Frm_SignUp sign = new Frm_SignUp();
            sign.ShowDialog();
        }

        private void log_btnlogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_Employee empo = new Frm_Employee();
            empo.Show();


            ParkingEntities db = new ParkingEntities();

            //db.Database.ExecuteSqlCommand($"INSERT INTO VALUES {}");
            
        }
    }
}
