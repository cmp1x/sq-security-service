using SQ.SecurityService.Repository.Models;

namespace SQ.SecurityService.Repository.Repositories
{
    public interface ICredentialRepository
    {
        Task<CredentialsDb> GetCredentialsAsync(string userName);
    }
}