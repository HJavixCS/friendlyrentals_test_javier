using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace fr_stringcalculator
{
  public class StringCalculator
  {
    public int Add(string numbers)
    {
      return numbers.Length == 0 
        ? default(int) 
        : NumbersHelper.GetPositiveNumbers(numbers).Sum();
    }
  }
}
