using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ConsoleApp2
{
    static class Extension
    {
        static int factorial = 1;
        public static int CheckFactorial(this int num)
        {
            for (int i = 1; i <= num; i++)
            {
                factorial *= i;

            }
            return factorial;
        }

        static int count =0;

        public static int Checkstr(this string a, string pattern)
        {
            string[] b = a.Split("");

            return Regex.Matches(a, pattern).Count;

        }
       
    }
}
