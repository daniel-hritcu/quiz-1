using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz1.Methods
{
    class TupleQuestion
    {
        static void Answer()
        {
            //X3 - Use Tuple to create an object which has 3 fields(name, age, address) and print the fields in the console.
            //Xa.User Interpolation => $””
            //Xb.Use Format({ 0})
            var tuple = Tuple.Create<string, int, string>("Daniel", 28, "12379 Av Lapierre");
            Console.WriteLine($"name: {0}, age: {1}, address: {2};", tuple.Item1, tuple.Item2, tuple.Item3);
        }
    }
}
