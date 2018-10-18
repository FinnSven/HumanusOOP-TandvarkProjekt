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
        public List<IUser> GetAllUsers()
        {
            using (var db = new CardDB())
            {
                var _Users = db.Users();
                return _Users;
            }
        }
        public bool AuthenticateUser(User _User)
        {
            var AllUsers = GetAllUsers();
            foreach(User U in AllUsers)
            {
                if (U.UserName == _User.UserName && U.PassWord == _User.PassWord )
                {
                    return true;
                }

            }
            return false;

        }
    }

    public class CardDB : IDisposable
    {
        public List<IUser> Users() => new List<IUser>
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


