using System;
using System.Linq;

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
            else if(!numbers.Contains(","))
            {
                return int.Parse(numbers);
            }
            else
            {
                var numberArray = numbers.Split(',');
                return numberArray.Select(int.Parse).Sum();
            }
            
        }
    }
}