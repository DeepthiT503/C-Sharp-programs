using System;
using System.Collections.Generic;
using System.Text;
//TypeCasting is nothing but converting from one data type to another data type, there are two types
// of casting are there 1.Implicit Casting 2.Explicit Casting
namespace part1
{
    internal class Typecasting
    {
        static void Main(string[] args)
        {
            // implicit casting - Convertion from lower data type to higher data type
            int x = 12;
            double y = x;
            Console.WriteLine("Implicit Conversion");
            Console.WriteLine(x);
            Console.WriteLine(y);
            // explicit casting - Convertion from bigger data type to smaller data type
            double d = 34.5D;
            int z = (int) d;
            Console.WriteLine("Explicit Conversion");
            Console.WriteLine(d);
            Console.WriteLine(z);
        }
    }
}
