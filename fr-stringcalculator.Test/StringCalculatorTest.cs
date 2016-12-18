using System;
using NUnit.Framework;

namespace fr_stringcalculator.Test
{
  [TestFixture]
  public class StringCalculatorTest
  {
    [Test]
    [TestCase("")]
    public void Given_TheStringCalculator_When_EnterEmptyString_Then_ReturnZero(string numbers)
    {
      var calculator = new StringCalculator();
      const int expected = 0;
      var actual = calculator.Add(numbers);
      Assert.AreEqual(expected, actual);
    }

    [Test]
    [TestCase("0", 0)]
    [TestCase("1", 1)]
    [TestCase("99", 99)]
    public void Given_TheStringCalculator_When_EnterOneNumber_Then_ReturnEnteredNumber(string enteredNumber, int expectedNumber)
    {
      var calculator = new StringCalculator();
      var actual = calculator.Add(enteredNumber);
      Assert.AreEqual(expectedNumber, actual);
    }

    [Test]
    [TestCase("0,0", 0)]
    [TestCase("1,1", 2)]
    [TestCase("1,2", 3)]
    [TestCase("100,1", 101)]
    public void Given_TheStringCalculator_When_EnterTwoNumbers_Then_ReturnTheirSum(string enteredNumber, int expectedNumber)
    {
      var calculator = new StringCalculator();
      var actual = calculator.Add(enteredNumber);
      Assert.AreEqual(expectedNumber, actual);
    }

    [Test]
    [TestCase("1", 1)]
    [TestCase("1,1", 2)]
    [TestCase("1,1,2", 4)]
    [TestCase("1,1,2,3", 7)]
    public void Given_TheStringCalculator_When_EnterAnUnknowAmountOfNumbers_Then_ReturnTheirSum(string enteredNumbers, int expectedSum)
    {
      var calculator = new StringCalculator();
      var actualSum = calculator.Add(enteredNumbers);
      Assert.AreEqual(expectedSum, actualSum);
    }

    [Test]
    [TestCase("1", 1)]
    [TestCase("1,1", 2)]
    [TestCase("1,1\n2", 4)]
    [TestCase("1\n1,2\n3", 7)]
    public void Given_TheStringCalculator_When_EnterAnUnknowAmountOfNumbersAndUsingNewLineOrCommaDelimiter_Then_ReturnTheirSum(string enteredNumbers, int expectedSum)
    {
      var calculator = new StringCalculator();
      var actualSum = calculator.Add(enteredNumbers);
      Assert.AreEqual(expectedSum, actualSum);
    }

    [Test]
    [TestCase("//.\n1", 1)]
    [TestCase("//:\n1:1", 2)]
    [TestCase("//|\n1|1|2", 4)]
    [TestCase("//_\n1_1_2_3", 7)]
    [TestCase("//.\n1//:\n1:1", 3)]
    [TestCase("//|\n1|1|2//_\n1_1_2_3", 11)]
    [TestCase("//.\n1//:\n1:1//|\n1|1|2//_\n1_1_2_3", 14)]
    public void Given_TheStringCalculator_When_EnterAnUnknowAmountOfNumbersAndUsingCustomDelimiter_Then_ReturnTheirSum(string enteredNumbers, int expectedSum)
    {
      var calculator = new StringCalculator();
      var actualSum = calculator.Add(enteredNumbers);
      Assert.AreEqual(expectedSum, actualSum);
    }

    [Test]
    [TestCase("-1", 1)]
    [TestCase("1,-1", 2)]
    [TestCase("-1,1,-2", 4)]
    [TestCase("1,-1,2,-3", 7)]
    public void Given_TheStringCalculator_When_EnterAnUnknowAmountOfNegativeNumbers_Then_ThrowsAnException(string enteredNumbers, int expectedSum)
    {
      var calculator = new StringCalculator();
      Assert.That(() => calculator.Add(enteredNumbers), Throws.TypeOf<ArgumentException>());
    }
  }
}
