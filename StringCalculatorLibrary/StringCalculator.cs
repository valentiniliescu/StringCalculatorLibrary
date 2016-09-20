using System;
using System.Globalization;
using System.Linq;

namespace StringCalculatorLibrary
{
    public static class StringCalculator
    {
        private static readonly char[] DefaultSeparators = { ',', '\n' };

        public static int Add(string input)
        {
            string numbersString;
            char[] separators;

            if (input.StartsWith("//"))
            {
                numbersString = input.Substring(4);
                separators = DefaultSeparators.Concat(new[] {input[2]}).ToArray();
            }
            else
            {
                numbersString = input;
                separators = DefaultSeparators;
            }

            return numbersString
               .Split(separators, StringSplitOptions.RemoveEmptyEntries)
               .Select(numberString => int.Parse(numberString, NumberStyles.Integer, CultureInfo.InvariantCulture))
               .Sum();
        }
    }
}