using System.Linq;

namespace StringCalculatorLibrary
{
    public static class NumbersStringParser
    {
        private static readonly char[] DefaultSeparators = { ',', '\n' };

        public static ParseData Parse(string input)
        {
            string numbersString;
            char[] separators;

            if (input.StartsWith("//"))
            {
                numbersString = input.Substring(4);
                separators = DefaultSeparators.Concat(new[] { input[2] }).ToArray();
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