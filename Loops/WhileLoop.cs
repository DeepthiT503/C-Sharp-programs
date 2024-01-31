using System;
using System.Collections.Generic;
using System.Text;

namespace Loops
{
    public class WhileLoop
    {
        static void Main(string[] args)
        {
            // print the numbers from 15 to 20
            int i = 15;
            while (i <= 20)
            {
                Console.Write(i + " ");
                i++;
            }
            Console.WriteLine();
            // print the numbers from 20 to 10
            int j = 20;
            while (j >= 10)
            {
                Console.Write(j + " ");
                j--;
            }
            Console.WriteLine();

            // print the numbers from 1 to 10 and  stop the loop when it is equal to
            // 5
            int k = 1;
            while (k <= 10)
            {
                Console.Write(k + " ");
                k++;
                if (k == 5)
                {
                    break;
                }
            }
            Console.WriteLine();
            // except 2 remaining numbers to be printed from 1 to 10
            int x = 1;
            while (x <= 10)
            {
                if(x == 2)
                {
                    x++;
                    continue;
                }
                Console.Write(x + " ");
                x++;
            }
        } 
    }
}
