﻿using System;
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

        [TestMethod]
        public void AddingNumbersWithDelimiterSpecifiedInlineShouldReturnTheSumOfThem()
        {
            StringCalculator.Add("//;\n1;2").Should().Be(3);
        }

        [TestMethod]
        public void AddingNegativeNumbersShouldThrowAnException()
        {
            Action a = () => StringCalculator.Add("-1,-2");
            a.ShouldThrowExactly<NegativeException>().WithMessage("Negatives are not allowed: -1,-2");
        }
    }
}
