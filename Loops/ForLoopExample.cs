using System;

namespace Loops
{
    internal class ForLoopExample
    {
        static void Main(string[] args)
        {
            // printing  1 to 10 numbers
            for(int i = 1; i <= 10; i = i + 1)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            // print the numbers from 20 to 10
            for(int i=20; i>=0; i--)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            // print the numbers from 1 to 5 stop the loop when it equal to 3
            for(int i = 1; i <= 5; i++)
            {
                if (i == 3)
                {
                    break;
                }
                Console.Write(i + " ");
            }
            Console.WriteLine();
            // print the numbers from 20 to 10 with an decrement of 2
            for(int i=20; i>=0; i=i-2)
            {
                Console.Write(i + " ");
            }
            
        }
    }
}
