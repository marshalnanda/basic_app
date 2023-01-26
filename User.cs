using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace practice_app
{
    public class User
    {
        private string _UserName;
        public string UserName { get { return _UserName; } }

        private string _UserPassword;
        public string UserPassword { get { return _UserPassword; } }

        private string _UserPhoneNumber;
        public string UserPhoneNumber { get { return _UserPhoneNumber; } }

        private int _UserBalance;
        public int UserBalance { get { return _UserBalance; } }

        public User(String Name, String password,String PhoneNumber)
        {
            _UserName = Name;
            _UserPassword = password;
            _UserPhoneNumber = PhoneNumber;
            _UserBalance = 0;
        }
    }
}