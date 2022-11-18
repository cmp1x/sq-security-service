using Microsoft.Extensions.DependencyInjection;
using SQ.SecurityService.Repository.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQ.SecurityService.Repository
{
    public static class RegisterRepositoryServicesExtension
    {
        public static IServiceCollection RegisterRepositoryServices(
            this IServiceCollection services)
        {
            services.AddTransient<ICredentialRepository, CredentialRepository>();

            return services;
        }
    }
}
