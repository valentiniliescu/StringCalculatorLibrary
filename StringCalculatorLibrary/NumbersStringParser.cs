using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Globalization;
using System.Linq;
using System.Threading;
using JetBrains.Annotations;

namespace StringCalculatorLibrary
{
    public static class NumbersStringParser
    {
        public static readonly ImmutableArray<char> DefaultSeparators = new[] { ',', '\n' }.ToImmutableArray();

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
        public static Tokens Tokenize([NotNull] ParseData parseData)
        {
            var strings = parseData.NumbersString
                .Split(parseData.Separators, StringSplitOptions.RemoveEmptyEntries);

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