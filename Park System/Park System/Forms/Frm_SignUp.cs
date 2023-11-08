using Park_System.Model;
using Park_System.Utils;
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
    public partial class Frm_SignUp : Form
    {
        ParkingEntities db;
        public Frm_SignUp()
        {
            InitializeComponent();
            db = new ParkingEntities();
        }

        private void log_btnlogin_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(sign_txtUsername.Text))
            {
                errorProvider1.SetError(sign_txtUsername, "Empty Field!"); 
                return;
            }
            if (String.IsNullOrEmpty(sign_txtPassword.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(sign_txtPassword, "Empty field");
                return;
            }
            if (String.IsNullOrEmpty(sign_txtconfirmpass.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(sign_txtconfirmpass, "Empty field");
                return;
            }
            if (!sign_txtPassword.Text.Equals(sign_txtconfirmpass.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(sign_txtconfirmpass, "Password not match");
                return;
            }

            UserAccount nuserAccount = new UserAccount();
            nuserAccount
        }

        private void Frm_SignUp_Load(object sender, EventArgs e)
        {

        }
    }
}
