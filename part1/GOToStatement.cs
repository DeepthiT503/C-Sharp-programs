using System;
using System.Collections.Generic;
using System.Text;

namespace part1
{
    public class GOToStatement
    {
        // goto is also known as jump statement and is used to transfer the flow to other parts
        static void Main(string[] args)
        {
        ineligible:
            Console.WriteLine("You are not eligible to vote!");

            Console.WriteLine("Enter your age:\n");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age < 18)
            {
                goto ineligible;
            }
            else
            {
                Console.WriteLine("You are eligible to vote!");
            }
        }   }
}
