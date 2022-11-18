using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQ.SecurityService.Common.Models
{
    public class AuthenticationResults
    {
        public bool IsSuccess { get; set; }

        public Status Status { get; set; }

        public string StatusMessage { get; set; }
    }

    public enum Status
    {
        Success = 1,
        Failed = 2,
        UserNotFound = 3,
    }
}
