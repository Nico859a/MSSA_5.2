using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5._2._3
{
    internal class RevNums
    {
        //Write a program in C# Sharp to print numbers from n to 1 using recursion. 
        static void Main(string[] args)
        {
            ReverseNatNums(10);
        }

        static void ReverseNatNums(int n)
        {
            if (n>= 1)
            {
                Console.WriteLine(n.ToString());
                ReverseNatNums(n - 1);
            }
        }
    }
}
