using System.Linq;

namespace StringCalculatorLibrary
{
    public class ParseInfo
    {
        public string NumbersString { get; }
        public char[] Separators { get; }

        public ParseInfo(string numbersString)
        {
            Separators = DefaultSeparators;
            NumbersString = numbersString;

            if (NumbersString.StartsWith("//"))
            {
                NumbersString = NumbersString.Substring(3);
                Separators = Separators.Union(new[] { numbersString[2] }).ToArray();
            }
        }

        private static readonly char[] DefaultSeparators = { ',', '\n'};
    }
}