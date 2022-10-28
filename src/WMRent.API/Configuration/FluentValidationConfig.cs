using FluentValidation;
using FluentValidation.AspNetCore;
using WMRent.Business.Models;
using WMRent.Business.Models.Validation;

namespace WMRent.API.Configuration
{
    public static class FluentValidationConfig
    {
        public static IServiceCollection ResolveValidators(this IServiceCollection services)
        {
            //  services.AddValidatorsFromAssemblyContaining(typeof(CarValidator));


            services.AddScoped<IValidator<Car>, CarValidator>();

            return services;
        }
    }
}
