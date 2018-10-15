using System;
using System.Collections.Generic;
using System.Text;
using TandVark.Domain.Models.Interfaces;
using TandVark.Domain.Repositories.Interfaces;

using TandVark.Domain.Models;

namespace TandVark.Domain.Repositories
{
    public class UserRepository : IUserRepository
    {
        public List<IUser> GetAllCards()
        {
            using (var db = new CardDB())
            {
                var _users = db.users();
                return _users;
            }
        }
        public bool AuthenticateUser(IUser _user, string _userPass)
        {
            return _user != null ? _user.validateUser(_userPass) : false;
        }
    }

    public class CardDB : IDisposable
    {
        public List<IUser> users() => new List<IUser>
            {
                new User("U1", "1234"),
                new User("U2", "4321"),
                new User("U3", "1111")
            };


        public void Dispose()
        {
            Console.WriteLine("Disposing.");
        }
    }
}


