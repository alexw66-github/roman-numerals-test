using System.Collections.Concurrent;
using System.Text;

namespace RomanNumerals
{
  public static class RomanNumeralConverter
  {
    private static readonly Dictionary<int, string> NumeralLookup = new Dictionary<int, string>();

    static RomanNumeralConverter()
    {
      SeedLookupReference();
    }

    public static IDictionary<string, int> Count(IEnumerable<int> values)
    {
      return values
        .GroupBy(x => x)
        .OrderBy(x => x.Key)
        .ToDictionary(x => Convert(x.Key), x => x.Count());
    }

    public static IEnumerable<string> ConvertTop(IEnumerable<int> values, int count = 5)
    {
      return Convert(values.Take(count));
    }

    public static IEnumerable<string> Convert(IEnumerable<int> values)
    {
      var converted = new ConcurrentBag<(long index, string value)>();

      Parallel.ForEach(values, (value, state, index) =>
      {
        converted.Add((index, Convert(value)));
      });

      return converted
        .OrderBy(x => x.index)
        .Select(x => x.value)
        .ToArray();
    }

    public static string Convert(int value)
    {
      if (value < 0 || value > 50)
      {
        throw new IndexOutOfRangeException($"{nameof(value)} must be between 1 and 50");
      }

      return NumeralLookup[value];
    }

    private static void SeedLookupReference()
    {
      for (int value = 1; value <= 50; value++)
      {
        NumeralLookup[value] = GetRomanNumeral(value);
      }
    }

    private static string GetRomanNumeral(int value)
    {
      var roman = new StringBuilder();

      while (value > 0)
      {
        switch (value)
        {
          case >= 50:
            {
              roman.Append(new string('L', value / 50));
              value = value % 50;
              break;
            }
          case >= 40:
            {
              roman.Append("XL");
              value = value - 40;
              break;
            }
          case >= 10:
            {
              roman.Append(new string('X', value / 10));
              value = value % 10;
              break;
            }
          case 9:
            {
              roman.Append("IX");
              value = value - 9;
              break;
            }
          case 8:
            {
              roman.Append("VIII");
              value = value - 8;
              break;
            }
          case 7:
            {
              roman.Append("VII");
              value = value - 7;
              break;
            }
          case 6:
            {
              roman.Append("VI");
              value = value - 6;
              break;
            }
          case >= 5:
            {
              roman.Append(new string('V', value / 5));
              value = value % 5;
              break;
            }
          case 4:
            {
              roman.Append("IV");
              value = value - 4;
              break;
            }
          case >= 1:
          default:
            {
              roman.Append(new string('I', value / 1));
              value = value % 1;
              break;
            }
        }
      }

      return roman.ToString();
    }
  }
}