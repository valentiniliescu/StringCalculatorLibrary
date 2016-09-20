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
                var separatorIndex = numbersString.IndexOf(',');
                if (separatorIndex > -1)
                {
                    var number1 = int.Parse(numbersString.Substring(0, separatorIndex), NumberStyles.Integer, CultureInfo.InvariantCulture);
                    var number2 = int.Parse(numbersString.Substring(separatorIndex + 1), NumberStyles.Integer, CultureInfo.InvariantCulture);

                    result = number1 + number2;
                }
                else
                {
                    result = int.Parse(numbersString, NumberStyles.Integer, CultureInfo.InvariantCulture);
                }
            }
            return result;
        }
    }
}