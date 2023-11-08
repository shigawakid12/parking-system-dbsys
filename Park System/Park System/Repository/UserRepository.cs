
using Park_System.Model;
using Park_System.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Park_System.Repository
{
    public class UserRepository
    {
        private ParkingEntities db; 
        public UserRepository() 
        {
            db = new ParkingEntities();
        }
        public ErrorCode NewUser(EmployeeAccount aEmployeeAccount, ref String outMessage)
        {
            ErrorCode retValue = ErrorCode.Error;
            try
            {
                db.EmployeeAccount.Add(aEmployeeAccount);
                db.SaveChanges();

                outMessage = "Inserted";
                retValue = ErrorCode.Success;
            }
            catch (Exception ex)
            {
                outMessage = ex.Message;
                MessageBox.Show(ex.Message);
            }
            return retValue;
        }

        public UserAccount GetUserByUsername(string username)
        {
            using (db = new ParkingEntities())
            {
                // SELECT TOP 1 * FROM USERACCOUNT WHERE userName == username
                return db.UserAccount.Where(userName == username).FirstOrDefault();
            }
        }




    }
}
