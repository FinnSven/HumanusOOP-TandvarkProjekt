using System;
using System.Collections.Generic;
using System.Text;

namespace TandVark.Domain.Models
{
    public class Patient
    {
        
        public string Ssnumber { get; set; }


        public Patient(string _ssnumber)
        {
        
            Ssnumber = _ssnumber;
        }
        public Patient() { }

    }
}
