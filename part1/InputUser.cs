using System;
using System.Collections.Generic;
using System.Text;

namespace part1
{
    internal class InputUser
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the UserName: ");
            string name = Console.ReadLine();
            Console.WriteLine("User Name is: " + name);

            Console.WriteLine("Enter the User Age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("User Age is: " + age);
        }
    }
}
