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
            var parseData = new ParseData(NumbersStringParser.DefaultSeparators, input);

            NumbersStringParser.Parse(input).Should().Be(parseData);
        }

        [TestMethod]
        public void ParseInputWithNoSpecifiedDelimitersShouldReturnParseDataWithDefaultDelimitersAndSameString()
        {
            const string input = "1\n2,3";
            var parseData = new ParseData(NumbersStringParser.DefaultSeparators, input);

            NumbersStringParser.Parse(input).Should().Be(parseData);
        }

        [TestMethod]
        public void ParseWithSpecifiedDelimiterShouldReturnParseDataWithTheNewDelimitersAndStringWithoutDelimiterHeader()
        {
            var parseData = new ParseData(NumbersStringParser.DefaultSeparators.Concat(new [] {';'}), "1;2");

            NumbersStringParser.Parse("//;\n1;2").Should().Be(parseData);
        }
    }
}