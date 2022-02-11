using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Aidnet_Task.Infrastructure.Attributes
{
    public class UpperCaseAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            var str = value as string;
            return str.All(IsUpperCase);
        }

        private bool IsUpperCase(char c)
        {
            return char.IsUpper(c);
        }
    }
}
