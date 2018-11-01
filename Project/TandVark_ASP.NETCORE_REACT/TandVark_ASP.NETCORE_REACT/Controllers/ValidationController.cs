using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TandVark.Domain.Models;
using TandVark.Domain.Services.Interfaces;

namespace TandVark_ASP.NETCORE_REACT.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValidationController : ControllerBase
    {

        private readonly IUserServices _userService;

        public ValidationController(IUserServices userService)
        {
            _userService = userService;
        }


        [HttpPost]
        [Route("{FromBody}")]
        public Task<OkObjectResult> ValidatePatientAsync[FromBody] Patient credentialsModel)
        {

             try
            {
                if (credentialsModel.FldSsnumber == null)
                    throw new ArgumentNullException($"Parameter {nameof(credentialsModel.FldSsnumber)} cannot be null", nameof(credentialsModel.FldSsnumber));
                

                return Ok(await _patientService.GetValueAsync(credentialsModel));

    }
            catch (ArgumentNullException argumentNullException)
            {
                return StatusCode((int) HttpStatusCode.BadRequest, argumentNullException.Message);
            }
            catch (ArgumentException argumentException)
            {
                return StatusCode((int) HttpStatusCode.BadRequest, argumentException.Message);
            }
            catch (NullReferenceException nullReferenceException)
            {
                return StatusCode((int) HttpStatusCode.BadRequest, nullReferenceException.Message);
            }
            catch (Exception exception)
            {
                return StatusCode((int) HttpStatusCode.InternalServerError, exception.Message);
            }


        }
    }
}