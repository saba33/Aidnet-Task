using AutoShop_Data;
using AutoShop_Domain.POCO;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoShop_Entity
{
    public class CarRepository : ICarRepository
    {
        private readonly CarContext _carcontext;

        public CarRepository(CarContext carcontext)
        {
            _carcontext = carcontext;
        }

        public Task<bool> CreateCar(Car carmodel)
        {
            carmodel.Id = Guid.NewGuid();
            _carcontext.Add(carmodel);
            _carcontext.SaveChanges();
            return Task.FromResult(true);
        }

        public Task<bool> DeleteCar(Guid id)
        {
            var car = _carcontext.cars.FirstOrDefault(x => x.Id == id);
            _carcontext.cars.Remove(car);
            _carcontext.SaveChanges();
            return Task.FromResult(true);
        }

        //public async Task<bool> GetFullInfoAsync() 
        //{

        //}

        public IEnumerable<Car> GetAll()
        {
            return _carcontext.cars;
        }

        public Car GetCar(Guid id)
        {
            return _carcontext.cars.FirstOrDefault(x => x.Id == id);
        }

        public bool UpdateCar(Guid id, Car carmodel)
        {
            var car = _carcontext.cars.FirstOrDefault(x => x.Id == id);
            if (car != null)
            {
                // _carcontext.Entry<Car>(car).CurrentValues.SetValues(carmodel);
                _carcontext.Update<Car>(car).CurrentValues.SetValues(carmodel);
                _carcontext.SaveChanges();
                return true;
            }
            else
                throw new Exception("Car doesn't exist with this Id");
        }
    }
}
