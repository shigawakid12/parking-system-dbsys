using Park_System.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace Park_System
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            TimestampAttribute time_now = new TimestampAttribute();

            Console.WriteLine(time_now);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Frm_Login());

            //Thread newThread1 = new Thread(form_login);
            //Thread newThread2 = new Thread(form_signup);

            //newThread1.Start(); 
            //newThread2.Start(); 


        }

        public static void form_login()
        {
            Application.Run(new Frm_Login());
        }

        public static void form_signup()
        {
            Application.Run(new Frm_SignUp());
        }
    }
}
