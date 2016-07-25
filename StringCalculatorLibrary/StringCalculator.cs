using System;

namespace StringCalculatorLibrary
{
    public static class StringCalculator
    {
        public static int Add(string numbers)
        {
            if (numbers == string.Empty)
            {
                return 0;
            }
            else
            {
                return int.Parse(numbers);
            }
            
        }
    }
}