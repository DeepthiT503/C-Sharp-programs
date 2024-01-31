using System;
using System.Collections.Generic;
using System.Text;
namespace part1
{
    public class String1
    {
        static void Main(string[] args)
        {
            string str = "Iam Belongs to Anantapur";
            Console.WriteLine(str);
            // It will convert all the characters to the lowercase letters
            Console.WriteLine(str.ToLower());
            Console.WriteLine(str.ToUpper());

            Console.WriteLine("The length of the string is: " +str.Length);
            Console.WriteLine("The Character at 2nd position is: "+str[2]);
            //trying to find out the particular element index
            Console.WriteLine("The postion of the character 'a' is: " + str.IndexOf("a"));
            // We can combine the two strings by using + or by string interpotation
            string firstName = "Deepthi";
            string lastName = "Thalari";
            string name = firstName + lastName;
            // by concantenation
            Console.WriteLine("The full name is: " + name);
            // By string interpotation
            Console.WriteLine($"The full name is: {name}");
            string y = "She is One of the Most \"Beautiful\" girl";
            Console.WriteLine(y);

        }
    }
}
