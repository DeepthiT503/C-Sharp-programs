using System;
using System.Collections.Generic;
using System.Text;

namespace part1
{
    internal class InfiniteLoop
    {
        // infinite loop will go on executing
        static void Main(string[] args)
        {
            for(;;)
            {
                Console.WriteLine("Hello World");
            }
        }
    }
}
