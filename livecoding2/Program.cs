using System;
using System.Collections.Generic;

namespace livecoding2
{
    class Program
    {
        static void Main(string[] args)
        {

            string s = Console.ReadLine();

            Console.WriteLine(longRepeat(s));

        }


        static int longRepeat(string s)
        {
            int longestSubstring = 1;
            int temp = 1;

            for(int i = 0; i < s.Length-1; i++)
            {
                if (s[i] == s[i+1])
                {
                    temp += 1;
                }
                else
                {
                    if(temp > longestSubstring)
                        longestSubstring = temp;
                    temp = 1;
                }
            }

            return longestSubstring;

        }

    }
}
