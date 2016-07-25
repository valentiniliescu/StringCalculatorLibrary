using System;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StringCalculatorLibrary.Tests
{
    [TestClass]
    public class StringTokenizerTests
    {
        [TestMethod]
        public void TokenizingEmptyStringShouldReturnEmptyArray()
        {
            var parseInfo = new ParseInfo(string.Empty, new char[] { });
            StringTokenizer.Tokenize(parseInfo).Should().BeEquivalentTo();
        }

        [TestMethod]
        public void TokenizingSingleNumberShouldReturnTheNumberInTheArray()
        {
            var parseInfo = new ParseInfo("1", new char[] { });
            StringTokenizer.Tokenize(parseInfo).Should().BeEquivalentTo("1");
        }

        [TestMethod]
        public void TokenizingMultipleNumbersShouldReturnTheNumbersInTheArray()
        {
            var parseInfo = new ParseInfo("1\n2,3", new[] { ',', '\n' });
            StringTokenizer.Tokenize(parseInfo).Should().BeEquivalentTo("1", "2", "3");
        }
    }
}