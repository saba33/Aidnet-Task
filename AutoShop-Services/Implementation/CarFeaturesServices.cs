using AutoShop_Data;
using AutoShop_Domain.POCO;
using AutoShop_Entity;
using AutoShop_Services.Abstraction;
using AutoShop_Services.Exceptions;
using AutoShop_Services.Models.CarFeatures;
using Mapster;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoShop_Services.Implementation
{
    public class CarFeaturesServices : ICarFeaturesService
    {
        #region private members
        private readonly ICarFeatureRepository _repo;
        #endregion

        #region ctor
        public CarFeaturesServices(ICarFeatureRepository carFeaturesRepository)
        {
            _repo = carFeaturesRepository;
        }
        #endregion
        public async Task<bool> Create(CarFeaturesServiceModel carFeatures, Guid id)
        {
            var carFeaturesToInsert = carFeatures.Adapt<CarFeatures>();
            return await _repo.CreateCarFeaturesAsync(carFeaturesToInsert, id);
        }

        public async Task<bool> Delete(Guid carId)
        {
            var featuresTodelete = _repo.GetByCarIdAsync(carId);
            if (featuresTodelete != null)
            {
                return await _repo.DeleteCarFeaturesAsync(carId);
            }
            else
                throw new ObjectNotFoundException("object couldn't fount with this id");
        }

        public async Task<CarFeaturesServiceModel> Get(Guid carId)
        {
            var carFeatures =  _repo.GetByCarIdAsync(carId);
            if (carFeatures != null)
            {
                return await Task.FromResult(carFeatures.Adapt<CarFeaturesServiceModel>());
            }
            else
                throw new ObjectNotFoundException("object couldn't fount with this id");
        }

        public async Task<CarFeaturesServiceModel> GetByFeaturesId(Guid featuresId)
        {
            var carFeatures = _repo.GetAsync(featuresId);
            if (carFeatures != null)
            {
                return await Task.FromResult(featuresId.Adapt<CarFeaturesServiceModel>());
            }
            else
                throw new ObjectNotFoundException("object couldn't fount with this id");
        }
        public async Task<IEnumerable<CarFeaturesServiceModel>> GetAll()
        {
            var carsFeatures = await _repo.GetAllAsync();
            if (carsFeatures == null)
                throw new Exception("Database is Empty");
            else
                return await Task.FromResult(carsFeatures.Adapt<List<CarFeaturesServiceModel>>());
        }

        public async Task<bool> Update(Guid id, CarFeaturesServiceModel car)
        {
            var carFeaturesToUpdate =  car.Adapt<CarFeatures>();
            return await _repo.UpdateCarFeaturesAsync(carFeaturesToUpdate, id);
        }
    }
}
