using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;

namespace StringCalculatorLibrary
{
    public class NumericTokens : IEnumerable<int>
    {
        private readonly IEnumerable<int> _numbers;

        public NumericTokens([NotNull] IEnumerable<int> numbers)
        {
            _numbers = numbers;
        }

        public IEnumerator<int> GetEnumerator()
        {
            return _numbers.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _numbers.GetEnumerator();
        }
    }
}