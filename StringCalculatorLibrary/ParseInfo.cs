using System.Linq;

namespace StringCalculatorLibrary
{
    public class ParseInfo
    {
        private static readonly char[] DefaultSeparators = { ',', '\n' };

        public char[] Separators { get; }
        public string NumbersString { get; }

        public ParseInfo(string input)
        {
            if (input.StartsWith("//"))
            {
                NumbersString = input.Substring(4);
                Separators = DefaultSeparators.Concat(new[] { input[2] }).ToArray();
            }
            else
            {
                NumbersString = input;
                Separators = DefaultSeparators;
            }
        }
    }
}