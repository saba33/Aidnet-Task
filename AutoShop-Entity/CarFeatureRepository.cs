using AutoShop_Data;
using AutoShop_Domain.POCO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AutoShop_Entity
{
    public class CarFeatureRepository : ICarFeatureRepository
    {

        private readonly CarContext _carcontext;

        public CarFeatureRepository(CarContext carcontext)
        {
            _carcontext = carcontext;
        }
        public Task<bool> CreateCarFeaturesAsync(CarFeatures carFeatureModel, Guid carId)
        {
            if (carFeatureModel != null)
            {
                carFeatureModel.Id = Guid.NewGuid();
                carFeatureModel.CarId = carId;
                _carcontext.carFeatures.Add(carFeatureModel);
                _carcontext.SaveChanges();
                return Task.FromResult(true);
            }
            else
                throw new Exception("CarFeaturesModel is NUll   !!!");
        }

        public async Task<bool> DeleteCarFeaturesAsync(Guid FeaturesId)
        {
            var carFeatures = _carcontext.carFeatures.FirstOrDefault(x => x.Id == FeaturesId);
            if(carFeatures != null)
            {
                _carcontext.carFeatures.Remove(carFeatures);
                _carcontext.SaveChanges();
                return await Task.FromResult(true);
            }
            throw new Exception("Car couldn't found with this ID");
        }

        public async Task<IEnumerable<CarFeatures>> GetAllAsync()
        {
            return await Task.FromResult(_carcontext.carFeatures);
        }

        public async Task<CarFeatures> GetAsync(Guid id)
        {
            return await Task.FromResult(_carcontext.carFeatures.FirstOrDefault(x => x.Id == id));
        }
        public async Task<CarFeatures> GetByCarIdAsync(Guid carId)
        {
            return await Task.FromResult(_carcontext.carFeatures.FirstOrDefault(x => x.Id == carId));
        }

        public async Task<bool> UpdateCarFeaturesAsync(CarFeatures carmodel, Guid id)
        {
            var carFeatures = _carcontext.carFeatures.FirstOrDefault(x => x.Id == id);
            if (carFeatures != null && carmodel != null)
            {
                _carcontext.Entry<CarFeatures>(carFeatures).CurrentValues.SetValues(carmodel);
                _carcontext.SaveChanges();
                return await Task.FromResult(true);
            }
            else
                throw new Exception("Couldn't Update Model, car model or is null or id is not valid !!");
        }
    }
}
