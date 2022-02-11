using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoShop_Services.Exceptions
{
    public class ObjectNotFoundException:Exception
    {
        public string Code = "ObjectNotFound";

        public ObjectNotFoundException(string errorText) : base(errorText) { }
    }
}
