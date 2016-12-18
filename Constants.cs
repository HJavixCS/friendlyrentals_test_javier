namespace fr_stringcalculator
{
  public static class Constants
  {
    public const char NewLine = '\n';
    public const string LineSeparatorPattern = @"\/\/";
    public const string CustomDelimiterPattern = @"//.\n*";
    public static readonly char[] Delimiters = { ',', NewLine };
  }
}
