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
      var expected = 0;
      var actual = calculator.Add(numbers);
      Assert.AreEqual(expected, actual);
    }
  }
}
