using TandVark.Domain.Models.Interfaces;

namespace TandVark.Domain.Models
{
    public class Patient : IUser
    {
        public string UserName { get; set; }
        public string PassWord { get; set; }
        public string UserType { get; set; }

        public Patient(string _userName, string _passWord)
        {
            UserName = _userName;
            PassWord = _passWord;
        }
        public Patient() { }
        
    }
}
