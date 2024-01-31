using System;
using System.Collections.Generic;
using System.Text;

namespace Loops
{
    internal class DoWhile
    {
        static void Main(string[] args)
        {
            // printing the elements from 1 to 5

            int i = 0;
            do
            {
                Console.Write(i + " ");
                i++;
            } while (i <= 5);
            Console.WriteLine();

            // printing the numbers from 10 to 1;
            int j = 10;
            do
            {
                Console.Write(j + " ");
                j--;
            } while (j >= 1);
        }
    }
}
