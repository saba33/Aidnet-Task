using AutoShop_Domain.POCO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoShop_Data
{
    public interface ICarFeatureRepository
    {
        public Task<IEnumerable<CarFeatures>> GetAllAsync();
        public Task<CarFeatures> GetAsync(Guid id);
        public Task<CarFeatures> GetByCarIdAsync(Guid carId);
        public Task<bool> CreateCarFeaturesAsync(CarFeatures carFeatureModel, Guid id);
        public Task<bool> UpdateCarFeaturesAsync(CarFeatures carFeatureModel, Guid id);
        public Task<bool> DeleteCarFeaturesAsync(Guid id);
    }
}
