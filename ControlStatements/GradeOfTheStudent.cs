using System;
using System.Collections.Generic;
using System.Text;

namespace part1
{
    internal class GradeOfTheStudent
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Marks of the Student: ");
            int marks = Convert.ToInt32(Console.ReadLine());
            if(marks >=90 && marks <= 100)
            {
                Console.WriteLine("The Student secured 'A' Grade");
            }
            else if(marks >= 80 && marks <= 90)
            {
                Console.WriteLine("The Student secured 'B' Grade");
            }
            else if(marks >= 70 && marks <= 80)
            {
                Console.WriteLine("The Student secured 'C' Grade"); 
            }
            else if(marks >= 60 && marks <= 50)
            {
                Console.WriteLine("The Student secured 'D' Grade");
            }
            else
            {
                Console.WriteLine("The Student had failed int the Exam");
            }
        }
    }
}
