using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoShop_Domain.POCO
{


    public class CarFeatures
    {
        public Guid Id { get; set; }
        public Guid CarId { get; set; }
        public bool ABS { get; set; }
        public bool ElectricWindows { get; set; }
        public bool Hatch { get; set; }
        public bool Bluetooth { get; set; }
        public bool AlarmSystem { get; set; }
        public bool ParkControl { get; set; }
        public bool Navigation { get; set; }
        public bool BoardComputer { get; set; }
        public bool MultiWheel { get; set; }

    }
}
