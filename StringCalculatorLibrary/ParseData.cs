namespace StringCalculatorLibrary
{
    public class ParseData
    {
        public char[] Separators { get; }
        public string NumbersString { get; }

        public ParseData(char[] separators, string numbersString)
        {
            Separators = separators;
            NumbersString = numbersString;
        }
    }
}