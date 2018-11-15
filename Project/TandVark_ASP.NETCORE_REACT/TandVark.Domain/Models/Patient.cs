using System;
using System.Collections.Generic;
using System.Text;

namespace TandVark.Domain.Models
{
    class Patient : IPatient
    {
        public int? sSNumber { get; set; }

        public Patient(int? _sSNumber)
        {
            sSNumber = _sSNumber;
        }

        public Patient() { }
    }
}
