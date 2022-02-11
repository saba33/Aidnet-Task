using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoShop_Services.Models.Car
{
    public class CarServiceModel
    {
        public Guid Id { get; set; }
        public string Model { get; set; }
        public string ReleaseYear { get; set; }
        public string AboutCar { get; set; }
        public string Image { get; set; }
        public decimal Price { get; set; }
        public String Currency { get; set; }
    }
}
