using System.Threading.Tasks;
using TandVark.Data.Data1;
using TandVark.Domain.Models;

namespace TandVark.Domain.Repositories.Interfaces
{
    public interface IPatientRepository
    {
        
        Task<TblUser> GetUserAsync(string _userName);
        Task GetPatientAsync(Patient ssnumber);
    }
}