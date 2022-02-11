using AutoShop_Services.Abstraction;
using AutoShop_Services.Implementation;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aidnet_Task.Infrastructure.Extensions
{
    public static class ServiceExtensions
    {
        public static void AddServices(this IServiceCollection services)
        {
            services.AddScoped<IAutoService, CarService>();
            services.AddScoped<ICarFeaturesService, CarFeaturesServices>();

            #region Repositories

            services.AddRepositories();

            #endregion
        }
    }
}
