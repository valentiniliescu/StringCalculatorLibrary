using System.Collections;
using System.Collections.Generic;
using System.Collections.Immutable;
using JetBrains.Annotations;

namespace StringCalculatorLibrary
{
    public class Separators : IEnumerable<char>
    {
        private readonly ImmutableHashSet<char> _charHashSet;

        public Separators([NotNull] IEnumerable<char> chars) : this(chars.ToImmutableHashSet())
        {
        }

        private Separators(ImmutableHashSet<char> charHashSet)
        {
            _charHashSet = charHashSet;
        }

        public IEnumerator<char> GetEnumerator()
        {
            return _charHashSet.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _charHashSet.GetEnumerator();
        }

        public Separators Add(char character)
        {
            return new Separators(_charHashSet.Add(character));
        }

        public override bool Equals(object obj)
        {
            var other = obj as Separators;
            return other != null && _charHashSet.SetEquals(other._charHashSet);
        }

        public override int GetHashCode()
        {
            return _charHashSet.GetHashCode();
        }
    }
}