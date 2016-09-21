using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using JetBrains.Annotations;

namespace StringCalculatorLibrary
{
    public class ParseData
    {
        private readonly ImmutableHashSet<char> _separatorsHashSet;

        public char[] Separators { get; }
        public string NumbersString { get; }

        public ParseData([NotNull] IEnumerable<char> separators, [NotNull] string numbersString)
        {
            _separatorsHashSet = separators.ToImmutableHashSet();

            Separators = _separatorsHashSet.ToArray();
            NumbersString = numbersString;
        }

        public override bool Equals(object obj)
        {
            var other = obj as ParseData;
            return other != null && 
                _separatorsHashSet.SetEquals(other._separatorsHashSet) && 
                NumbersString == other.NumbersString;
        }

        public override int GetHashCode()
        {
            return _separatorsHashSet.GetHashCode() * 17 + NumbersString.GetHashCode();
        }
    }
}