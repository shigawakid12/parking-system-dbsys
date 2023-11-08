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
    public partial class Frm_Login : Form
    {
        UserRepository userRepo;
        private object errorProviderCustom;

        public Frm_Login()
        {
            InitializeComponent();
            userRepo = new UserRepository();
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
            //ParkingEntities1 db = new ParkingEntities1();
            if (String.IsNullOrEmpty(log_txtusername.Text))
            {
                errorProvider1.SetError(log_txtusername, "Empty Field!");
                return;
            }
            if (String.IsNullOrEmpty(log_txtpassword.Text))
            {
                errorProvider1.SetError(log_txtpassword, "Empty Field!");
                return;
            }

            var userLogged = userRepo.GetUserByUsername(txtUsername.Text);




            //db.Database.ExecuteSqlCommand()






            // db.Database.ExecuteSqlCommand($"INSERT INTO VALUES {}");

        }
    }
}
