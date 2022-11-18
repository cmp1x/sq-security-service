using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQ.SecurityService.Repository
{
    public static class DapperQueryStrings
    {
        public static string GetCredentials { get; } = @"
            SELECT userid, username, password
            FROM credential
            WHERE username = @UserName";
    }
}
