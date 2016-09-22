using System;
using System.Globalization;
using System.Linq;
using JetBrains.Annotations;

namespace StringCalculatorLibrary
{
    public static class NumbersStringParser
    {
        public static readonly Separators DefaultSeparators = new Separators(new[] { ',', '\n' });

        [Pure, NotNull]
        public static ParseData Parse([NotNull] string input)
        {
            string numbersString;
            Separators separators;

            if (input.StartsWith("//"))
            {
                numbersString = input.Substring(4);
                separators = DefaultSeparators.Add(input[2]);
            }
            else
            {
                numbersString = input;
                separators = DefaultSeparators;
            }

            return new ParseData(separators, numbersString);
        }

        [Pure, NotNull]
        public static Tokens Tokenize([NotNull] ParseData parseData)
        {
            var strings = parseData.NumbersString
                .Split(parseData.Separators.ToArray(), StringSplitOptions.RemoveEmptyEntries);

            return new Tokens(strings);
        }

        [Pure, NotNull]
        public static NumericTokens Lex([NotNull] Tokens tokens)
        {
            var numbers = tokens
                .Select(numberString => int.Parse(numberString, NumberStyles.Integer, CultureInfo.InvariantCulture));
            return new NumericTokens(numbers);
        }
    }
}