using System.Collections.Generic;
using System.Linq;

namespace StringCalculatorLibrary
{
    public static class StringCalculator
    {
        public static int Add(string numbersString)
        {
            var parseInfo = ParseInfo.CreateFrom(numbersString);

            var tokens = StringTokenizer.Tokenize(parseInfo);

            var numbers = tokens.Select(int.Parse);

            CheckForNegatives(numbers);

            return numbers.Sum();
        }

        private static void CheckForNegatives(IEnumerable<int> numbers)
        {
            var negatives = numbers.Where(n => n < 0);

            if (negatives.Any())
                throw new NegativeException(negatives);
        }
    }
}