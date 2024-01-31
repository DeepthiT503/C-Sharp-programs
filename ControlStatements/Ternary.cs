using System;

namespace ControlStatements
{
    //ternary operator replaces the if else statement
    internal class Ternary
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number to check whether it is positive or negative:");
            int num = Convert.ToInt32(Console.ReadLine());
            string result = (num > 0) ? "Its a Postive Number" : "Its a Negative Number";
            Console.WriteLine(result);
           }
    } }
