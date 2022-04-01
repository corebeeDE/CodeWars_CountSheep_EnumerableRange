using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars_CountSheep_EnumerableRange
{
    class Program
    {
        static void Main(string[] args)
        {
            // https://www.codewars.com/kata/5b077ebdaf15be5c7f000077
        }

        // First solution:
        public static string CountSheep(int n)
        {
            if (n == 0)
            {
                return String.Empty;
            }
            else
            {
                string output = String.Empty;
                for (int ctr = 0; ctr < n; ctr++)
                    output += $"{ctr + 1} sheep...";
                return output;
            }
        }

        // Refactored version:
        public static string CountSheepTwo(int n)
        {
            return string.Concat(Enumerable.Range(1, n).Select(i => $"{i} sheep..."));
        }
    }
}
