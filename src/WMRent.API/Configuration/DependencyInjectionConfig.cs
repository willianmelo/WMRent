using WMRent.Business.Interfaces;
using WMRent.Business.Notifications;
using WMRent.Business.Services;
using WMRent.Data.Context;
using WMRent.Data.Repository;

namespace WMRent.API.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection ResolveDependencies(this IServiceCollection services)
        {
            services.AddScoped<RentDbContext>();
            services.AddScoped<ICarRepository, CarRepository>();
            services.AddScoped<ICarService, CarService>();
            services.AddScoped<INotifier, Notifier>();

            return services;
        }
    }
}