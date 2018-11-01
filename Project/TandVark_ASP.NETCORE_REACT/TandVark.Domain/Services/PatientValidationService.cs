using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TandVark.Domain.DTO;
using TandVark.Domain.Models;
using TandVark.Domain.Repositories.Interfaces;

namespace TandVark.Domain.Services
{
    public class PatientValidationService : IPatientValidationService
    {
        private readonly IPatientRepository _iPatientRepository;

        public PatientValidationService(IPatientRepository iUserRepository)
        {
            _iPatientRepository = iUserRepository;
        }

        public async Task<PatientDTO> GetValueAsync(Patient _ssnumber)
        {
            var value = await _iPatientRepository.GetPatientAsync(_ssnumber);

            if (value == null)
            {
                throw new NullReferenceException("Social security number does not exist");
            }
            else if (_ssnumber == value.FldSsnumber)
            {
                var Patient = new PatientDTO { Ssnumber = value.FldSsnumber};
                return Patient;
            }
            throw new ArgumentException("User social security number missmatch");

        }


    }
}
