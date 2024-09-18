using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5._2._2
{
    internal class NatNums
    {
        //Write a program in C# Sharp to print the first n natural number using recursion. 
        static void Main(string[] args)
        {
            NaturalNums(1);
        }

        static void NaturalNums(int n)
        {
            if (n <= 10)
            {
                Console.WriteLine(n.ToString());
                NaturalNums(n + 1);
            }
        }
    }
}
