using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5._2
{
    internal class LastWord
    {
        static void Main(string[] args)
        {
            //Given a string s consisting of words and spaces, return the length of the last word in the string. A word is a maximal substring consisting of non-space characters only.
            string s = "I like to run";
            int result = LengthOfLastWord(s);
            Console.WriteLine($"{result}");
        }
        static int LengthOfLastWord(string s)
        {
            int length = 0;
            s = s.Trim();

            for (int i = s.Length - 1; i >= 0; i--)
            {
                if (s[i] != ' ')
                {
                    length++;
                }
                else if (length > 0)
                {
                    break;
                }
            }
            return length;
        }
    }

}


