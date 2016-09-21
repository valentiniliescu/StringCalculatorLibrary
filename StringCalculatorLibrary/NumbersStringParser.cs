using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using JetBrains.Annotations;

namespace StringCalculatorLibrary
{
    public static class NumbersStringParser
    {
        public static readonly ImmutableArray<char> DefaultSeparators = new [] { ',', '\n' }.ToImmutableArray();

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
    }
}