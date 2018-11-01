using System.Threading.Tasks;
using TandVark.Domain.DTO;
using TandVark.Domain.Models;

namespace TandVark.Domain.Services
{
    public interface IPatientValidationService
    {

        Task<PatientDTO> GetValueAsync(Patient _ssnumber);

    }
}