using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Globalization;
using System.Linq;
using JetBrains.Annotations;

namespace StringCalculatorLibrary
{
    public static class NumbersStringParser
    {
        public static readonly ImmutableArray<char> DefaultSeparators = new [] { ',', '\n' }.ToImmutableArray();

        [Pure, NotNull]
        public static ParseData Parse([NotNull] string input)
        {
            string numbersString;
            IEnumerable<char> separators;

            if (input.StartsWith("//"))
            {
                numbersString = input.Substring(4);
                separators = DefaultSeparators.Concat(new[] { input[2] });
            }
            else
            {
                numbersString = input;
                separators = DefaultSeparators;
            }

            return new ParseData(separators, numbersString);
        }

        [Pure, NotNull]
        public static string[] Tokenize([NotNull] ParseData parseData)
        {
            return parseData.NumbersString
                .Split(parseData.Separators, StringSplitOptions.RemoveEmptyEntries);
        }

        [Pure, NotNull]
        public static IEnumerable<int> Lex([NotNull] string[] tokens)
        {
            return tokens
                .Select(numberString => int.Parse(numberString, NumberStyles.Integer, CultureInfo.InvariantCulture));
        }
    }
}