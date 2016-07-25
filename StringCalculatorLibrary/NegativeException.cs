using System;
using System.Collections.Generic;

namespace StringCalculatorLibrary
{
    public class NegativeException : Exception
    {
        public NegativeException(IEnumerable<int> negatives) : base($"Negatives are not allowed: {string.Join(",", negatives)}")
        { }
    }
}