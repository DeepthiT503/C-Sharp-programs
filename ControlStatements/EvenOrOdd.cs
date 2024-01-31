using System;
using System.Collections.Generic;
using System.Text;

namespace part1
{
    internal class EvenOrOdd
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            if(num % 2 == 0)
            {
                Console.WriteLine("Its a Even Number");
            }
            else
            {
                Console.WriteLine("Its a Odd Number");
            }
           /* int num = 5;
            if(num % 2 == 0)
            {
                Console.WriteLine("Its a Even Number");
            }
            else
            {
                Console.WriteLine("Its a Odd Number");
            }*/
        }
    }
}
