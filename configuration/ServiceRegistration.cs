using CourierService.Contracts;
using CourierService.Services;
using CourierService.Strategies;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourierService.Configuration
{
    public static class ServiceRegistration
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddTransient<IDiscountStrategy, PercentageDiscount5>();
            services.AddTransient<IDiscountStrategy, PercentageDiscount7>();
            services.AddTransient<IDiscountStrategy, PercentageDiscount10>();


            services.AddTransient<DiscountService>();
            services.AddTransient<BasePriceCalculationService>();

            return services;
        }
    }
}
