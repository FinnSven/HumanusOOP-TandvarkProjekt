using System.Collections.Generic;
using TandVark.Domain.Models.Interfaces;
using TandVark.Domain.Models;


namespace TandVark.Domain.Repositories.Interfaces
{
    public interface IUserRepository
    {
        List<IUser> GetAllUsers();
        bool AuthenticateUser(User _User);
    }
}