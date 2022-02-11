using AutoShop_Domain.POCO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoShop_Data
{
    public interface ICarRepository
    {
        public IEnumerable<Car> GetAll();
        public Car GetCar(Guid id);
        public Task<bool> CreateCar(Car carmodel);
        public bool UpdateCar(Guid id, Car carmodel);
        public Task<bool> DeleteCar(Guid id);

    }
}
