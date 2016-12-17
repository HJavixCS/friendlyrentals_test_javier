using fr_stringcalculator;
using NUnit.Framework;


namespace fr_stringcalculator.Test
{
  [TestFixture]
  public class StringCalculatorTest
  {
    [Test]
    public void Given_TheStringCalculator_When_EnterNothing_Then_ReturnZero()
    {
      var calculator = new StringCalculator();
      var expected = 0;
      var actual = calculator.Add();
      Assert.AreEqual(expected, actual);
    }
  }
}
