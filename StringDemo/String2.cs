using System;
using System.Globalization;
using System.Threading;

namespace StringDemo
{
    internal class String2
    {
        static void Main(string[] args)
        {
            // The C# Clone() method is used to clone a string object, It returns
            // another copy of same data. The return type of Clone() method is object.
            string str1 = "Hello, Welcome to the party";
            string str2 = (String)str1.Clone();
            Console.WriteLine(str1);
            Console.WriteLine(str2);
            // string compare() method is used to compare two strings, if both are equal
            // it returns 0, if first string is greater than second string it returns 1
            // if first string is lesser than second string it returns -1
            string x = "hello";
            string y = "hello";
            string z = "hi";
            string a = "EveryOne Welcome to the Party";
            Console.WriteLine(String.Compare(x, y));
            Console.WriteLine(String.Compare(x, z));
            Console.WriteLine(String.Compare(x, a));

            //substring will return the some part of the string.
            Console.WriteLine("Some part of the string is: " + a.Substring(9));
            //Replace will the specified string with mentioned one
            Console.WriteLine(a.Replace("EveryOne", "All"));
            //Contains() checks whether particular one is present or not
            Console.WriteLine(a.Contains("to"));
            Console.WriteLine(a.StartsWith('E'));
            Console.WriteLine(a.EndsWith("All"));
            Console.WriteLine(a.Equals(z));//checks two strings have equal value or not
            string y1 = "hello, to, all";
            string[] z1 = y1.Split(',');
            foreach(string i in z1)
            {
                Console.WriteLine(i);
            }
            string t = " hello hi ";
            Console.WriteLine(t.TrimStart());
            // Console.WriteLine(t.Trim());
            //The C# ToCharArray() method is used to get character array from a string object.
            string str = "Self Confidence";
            char[] ch = str.ToCharArray();
            foreach(char c in ch)
            {
                Console.Write(c+" ");
            }
            Console.WriteLine();
            // Different ways of writing string
            string s = "hello";
            char[] c1 = { 'a', 'b', 'd'};
            string s1 = new string(c1);
            Console.WriteLine(s);
            Console.WriteLine(s1);
            string t11 = "hello";
            string ts2 = "hello";
            string ts3 = "csharp";
            string ts4 = "mello";
            //here h is greater than c that unicode values differnece we will get 
            // as a output if its postive value we get postive number otherwise we get
            // negative value
            Console.WriteLine(string.CompareOrdinal(t11, ts2));
            Console.WriteLine(string.CompareOrdinal(t11, ts3));
            Console.WriteLine(string.CompareOrdinal(t11, ts4));
            Console.WriteLine(t11.CompareTo(ts2));
            Console.WriteLine(ts2.CompareTo(ts3));
            // Clone() versus Copy() Clone() it will not create new value both refer to
            // the same variable, whereas copy() will create the new value
            String o = String.Copy(ts3);
            Console.WriteLine(o);

        }
    }
}
