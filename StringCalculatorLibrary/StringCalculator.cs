using System;
using System.Collections.Generic;
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
            var tokens = NumbersStringParser.Tokenize(parseData);
            var numericTokens = NumbersStringParser.Lex(tokens);

            return numericTokens.Sum();
        }
    }
}