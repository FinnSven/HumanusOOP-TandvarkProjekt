using System.Collections.Generic;
using TandVark.Domain.Models.Interfaces;

namespace TandVark.Domain.Repositories.Interfaces
{
    public interface IUserRepository
    {
        List<IUser> GetAllCards();
        bool AuthenticateUser(IUser _user, string _userPass);
    }
}