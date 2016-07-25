using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StringCalculatorLibrary.Tests
{
    [TestClass]
    public class StringCalculatorTests
    {
        [TestMethod]
        public void AddingEmptyStringShouldReturnZero()
        {
            StringCalculator.Add(string.Empty).Should().Be(0);
        }

        [TestMethod]
        public void AddingSingleNumberShouldReturnTheNumber()
        {
            StringCalculator.Add("1").Should().Be(1);
        }

        [TestMethod]
        public void AddingThreeNumbersShouldReturnTheSumOfThem()
        {
            StringCalculator.Add("1,2,3").Should().Be(6);
        }

        [TestMethod]
        public void AddingThreeNumbersWithNewLineDelimiterShouldReturnTheSumOfThem()
        {
            StringCalculator.Add("1\n2,3").Should().Be(6);
        }
    }
}
