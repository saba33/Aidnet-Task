using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aidnet_Task.Models.Requests
{
    public class UpdateCarRequest
    {
        public string Model { get; set; }
        public string ReleaseYear { get; set; }
        public string AboutCar { get; set; }
        public string Image { get; set; }
        public decimal Price { get; set; }
        public String Currency { get; set; }
    }
}
