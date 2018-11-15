using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TandVark.Data.Data1;
using TandVark.Domain.DataLatHund;
using TandVark.Domain.Repositories.Interfaces;
using TandVark.Domain.Services;

namespace TandVark.Domain.Repositories
{
    public class PatientRepository : IPatientRepository
    {

        private readonly TandVardContext _tandVardContext;

        public PatientRepository(TandVardContext tandVardContext)
        {
            _tandVardContext = tandVardContext;
        }

        public async Task<TblPatient> GetPatientAsync(int? _sSNumber)
        {
            var value = await _tandVardContext.TblPatients.FirstAsync(x => x.FldSsnumber == _sSNumber);
            return value;
        }

    }
}
