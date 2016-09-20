using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;

namespace StringCalculatorLibrary.Tests
{
    [TestClass]
    public class StringCalculatorTests
    {
        [TestMethod]
        public void AddEmptyStringShouldReturnZero()
        {
            StringCalculator.Add("").Should().Be(0);
        }
    }
}
