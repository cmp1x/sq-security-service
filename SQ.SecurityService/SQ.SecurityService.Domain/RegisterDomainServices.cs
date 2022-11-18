using Microsoft.Extensions.DependencyInjection;
using SQ.SecurityService.Domain.Services;

namespace SQ.SecurityService.Domain
{
    public static class RegisterDomainServicesExtension
    {
        public static IServiceCollection RegisterDomainServices(this IServiceCollection services)
        {
            services.AddScoped<IAuthenticateService, AuthenticateService>();

            return services;
        }

    }
}