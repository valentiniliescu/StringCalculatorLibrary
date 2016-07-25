using System;
using System.Linq;

namespace StringCalculatorLibrary
{
    public static class StringCalculator
    {
        private static readonly char[] DefaultSeparators = { ',', '\n'};

        public static int Add(string numbersString)
        {
            if (numbersString.StartsWith("//"))
            {
                return numbersString.Substring(3)
                    .Split(DefaultSeparators.Union(new[]{numbersString[2]}).ToArray(), StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .Sum();
            }
            else
            {
                return numbersString
                    .Split(DefaultSeparators, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .Sum();
            }
        }
    }
}