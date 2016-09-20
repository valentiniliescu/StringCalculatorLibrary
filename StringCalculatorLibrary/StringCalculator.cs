using System;
using System.Globalization;
using System.Linq;

namespace StringCalculatorLibrary
{
    public static class StringCalculator
    {
        private static readonly char[] Separators = { ',', '\n' };

        public static int Add(string numbersString)
        {
            return numbersString
                .Split(Separators, StringSplitOptions.RemoveEmptyEntries)
                .Select(numberString => int.Parse(numberString, NumberStyles.Integer, CultureInfo.InvariantCulture))
                .Sum();
        }
    }
}