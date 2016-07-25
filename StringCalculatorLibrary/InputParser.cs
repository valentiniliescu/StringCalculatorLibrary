using System;
using System.Linq;

namespace StringCalculatorLibrary
{
    public static class InputParser
    {
        public static string[] Tokenize(string numbersString)
        {
            var separators = DefaultSeparators;
            if (numbersString.StartsWith("//"))
            {
                numbersString = numbersString.Substring(3);
                separators = separators.Union(new[] {numbersString[2]}).ToArray();
            }

            return numbersString.Split(separators, StringSplitOptions.RemoveEmptyEntries);
        }

        private static readonly char[] DefaultSeparators = { ',', '\n'};
    }
}