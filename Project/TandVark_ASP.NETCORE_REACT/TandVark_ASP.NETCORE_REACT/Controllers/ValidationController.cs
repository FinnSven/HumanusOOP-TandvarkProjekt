using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TandVark.Domain.Models;
using TandVark.Domain.Services.Interfaces;

namespace TandVark_ASP.NETCORE_REACT.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValidationController : Controller
    {

        private readonly IUserServices _patientService;

        public ValidationController(IUserServices userService)
        {
            _patientService = userService;
        }

        [HttpPost]
        [Route("{FromBody}")]
        public async Task<IActionResult> ValidateUserAsync([FromBody]User credentialsModel)
        {
            try
            {
                if (credentialsModel.SSNumber == null)
                    throw new ArgumentNullException($"Parameter {nameof(credentialsModel.SSNumber)} cannot be null", nameof(credentialsModel.SSNumber));
               

                return Ok(await _patientService.GetValueAsync(credentialsModel));

            }
            catch (ArgumentNullException argumentNullException)
            {
                return StatusCode((int)HttpStatusCode.BadRequest, argumentNullException.Message);
            }
            catch (ArgumentException argumentException)
            {
                return StatusCode((int)HttpStatusCode.BadRequest, argumentException.Message);
            }
            catch (NullReferenceException nullReferenceException)
            {
                return StatusCode((int)HttpStatusCode.BadRequest, nullReferenceException.Message);
            }
            catch (Exception exception)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, exception.Message);
            }
        }

    }
}