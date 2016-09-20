﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
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

        [TestMethod]
        public void AddOneNumberShouldReturnTheNumber()
        {
            StringCalculator.Add("1").Should().Be(1);
        }

        [TestMethod]
        public void AddTwoNumbersShouldReturnTheirSum()
        {
            StringCalculator.Add("1,2").Should().Be(3);
        }
    }
}
