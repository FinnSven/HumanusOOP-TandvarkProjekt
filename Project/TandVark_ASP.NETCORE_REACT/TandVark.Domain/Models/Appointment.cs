
using System;
using System.Collections.Generic;
using TandVark.Domain.Models.Interfaces;

namespace TandVark.Domain.Models
{
    public class Appointment : IAppointment
    {
        public int EmployeeNo { get; set; }
        public int PatientNo { get; set; }

        private DateTime appointdateTime;
        public List<AppointmentTypes> TypesOfAppointment { get; set; }
        public DateTime GetAppointdateTime()
        {
            return appointdateTime;
        }

        public void SetAppointdateTime(DateTime value)
        {
            appointdateTime = value;

        }



        public Appointment(int _empoyno, int _Patientno, DateTime value)
        {
            EmployeeNo = _empoyno;
            PatientNo = _Patientno;
            appointdateTime = value;
        }

       
    }

}



    


