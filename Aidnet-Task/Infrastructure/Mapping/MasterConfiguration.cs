using Aidnet_Task.Models;
using Aidnet_Task.Models.Dtos;
using Aidnet_Task.Models.Requests;
using AutoShop_Domain.POCO;
using AutoShop_Services.Models.Car;
using AutoShop_Services.Models.CarFeatures;
using Mapster;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aidnet_Task.Infrastructure.Mapping
{
    public static class MasterConfiguration
    {
        public static void RegisterMap(this IServiceCollection collection)
        {
            TypeAdapterConfig<CarServiceModel, Car>
            .NewConfig()
            .TwoWays();

            TypeAdapterConfig<Car, CarServiceModel>
            .NewConfig()
            .TwoWays();

            TypeAdapterConfig<CreateCarRequest, CarServiceModel>
           .NewConfig()
           .TwoWays();

            TypeAdapterConfig<CarServiceModel, CreateCarRequest>
           .NewConfig()
           .TwoWays();

            TypeAdapterConfig<CarServiceModel, CarDto>
          .NewConfig()
          .TwoWays();

            TypeAdapterConfig<CarFeaturesServiceModel, CarFeatures>
           .NewConfig()
           .TwoWays();

            TypeAdapterConfig<CarFeatures, CarFeaturesServiceModel>
           .NewConfig()
           .TwoWays();

            TypeAdapterConfig<CreateCarFeaturesRequest, CarFeaturesServiceModel>
           .NewConfig()
           .TwoWays();

            TypeAdapterConfig<UpdateCarFeaturesRequest, CarFeaturesServiceModel>
           .NewConfig()
           .TwoWays();
        }
    }
}
