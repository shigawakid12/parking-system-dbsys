﻿using Park_System.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Park_System.Utils
{
    public class UserLogged
    {
        //
        private static UserLogged _instance;


        // *********** Member 
        public UserAccount UserAccount { get; set; }

        public UserInformation UserInformation { get; set; }

        public ParkSlot ParkSlot { get; set; }

        //************
        private UserLogged()
        {

        }

        public static UserLogged GetInstance()
        {
            if (_instance == null)
                _instance = new UserLogged();
            return _instance;
        }
    }
}
