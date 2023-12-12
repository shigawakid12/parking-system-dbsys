using Park_System.Model;
using Park_System.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Park_System.Forms
{
    public partial class Frm_SignUp : Form
    {
        ParkingEntities db = new ParkingEntities();
        public Frm_SignUp()
        {
            InitializeComponent();
           // db = new ParkingEntities();
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

            //try
            //{
            //    UserAccount nUserAccount = new UserAccount();
            //    nUserAccount.userName = sign_txtUsername.Text;
            //    nUserAccount.userName = sign_txtPassword.Text;
            //    nUserAccount.roleId = (Int32)comboBox1.SelectedValue;
            //    nUserAccount.userStatus = "Active";

            //    db.UserAccount.Add(nUserAccount);
            //    db.SaveChanges();

            //    sign_txtName.Clear();
            //    sign_txtPassword.Clear();
            //    sign_txtUsername.Clear();
            //    MessageBox.Show("Successfully Registered!");
            //}
            //catch (DbEntityValidationException ex)
            //{
            //    foreach (var validationErrors in ex.EntityValidationErrors)
            //    {
            //        foreach (var error in validationErrors.ValidationErrors)
            //        {
            //            Console.WriteLine($"Entity: {validationErrors.Entry.Entity.GetType().Name}, Property: {error.PropertyName}, Error: {error.ErrorMessage}");
            //        }
            //    }

            //}
            UserAccount nUserAccount = new UserAccount();
            nUserAccount.userName = sign_txtUsername.Text;
            nUserAccount.userPassword = sign_txtPassword.Text;
            nUserAccount.roleId = (Int32)comboBox1.SelectedValue;
            nUserAccount.userStatus = "Active";

            db.UserAccount.Add(nUserAccount);
            db.SaveChanges();

            sign_txtName.Clear();
            sign_txtPassword.Clear();
            sign_txtUsername.Clear();
            sign_txtconfirmpass.Clear();
            MessageBox.Show("Successfully Registered!");
        }



        private void Frm_SignUp_Load(object sender, EventArgs e)
        {
            loadcomboBox1();
        }

        private void loadcomboBox1()
        {
            var roles = db.Role.ToList();

            comboBox1.ValueMember = "roleId";
            comboBox1.DisplayMember = "roleName";
            comboBox1.DataSource = roles;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
