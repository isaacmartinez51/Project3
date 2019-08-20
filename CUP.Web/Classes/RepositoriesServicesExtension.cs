using Continental.CUP.Repositories.Implementations;
using Continental.CUP.Repositories.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace Continental.CUP.Web.Classes
{
    public static class RepositoriesServicesExtension
    {
        /// <summary>
        /// Add Repositories transient
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddTransient<IActionDetailRepository, ActionDetailRepository>();
            services.AddTransient<ILocationRepository, LocationRepository>();
            services.AddTransient<IReaderKindRepository, ReaderKindRepository>();
            services.AddTransient<IRoleRepository, RoleRepository>();
            services.AddTransient<IUserRepository, UserRepository>();
            services.AddTransient<IUserRoleRepository, UserRoleRepository>();

            return services;
        }
    }
}
