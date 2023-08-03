using BLL.Services.Authorization.Classes;
using BLL.Services.Authorization.Interfaces;
using BLL.Services.Registration.Classes;
using BLL.Services.Registration.Interfaces;
using BLL.Services.UrlService.Classes;
using BLL.Services.UrlService.Interfaces;
using BLL.Services.Users.Classes;
using BLL.Services.Users.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace BLL
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddBLL(this IServiceCollection services)
        {
            services.AddTransient<ILoginService, LoginService>();

            services.AddTransient<IRegistrationService, RegistrationService>();

            services.AddTransient<IUrlService, UrlService>();

            services.AddTransient<IUserService, UserService>();

            services.AddAutoMapper(typeof(MappingProfile));

            services.AddMemoryCache();

            return services;
        }
    }
}
