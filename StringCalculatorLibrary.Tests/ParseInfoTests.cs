using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StringCalculatorLibrary.Tests
{
    [TestClass]
    public class ParseInfoTests
    {
        [TestMethod]
        public void ParsingWithoutInlineDelimitersShouldReturnTheSameStringAndDefaultDelimiters()
        {
            var parseInfo = new ParseInfo("1,2,3");
            parseInfo.NumbersString.Should().Be("1,2,3");
            parseInfo.Separators.Should().BeEquivalentTo(new[] { ',', '\n' });
        }

        [TestMethod]
        public void ParsingWithInlineDelimitersShouldReturnStringWithoutTheInlineDelimitersAndUpdatedDelimiters()
        {
            var parseInfo = new ParseInfo("//;\n1;2");
            parseInfo.NumbersString.Should().Be("1;2");
            parseInfo.Separators.Should().BeEquivalentTo(new[] { ',', '\n', ';' });
        }
    }
}