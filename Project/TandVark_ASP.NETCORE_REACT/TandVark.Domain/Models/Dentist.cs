
using TandVark.Domain.Models.Interfaces;

namespace TandVark.Domain.Models
{
    public class Dentist : IUser, IAppointment
    {
        public string UserName          { get; set; }
        public string PassWord          { get; set; }
        public string UserType          { get; set; }
        public int    EmployeeNo        { get; set; }
        public Appointment Appointment  { get; set; }


        public Dentist(string _userName, string _passWord, int _12345678)
        {
            UserName = _userName;
            PassWord = _passWord;
            EmployeeNo = 12345678;
        }
        public Dentist()
        { }
    }
}
