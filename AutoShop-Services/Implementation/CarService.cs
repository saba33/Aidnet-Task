using AutoShop_Data;
using AutoShop_Services.Abstraction;
using AutoShop_Services.Exceptions;
using AutoShop_Services.Models.Car;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mapster;
using AutoShop_Domain.POCO;

namespace AutoShop_Services.Implementation
{
    public class CarService : IAutoService
    {
        private readonly ICarRepository _carRepository;
        public CarService (ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }
        public bool Create(CarServiceModel car)
        {
            var carToInsert = car.Adapt<Car>();
            _carRepository.CreateCar(carToInsert);
            return true;
        }

        public bool Delete(Guid id)
        {
            var delCar = _carRepository.GetCar(id);
            if (delCar == null)
                throw new ObjectNotFoundException("object couldn't fount with this id");
            _carRepository.DeleteCar(id);
            return true;
        }

        public IEnumerable<CarServiceModel> GetAll()
        {
            var cars = _carRepository.GetAll();
            if (cars == null)
                throw new Exception("Database is Empty");
            return cars.Adapt<List<CarServiceModel>>();
        }

        public CarServiceModel Get(Guid id)
        {
            var car = _carRepository.GetCar(id);
            if (car == null)
                throw new ObjectNotFoundException("the Id is not valid, couldn't find object");
            return car.Adapt<CarServiceModel>();
        }

        public bool Update(Guid id, CarServiceModel car)
        {
            var carToUpdate = car.Adapt<Car>();
            return _carRepository.UpdateCar(id, carToUpdate);
        }
    }
}
