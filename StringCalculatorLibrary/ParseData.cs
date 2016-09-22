using System.Collections.Generic;
using JetBrains.Annotations;

namespace StringCalculatorLibrary
{
    public class ParseData
    {
        public Separators Separators { get; }
        public string NumbersString { get; }

        public ParseData([NotNull] Separators separators, [NotNull] string numbersString)
        {
            Separators = separators;
            NumbersString = numbersString;
        }

        public override bool Equals(object obj)
        {
            var other = obj as ParseData;
            return other != null && 
                Separators.Equals(other.Separators) && 
                NumbersString.Equals(other.NumbersString);
        }

        public override int GetHashCode()
        {
            return Separators.GetHashCode() * 17 + NumbersString.GetHashCode();
        }
    }
}