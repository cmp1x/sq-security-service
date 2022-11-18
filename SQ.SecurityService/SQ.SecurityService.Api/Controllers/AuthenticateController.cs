using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SQ.SecurityService.Api.Models;
using SQ.SecurityService.Common.Models;
using SQ.SecurityService.Domain.Services;
using System.Net;

namespace SQ.SecurityService.Api.Controllers
{
    [ApiController]
    [AllowAnonymous]
    [Route("login")]
    public class AuthenticateController : ControllerBase
    {
        private readonly IAuthenticateService authenticateService;

        public AuthenticateController(IAuthenticateService authenticateService)
        {
            this.authenticateService = authenticateService;
        }

        [HttpPost]
        public async Task<IActionResult> Authenticate(CredentialsDto credentials)
        {

            var authenticationResult = await this.authenticateService.AuthenticateAsync(
                new Credential()
                {
                    UserName = credentials.UserName,
                    Password = credentials.Password,
                });

            if(authenticationResult.IsSuccess)
            {
                return this.Ok(
                    new
                    {
                        User = credentials.UserName,
                        Status = authenticationResult.Status.ToString()
                    });
            }

            return this.Unauthorized(
                new
                {
                    User = credentials.UserName,
                    Status = authenticationResult.Status.ToString()
                });
        }
    }
}
