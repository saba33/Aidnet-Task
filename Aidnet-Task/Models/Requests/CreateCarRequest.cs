using Aidnet_Task.Infrastructure.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aidnet_Task.Models.Requests
{
    public class CreateCarRequest
    {
        //public Guid Id { get; set; }
        public string Model { get; set; }
        public string ReleaseYear { get; set; }
        public string AboutCar { get; set; }
        public string Image { get; set; }
        public decimal Price { get; set; }
        [UpperCaseAttribute]
        public String Currency { get; set; }
    }
}
