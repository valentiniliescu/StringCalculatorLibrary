using System;
using System.Globalization;
using System.Linq;

namespace StringCalculatorLibrary
{
    public static class StringCalculator
    {
        public static int Add(string input)
        {
            var parseInfo = new ParseInfo(input);

            return parseInfo.NumbersString
               .Split(parseInfo.Separators, StringSplitOptions.RemoveEmptyEntries)
               .Select(numberString => int.Parse(numberString, NumberStyles.Integer, CultureInfo.InvariantCulture))
               .Sum();
        }
    }
}