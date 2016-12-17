using System;
using System.Collections.Generic;
using System.Linq;

namespace fr_stringcalculator
{
  public class StringCalculator
  {
    private static readonly char[] Delimiters = { ',', '\n' };

    public int Add(string numbers)
    {
      return numbers.Length == 0 
        ? default(int) 
        : GetNumbers(numbers).Sum();
    }

    private static IEnumerable<int> GetNumbers(string numbers)
    {
      return Array.ConvertAll(numbers.Split(Delimiters), int.Parse);
    }
  }
}
