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
    private const char NewLine = '\n';
    private const string LineSeparatorPattern = @"\/\/";
    private const string CustomDelimiterPattern = @"//.\n*";
    private static readonly char[] Delimiters = { ',', NewLine };

    public int Add(string numbers)
    {
      return numbers.Length == 0 
        ? default(int) 
        : GetNumbers(numbers).Sum();
    }

    private static IEnumerable<int> GetNumbers(string numbers)
    {
      return Array.ConvertAll(ParseCustomDelimiters(numbers).Split(Delimiters), int.Parse);
    }

    private static string ParseCustomDelimiters(string numbers)
    {
      var parsedNumbers = new StringBuilder();
      if (!Regex.IsMatch(numbers, CustomDelimiterPattern))
      {
        parsedNumbers.Append(numbers);
      }
      else
      {
        var numberofMatches = Regex.Matches(numbers, LineSeparatorPattern).Count;
        var firstIteration = true;
        var numberLines = Regex.Split(numbers, LineSeparatorPattern).Skip(1).ToArray();
        
        foreach (var line in numberLines)
        {
          var data = line.Split(NewLine);
          var customDelimiter = data[0];
          var delimitedNumbers = data[1];

          if (customDelimiter.Length != 1)
          {
            break;
          }

          if (numberofMatches > 1 && !firstIteration)
          {
            parsedNumbers.Append(NewLine.ToString());
            
          }
          parsedNumbers.Append(delimitedNumbers.Replace(customDelimiter, NewLine.ToString()));
          firstIteration = false;
        }
      }

      return parsedNumbers.ToString();
    }
  }
}
