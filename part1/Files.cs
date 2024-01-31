using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace part1
{
    public class Files
    {
        public static void FindFileExist()
        {
            string path = @"C:\Users\deept\source\repos\part1\part1\demo.txt";
            if(File.Exists(path))
            {
                Console.WriteLine("File Exists");
            }
            else
            {
                File.Create(path);
                Console.WriteLine("File doesn't exist");
            }
        }
    }
}
