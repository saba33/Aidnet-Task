using AutoShop_Domain.POCO;
using AutoShop_Services.Models.CarFeatures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoShop_Services.Abstraction
{
    public interface ICarFeaturesService
    {
        Task<CarFeaturesServiceModel> Get(Guid id);
        Task<bool> Create(CarFeaturesServiceModel car, Guid id);
        Task<bool> Update(Guid id, CarFeaturesServiceModel car);
        Task<bool> Delete(Guid id);
        public Task<CarFeaturesServiceModel> GetByFeaturesId(Guid id);
        public Task<IEnumerable<CarFeaturesServiceModel>> GetAll();
    }
}
