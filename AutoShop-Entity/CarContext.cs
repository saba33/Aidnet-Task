using AutoShop_Domain.POCO;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoShop_Entity
{
    public  class CarContext : DbContext
    {
        public CarContext(DbContextOptions options) :base(options)
        {

        }
        public  DbSet<Car> cars { get; set; }
        public DbSet<CarFeatures> carFeatures { get; set; }
    }
}
