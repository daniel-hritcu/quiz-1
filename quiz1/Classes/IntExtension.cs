using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//6- Use Extension method for integer to check if the number is dividable by 3
namespace quiz1.Classes
{
    public static class IntExtension
    {
        public static bool isDivisibleByThree(this int number) {
            if (number % 3 == 0)
            {
                return true;
            }
            else 
            {
                return false;
            }
        }
    }
}
