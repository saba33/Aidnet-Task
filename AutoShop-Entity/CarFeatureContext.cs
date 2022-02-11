using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoShop_Entity
{
    class CarFeatureContext:DbContext
    {
        public CarFeatureContext(DbContextOptions options) : base(options)
        {

        }

    }
}
