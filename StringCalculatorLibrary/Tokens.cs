using System.Collections;
using System.Collections.Generic;

namespace StringCalculatorLibrary
{
    public class Tokens : IEnumerable<string>
    {
        private readonly IEnumerable<string> _strings;

        public Tokens(IEnumerable<string> strings)
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