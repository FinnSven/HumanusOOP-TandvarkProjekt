using System.Threading.Tasks;
using TandVark.Domain.DataLatHund;

namespace TandVark.Domain.Services
{
    public interface IPatientRepository
    {
        Task<TblPatient> GetPatientAsync(int? sSNumber);
    }
}