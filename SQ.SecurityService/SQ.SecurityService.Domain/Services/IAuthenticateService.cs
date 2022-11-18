using SQ.SecurityService.Common.Models;

namespace SQ.SecurityService.Domain.Services
{
    public interface IAuthenticateService
    {
        Task<AuthenticationResults> AuthenticateAsync(Credential credential);
    }
}