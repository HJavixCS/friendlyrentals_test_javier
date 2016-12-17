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
  }
}
