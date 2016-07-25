using System.Linq;

namespace StringCalculatorLibrary
{
    public static class StringCalculator
    {
        public static int Add(string numbersString)
        {
            var parseInfo = new ParseInfo(numbersString);

            var tokens = StringTokenizer.Tokenize(parseInfo);

            return tokens.Select(int.Parse).Sum();
        }
    }
}