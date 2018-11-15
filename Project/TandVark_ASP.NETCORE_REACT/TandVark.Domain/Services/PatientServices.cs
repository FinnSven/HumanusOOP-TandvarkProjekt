using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TandVark.Domain.DTO;
using TandVark.Domain.Models;
using TandVark.Domain.Repositories.Interfaces;

namespace TandVark.Domain.Services
{
    public class PatientServices : IPatientServices
    {
        private readonly IUserRepository _iUserRepository;
        private IPatientRepository _iPatientRepository;

        public PatientServices(IPatientRepository iPatientRepository)
        {
            _iPatientRepository = iPatientRepository;
        }

        public async Task<PatientDTO> GetValueAsync(Patient _Patient)
        {
            var value = await _iPatientRepository.GetPatientAsync(_Patient.sSNumber);

            if (value == null)
            {
                throw new NullReferenceException("Social Security Number does not exist");
            }
            else if (_Patient.sSNumber == value.FldsSNumber)
            {
                var Patient = new PatientDTO { SSNumber = value.FldsSNumber };
                return Patient;
            }
            throw new ArgumentException("Patient credentials missmatch");

        }

    }
}
