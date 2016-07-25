using System.Linq;

namespace StringCalculatorLibrary
{
    public static class StringCalculator
    {
        public static int Add(string numbersString)
        {
            if (numbersString == string.Empty)
            {
                return 0;
            }
            else
            {
                return numbersString.Split(',', '\n').Select(int.Parse).Sum();
            }
        }
    }
}