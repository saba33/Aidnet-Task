using AutoShop_Services.Models.Car;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoShop_Services.Abstraction
{
    public interface IAutoService
    {
        IEnumerable<CarServiceModel> GetAll();
        CarServiceModel Get(Guid id);
        bool Create(CarServiceModel car);
        bool Update(Guid id, CarServiceModel car);
        bool Delete(Guid id);
    }
}


