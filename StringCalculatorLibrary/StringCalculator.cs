using System;
using System.Linq;

namespace StringCalculatorLibrary
{
    public static class StringCalculator
    {
        private static readonly char[] DefaultSeparators = { ',', '\n'};

        public static int Add(string numbersString)
        {
            return numbersString
                .Split(DefaultSeparators, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .Sum();
        }
    }
}