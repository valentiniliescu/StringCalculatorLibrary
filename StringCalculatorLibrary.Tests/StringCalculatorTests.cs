using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StringCalculatorLibrary.Tests
{
    [TestClass]
    public class StringCalculatorTests
    {
        [TestMethod]
        public void AddingEmptyStringShouldReturnZero()
        {
            StringCalculator.Add(string.Empty);
        }
    }
}
