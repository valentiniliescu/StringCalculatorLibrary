using System.Linq;

namespace StringCalculatorLibrary
{
    public static class StringCalculator
    {
        public static int Add(string numbersString)
        {
            var tokens = InputParser.Tokenize(numbersString);

            return tokens
                    .Select(int.Parse)
                    .Sum();
        }
    }
}