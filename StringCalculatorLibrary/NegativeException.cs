using System;

namespace StringCalculatorLibrary
{
    public class NegativeException : Exception
    {
        public NegativeException(int[] negatives) : base($"Negatives are not allowed: {negatives}")
        { }
    }
}