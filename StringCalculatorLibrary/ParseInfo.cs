using System.Linq;

namespace StringCalculatorLibrary
{
    public class ParseInfo
    {
        private static readonly char[] DefaultSeparators = { ',', '\n' };

        public string NumbersString { get; }
        public char[] Separators { get; }

        public ParseInfo(string numbersString, char[] separators)
        {
            NumbersString = numbersString;
            Separators = separators;
        }

        public static ParseInfo CreateFrom(string numbersString)
        {
            var separators = DefaultSeparators;
            if (numbersString.StartsWith("//"))
            {
                separators = separators.Union(new[] { numbersString[2] }).ToArray();
                numbersString = numbersString.Substring(4);
            }

            return new ParseInfo(numbersString, separators);
        }
    }
}