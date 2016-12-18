using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace fr_stringcalculator
{
  public static class NumbersParser
  {
    internal static string ParseCustomDelimiters(string numbers)
    {
      var parsedNumbers = new StringBuilder();
      if (!Regex.IsMatch(numbers, Constants.CustomDelimiterPattern))
      {
        parsedNumbers.Append(numbers);
      }
      else
      {
        var numberofMatches = Regex.Matches(numbers, Constants.LineSeparatorPattern).Count;
        var firstIteration = true;
        var numberLines = Regex.Split(numbers, Constants.LineSeparatorPattern).Skip(1).ToArray();

        foreach (var line in numberLines)
        {
          var data = line.Split(Constants.NewLine);
          var customDelimiter = data[0];
          var delimitedNumbers = data[1];

          if (customDelimiter.Length != 1)
          {
            break;
          }

          if (numberofMatches > 1 && !firstIteration)
          {
            parsedNumbers.Append(Constants.NewLine.ToString());

          }
          parsedNumbers.Append(delimitedNumbers.Replace(customDelimiter, Constants.NewLine.ToString()));
          firstIteration = false;
        }
      }

      return parsedNumbers.ToString();
    }
  }
}
