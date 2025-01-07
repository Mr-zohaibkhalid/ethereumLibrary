using ethereumLibrary.Implementations;
using ethereumLibrary.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace ethereumLibrary
{
    public static class ethereumLibraryRegistration
    {
        public static void AddethereumLibrary(this IServiceCollection services)
        {
            services.AddScoped<IEtherService, EtherService>();
        }

        public static IServiceCollection AddethereumLibraryWithReturn(this IServiceCollection services)
        {
            services.AddScoped<IEtherService, EtherService>();

            return services;
        }
    }
}
