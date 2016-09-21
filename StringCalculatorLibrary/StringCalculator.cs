using System;
using System.Globalization;
using System.Linq;
using JetBrains.Annotations;

namespace StringCalculatorLibrary
{
    public static class StringCalculator
    {
        [Pure]
        public static int Add([NotNull] string input)
        {
            var parseData = NumbersStringParser.Parse(input);

            return parseData.NumbersString
               .Split(parseData.Separators, StringSplitOptions.RemoveEmptyEntries)
               .Select(numberString => int.Parse(numberString, NumberStyles.Integer, CultureInfo.InvariantCulture))
               .Sum();
        }
    }
}