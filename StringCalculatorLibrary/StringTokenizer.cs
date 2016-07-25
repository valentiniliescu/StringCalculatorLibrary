using System;

namespace StringCalculatorLibrary
{
    public static class StringTokenizer
    {
        public static string[] Tokenize(ParseInfo parseInfo)
        {
            return parseInfo.NumbersString.Split(parseInfo.Separators, StringSplitOptions.RemoveEmptyEntries);
        }
    }
}