using System;
using System.Collections.Generic;
using System.Linq;

namespace fr_stringcalculator
{
  public static class NumbersHelper
  {
    internal static IEnumerable<int> GetPositiveNumbers(string numbers)
    {
      var allNumbers = GetNumbers(numbers);
      var positiveNumbers = allNumbers as int[] ?? allNumbers.ToArray();
      ValidatePositiveNumbers(positiveNumbers);

      return positiveNumbers;
    }

    private static void ValidatePositiveNumbers(IEnumerable<int> allNumbers)
    {
      var negativeNumbers = allNumbers.Where(n => n < 0).ToList();
      if (negativeNumbers.Count > 0)
      {
        throw new ArgumentException("Negatives not allowed: " + negativeNumbers);
      }
    }

    private static IEnumerable<int> GetNumbers(string numbers)
    {
      return Array.ConvertAll(NumbersParser.ParseCustomDelimiters(numbers).Split(Constants.Delimiters), int.Parse);
    }
  }
}
