using System;
using System.Collections.Generic;
using System.Text;

namespace TandVark.Domain.Models
{
    public class Patient : IPatient
    {
        
        public string Ssnumber { get; set; }
        public object UserName { get; set; }

        public Patient(string _ssnumber)
        {
        
            Ssnumber = _ssnumber;
        }
        public Patient() { }

    }
}
