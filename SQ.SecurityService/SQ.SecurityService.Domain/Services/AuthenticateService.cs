using SQ.SecurityService.Repository.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SQ.SecurityService.Domain.Services
{
    using SQ.SecurityService.Common.Models;

    public class AuthenticateService : IAuthenticateService
    {
        private readonly ICredentialRepository credentialRepository;
        public AuthenticateService(ICredentialRepository credentialRepository)
        {
            this.credentialRepository = credentialRepository;
        }

        public async Task<AuthenticationResults> AuthenticateAsync(Credential credential)
        {
            try
            {
                var credDb = await this.credentialRepository.GetCredentialsAsync(credential.UserName);

                if(credDb is null)
                {
                    return new AuthenticationResults()
                    {
                        IsSuccess = false,
                        Status = Status.UserNotFound,
                        StatusMessage = "User not found"
                    };
                }

                var isAuthenticated = credDb.Password == credential.Password;
                if(isAuthenticated)
                {
                    return new AuthenticationResults()
                    {
                        IsSuccess = isAuthenticated,
                        Status = Status.Success,
                        StatusMessage = "Access Granted"
                    };
                }
                return new AuthenticationResults()
                {
                    IsSuccess = isAuthenticated,
                    Status = Status.Failed,
                    StatusMessage = "Wrong Password"
                };
            }
            catch (Exception e)
            {
                // TODO:
                // Logging exception
                throw;
            }
        }
    }
}
