using System.Linq;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StringCalculatorLibrary.Tests
{
    [TestClass]
    public class NumbersStringParserTests
    {
        [TestMethod]
        public void ParseEmptyStringShouldReturnParseDataWithDefaultDelimitersAndEmptyString()
        {
            const string input = "";
            NumbersStringParser.Parse(input).Should().Be(new ParseData(NumbersStringParser.DefaultSeparators, input));
        }

        [TestMethod]
        public void ParseInputWithNoSpecifiedDelimitersShouldReturnParseDataWithDefaultDelimitersAndSameString()
        {
            const string input = "1\n2,3";
            NumbersStringParser.Parse(input).Should().Be(new ParseData(NumbersStringParser.DefaultSeparators, input));
        }

        [TestMethod]
        public void ParseWithSpecifiedDelimiterShouldReturnParseDataWithTheNewDelimitersAndStringWithoutDelimiterHeader()
        {
            NumbersStringParser.Parse("//;\n1;2").Should().Be(new ParseData(NumbersStringParser.DefaultSeparators.Concat(new [] {';'}), "1;2"));
        }
    }
}