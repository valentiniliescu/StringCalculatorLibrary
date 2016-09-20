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
            if (numbersString.StartsWith("//"))
            {
                return numbersString.Substring(4)
                .Split(Separators.Concat(new [] {numbersString[2]}).ToArray(), StringSplitOptions.RemoveEmptyEntries)
                .Select(numberString => int.Parse(numberString, NumberStyles.Integer, CultureInfo.InvariantCulture))
                .Sum();
            }

            return numbersString
                .Split(Separators, StringSplitOptions.RemoveEmptyEntries)
                .Select(numberString => int.Parse(numberString, NumberStyles.Integer, CultureInfo.InvariantCulture))
                .Sum();
        }
    }
}