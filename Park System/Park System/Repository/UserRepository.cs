
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
        public ErrorCode NewUser(UserAccount auserAccount, ref String outMessage)
        {
            ErrorCode retValue = ErrorCode.Error;
            try
            {
                db.UserAccount.Add(auserAccount);
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

       // public ErrorCode UpdateSlot(int? parkSlot)


       // public ErrorCode StoreProfParkslot()
        public UserAccount GetUserByUsername(string username)
        {
            using (db = new ParkingEntities())
            {
                // SELECT TOP 1 * FROM USERACCOUNT WHERE userName == username
               return db.UserAccount.Where(s => s.userName == username).FirstOrDefault();
            }
        }

        public ParkSlot GetSlotbyClick(int? parkID)
        {
            using (db = new ParkingEntities())
            {
                return db.ParkSlot.Where(c => c.parkSlot == parkID).FirstOrDefault();
            }
        }

        public List<UserAccount> UserAccounts()
        {
            using (db = new ParkingEntities())
            {
                return db.UserAccount.ToList();
            }
        }

        public List <ParkSlot> GetUserInfo()
        {
            using (db = new ParkingEntities())
            {
                return db.ParkSlot.ToList();
            }
        }

        public ErrorCode DeletePlate(ParkSlot aSlot, ref String outMessage)
        {
            ErrorCode retValue = ErrorCode.Error; 
            try
            {
                db.ParkSlot.Remove(aSlot);
                db.SaveChanges();

                outMessage = "Successfully Deleted!";
                retValue = ErrorCode.Success;
            }
            catch (Exception ex)
            {
                outMessage = ex.Message;
                MessageBox.Show(ex.Message);
            }
            return retValue;
        }

    }
}
