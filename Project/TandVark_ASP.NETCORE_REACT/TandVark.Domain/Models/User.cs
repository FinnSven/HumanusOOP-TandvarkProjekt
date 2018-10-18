using System;
using System.Collections.Generic;
using System.Text;
using TandVark.Domain.Models.Interfaces;

namespace TandVark.Domain.Models
{
    public class User : IUser
    {
        public string UserName { get; set; }
        public string PassWord { get; set; }

        public User(string _userName, string _passWord)
        {
            UserName = _userName;
            PassWord = _passWord;
        }
        public User() { }
        public bool validateUserPassWord(string _passWord)
        {
            return PassWord == _passWord;
        }
    }
}
