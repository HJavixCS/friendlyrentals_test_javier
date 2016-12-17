using System;
using System.Collections.Generic;
using System.Linq;

namespace fr_stringcalculator
{
  public class StringCalculator
  {
    public int Add(string numbers)
    {
      return numbers.Length == 0 ? default(int) : int.MaxValue;
    }
  }
}
