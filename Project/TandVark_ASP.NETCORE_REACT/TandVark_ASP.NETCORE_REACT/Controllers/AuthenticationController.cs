using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TandVark.Domain.Repositories.Interfaces;
using TandVark.Domain.Models.Interfaces;
using TandVark.Domain.Models;
using System.ComponentModel.DataAnnotations;

namespace TandVark_ASP.NETCORE_REACT.Controllers
{
    [Route("api/[controller]")]
    public class AuthenticationController : Controller
    {
        private readonly IUserRepository _userRepository;

        public AuthenticationController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpPost]
        [Route("{FromBody}")]
        public UserAuthenticationResult AuthenticateUser([FromBody]User credentialsModel)
        {
            try
            {
                var authenticated = _userRepository.AuthenticateUser(credentialsModel);
                if (authenticated)
                    return new UserAuthenticationResult(authenticated, "Authenticated");
                else
                    return new UserAuthenticationResult(false, "Not authenticated") { Code = "0x003" };
            }
            catch (ArgumentException)
            {
                return new UserAuthenticationResult(false, "Not authenticated") { Code = "0x005" };
            }
        }

    }
    public class UserAuthenticationResult
    {
        public bool Authenticated { get; private set; }
        public string Message { get; private set; }

        [MaxLength(5)]
        public string Code { get; set; }

        public UserAuthenticationResult(bool authenticated, string message)
        {
            Authenticated = authenticated;
            Message = message;
        }
    }
}
