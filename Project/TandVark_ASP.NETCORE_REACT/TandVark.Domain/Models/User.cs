using System;
using System.Collections.Generic;
using System.Text;
using TandVark.Domain.Models.Interfaces;

namespace TandVark.Domain.Models
{
    public class User : IUser
    {
        private string userName { get; set; }
        private string passWord { get; set; }

        public User(string _userName, string _passWord)
        {
            userName = _userName;
            passWord = _passWord;
        }
        public bool validateUser(string _passWord)
        {
            return passWord == _passWord;
        }
    }
}
