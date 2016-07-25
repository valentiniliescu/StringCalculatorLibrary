using System;
using System.Linq;

namespace StringCalculatorLibrary
{
    public static class StringCalculator
    {
        private static readonly char[] DefaultSeparators = { ',', '\n'};

        public static int Add(string numbersString)
        {
            var separators = DefaultSeparators;
            if (numbersString.StartsWith("//"))
            {
                numbersString = numbersString.Substring(3);
                separators = separators.Union(new[]{numbersString[2]}).ToArray();
                
            }

            var tokens = numbersString
                .Split(separators, StringSplitOptions.RemoveEmptyEntries);


            return tokens
                    .Select(int.Parse)
                    .Sum();
        }
    }
}