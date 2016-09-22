using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;

namespace StringCalculatorLibrary
{
    public class Tokens : IEnumerable<string>
    {
        private readonly IEnumerable<string> _strings;

        public Tokens([NotNull] IEnumerable<string> strings)
        {
            _strings = strings;
        }

        public IEnumerator<string> GetEnumerator()
        {
            return _strings.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _strings.GetEnumerator();
        }
    }
}