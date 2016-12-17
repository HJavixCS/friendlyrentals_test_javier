using System;
using System.Linq;

namespace fr_stringcalculator
{
  public class StringCalculator
  {
    public static char Delimiter { get; } = ',';

    public int Add(string numbers)
    {
      return numbers.Length == 0 
        ? default(int) 
        : Array.ConvertAll(numbers.Split(Delimiter), int.Parse).Sum();
    }
  }
}
