using Dapper;
using Npgsql;
using SQ.SecurityService.Repository.Models;
using System.Data;

namespace SQ.SecurityService.Repository.Repositories
{
    public class CredentialRepository : ICredentialRepository
    {
        private readonly string connectionString = "Host=localhost;Port=5431;Database=SQCredential;Username=nat;Password=SoapShoes";

        //public CredentialRepository(string connectionString)
        //{
        //    this.connectionString = connectionString;
        //}

        public async Task<CredentialsDb> GetCredentialsAsync(string userName)
        {
            using (IDbConnection db = new NpgsqlConnection(this.connectionString))
            {
                var targetCredential = await db
                    .QueryFirstOrDefaultAsync<CredentialsDb>(
                        DapperQueryStrings.GetCredentials,
                        new { UserName = userName });

                return targetCredential;
            }
        }
    }
}
