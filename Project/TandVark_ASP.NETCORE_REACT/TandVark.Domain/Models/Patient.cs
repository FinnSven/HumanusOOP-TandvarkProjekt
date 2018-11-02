
using TandVark.Domain.Models.Interfaces;
namespace TandVark.Domain.Models
{
    public class Patient: IUser, IAppointment 

    {
        public string UserName          { get; set; }
        public string PassWord          { get; set; }
        public string UserType          { get; set; }
        public int    PatientNo         { get; set; }
        public Appointment Appointment  { get; set; }

        public Patient(string _userName, string _passWord, int _12345678 )
        {
            UserName    = _userName;
            PassWord    = _passWord;
            PatientNo   = _12345678;
            
        }
        public Patient()
        { }
    }
}
