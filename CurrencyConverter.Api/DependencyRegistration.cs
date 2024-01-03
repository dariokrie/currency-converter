using CurrencyConverter.Api.Profiles;
using CurrencyConverter.Data.Entities;
using CurrencyConverter.Data.Entities.Interfaces;
using CurrencyConverter.Data.Repositories;
using CurrencyConverter.Data.Repositories.Interfaces;
using CurrencyConverter.Domain.Services;
using CurrencyConverter.Domain.Services.Interfaces;

namespace CurrencyConverter.Api
{
    public static class DependencyRegistration
    {
        public static IServiceCollection RegisterServices(this IServiceCollection services)
        {
            services.AddScoped<ICurrencyConverterContext, CurrencyConverterContext>();

            services.AddScoped<ICurrencyService, CurrencyService>();
            services.AddScoped<IConverterService, ConverterService>();
            services.AddScoped<IRoundingPolicyService, RoundingPolicyService>();

            services.AddScoped<ICurrencyRepository, CurrencyRepository>();
            services.AddScoped<IRoundingPolicyRepository, RoundingPolicyRepository>();

            services.AddAutoMapper(
                typeof(CurrencyProfile),
                typeof(RoundingPolicyProfile),
                typeof(ConverterProfile));

            return services;
        }
    }
}
