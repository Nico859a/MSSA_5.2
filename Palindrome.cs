using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5._2._4
{
    internal class Palindrome
    {
        //Write a program in C# Sharp to check whether a given string is Palindrome or not using recursion.
        static void Main(string[] args)
        {
            Console.WriteLine(IsPalindrome("Kyle"));
            Console.WriteLine(IsPalindrome("Radar"));
            Console.ReadKey();

        }

        static bool IsPalindrome(string s, int i=0)
        {
            bool result = true;
            s = s.ToLower();

            if (i < s.Length / 2)
            {
                if (!IsPalindrome(s, i + 1))
                {
                    return false;
                }
                else if (s[i] == s[(s.Length - 1) - i])
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return result;
        }
    }
}
