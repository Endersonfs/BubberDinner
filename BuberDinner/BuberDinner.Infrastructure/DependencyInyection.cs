using BuberDinner.Application.Common.Interface.Authentication;
using BuberDinner.Application.Common.Interface.Service;
using BuberDinner.Application.Services.Authentication;
using BuberDinner.Infrastructure.Authentication;
using BuberDinner.Infrastructure.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BuberDinner.Infrastructure
{
    public static class DependencyInyection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, ConfigurationManager configuration)
        {
            services.Configure<JwSetting>(configuration.GetSection(JwSetting.SecctionName));
            services.AddSingleton<IAuthenticationService, AuthenticationService>();
            services.AddSingleton<IJwTokenGenerator, JwTokenGenerator>();
            services.AddSingleton<IDateTimeProvider, DateTimeProvider>();
            return services;
        }
    }
}
