using System;
using System.Collections.Generic;
using System.Text;

namespace part1
{
    internal class Table
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Table Number to Printed: ");
            int num = Convert.ToInt32(Console.ReadLine());

            for(int i = 1; i <= 10; i++)
            {
                int result = num * i;
                Console.WriteLine(num + "*" + i + " = " + result);
            }
        }
    }
}
