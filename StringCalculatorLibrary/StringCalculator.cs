using System;
using System.Globalization;
using System.Linq;

namespace StringCalculatorLibrary
{
    public static class StringCalculator
    {
        public static int Add(string input)
        {
            var parseData = NumbersStringParser.Parse(input);

            return parseData.NumbersString
               .Split(parseData.Separators, StringSplitOptions.RemoveEmptyEntries)
               .Select(numberString => int.Parse(numberString, NumberStyles.Integer, CultureInfo.InvariantCulture))
               .Sum();
        }
    }
}