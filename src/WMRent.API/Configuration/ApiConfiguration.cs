namespace WMRent.API.Configuration
{
    public static class ApiConfiguration
    {
        public static IServiceCollection AddApiConfig(this IServiceCollection services)
        {
            services.ResolveValidators();

            return services;
        }

    }
}
