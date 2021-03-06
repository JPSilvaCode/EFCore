using System;
using EFCData.Data;
using EFCDomain.Data;
using Microsoft.Extensions.DependencyInjection;

namespace EFCWebAPI.Configurations
{
    public static class DependencyInjectionConfig
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            if (services == null) throw new ArgumentNullException(nameof(services));

            services.AddScoped<ICustomerData, CustomerData>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
        }
    }
}