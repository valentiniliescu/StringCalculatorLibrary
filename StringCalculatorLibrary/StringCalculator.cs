using System.Linq;

namespace StringCalculatorLibrary
{
    public static class StringCalculator
    {
        private static readonly char[] DefaultSeparators = { ',', '\n'};

        public static int Add(string numbersString)
        {
            if (numbersString == string.Empty)
            {
                return 0;
            }
            else
            {
                return numbersString.Split(DefaultSeparators).Select(int.Parse).Sum();
            }
        }
    }
}