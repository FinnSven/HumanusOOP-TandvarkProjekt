using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TandVark.Data.Data1;
using TandVark.Domain.DataLatHund;

namespace TandVark.Domain.Repositories
{
    public class PatientRepository
    {

        private readonly TandVerkContext _tandVardContext;

        public PatientRepository(TandVerkContext tandVardContext)
        {
            _tandVardContext = tandVardContext;
        }

        public async Task<Data.Data1.TblPatient> GetPatientAsync(string _ssnumber)
        {
            var value = await _tandVardContext.TblPatient.FirstOrDefaultAsync(table => table.FldSsnumber.Equals(_ssnumber));
            return value;
        }
    }
}
