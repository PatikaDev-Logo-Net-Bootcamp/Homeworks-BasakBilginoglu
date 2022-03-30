using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homeworkfour.Bussiness.Extensions
{
    public static class IntegerExtensions
    {
        public static bool IsGreaterThan(this int number)
        {
            return number > 0;
        }
    }
   
}
