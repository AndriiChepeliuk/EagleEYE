using AutoMapper;
using Core.Helpers.ApplicationProfiles;
using Core.Interfaces.CustomServices;
using Core.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Core
{
    public static class ServiceExtensions
    {
        public static void AddCustomServices(this IServiceCollection services)
        {
            services.AddScoped<IAuthenticationService, AuthenticationService>();
        }

        public static void AddAutoMapper(this IServiceCollection services)
        {
            var configures = new MapperConfiguration(mapperConfig =>
            {
                mapperConfig.AddProfile(new UserProfile());
            });

            var mapper = configures.CreateMapper();
            services.AddSingleton(mapper);
        }
    }
}
