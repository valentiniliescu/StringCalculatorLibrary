using System;
using System.Globalization;

namespace StringCalculatorLibrary
{
    public static class StringCalculator
    {
        public static int Add(string numbersString)
        {
            int result;
            if (numbersString == string.Empty)
            {
                result = 0;
            }
            else
            {
                result = int.Parse(numbersString, NumberStyles.Integer, CultureInfo.InvariantCulture);
            }
            return result;
        }
    }
}