namespace RomanNumerals.Tests
{
  public class RomanNumeralConverterTests
  {
    [Fact]
    public void Count_ReturnsTotalInstances()
    {
      // arrange
      var input = new[] { 1, 1, 1, 5, 10 };
      var expected = new Dictionary<string, int>()
      {
        { "I", 3 },
        { "V", 1 },
        { "X", 1 },
      };

      // act
      var actual = RomanNumeralConverter.Count(input);

      // assert
      Assert.Equal(expected.Count, actual.Count);
      for (int index = 0; index < actual.Count; index++)
      {
        Assert.Equal(expected.ElementAt(index), actual.ElementAt(index));
      }
    }
    
    [Fact]
    public void ConvertTop_ReturnsSpecifiedCount()
    {
      // arrange
      var input = new[] { 1, 1, 1, 5, 10 };
      var expected = 3;

      // act
      var actual = RomanNumeralConverter.ConvertTop(input, 3);

      // assert
      Assert.Equal(expected, actual.Count());
    }

    [Fact]
    public void ConvertTop_ReturnsTopFiveItems()
    {
      // arrange
      var input = new[] { 1, 1, 1, 5, 10 };
      var expected = 5;

      // act
      var actual = RomanNumeralConverter.ConvertTop(input);

      // assert
      Assert.Equal(expected, actual.Count());
    }

    [Fact]
    public void Convert_WithMultipleNumbers_ReturnsRomanNumeralForEach()
    {
      // arrange
      var input = new[] { 1, 1, 1, 5, 10 };
      var expected = new[] { "I", "I", "I", "V", "X" };

      // act
      var actual = RomanNumeralConverter.Convert(input);

      // assert
      Assert.Equal(expected.Count(), actual.Count());
      for (int index = 0; index < actual.Count(); index++)
      {
        Assert.Equal(expected.ElementAt(index), actual.ElementAt(index));
      }
    }

    [Fact]
    public void Convert_WithSingleNumber_ReturnsRomanNumeralValue()
    {
      // arrange
      var expected = new Dictionary<int, string>()
      {
        { 1, "I" },
        { 2, "II" },
        { 3, "III" },
        { 4, "IV" },
        { 5, "V" },
        { 6, "VI" },
        { 7, "VII" },
        { 8, "VIII" },
        { 9, "IX" },
        { 10, "X" },
        { 11, "XI" },
        { 12, "XII" },
        { 13, "XIII" },
        { 14, "XIV" },
        { 15, "XV" },
        { 16, "XVI" },
        { 17, "XVII" },
        { 18, "XVIII" },
        { 19, "XIX" },
        { 20, "XX" },
        { 21, "XXI" },
        { 22, "XXII" },
        { 23, "XXIII" },
        { 24, "XXIV" },
        { 25, "XXV" },
        { 26, "XXVI" },
        { 27, "XXVII" },
        { 28, "XXVIII" },
        { 29, "XXIX" },
        { 30, "XXX" },
        { 31, "XXXI" },
        { 32, "XXXII" },
        { 33, "XXXIII" },
        { 34, "XXXIV" },
        { 35, "XXXV" },
        { 36, "XXXVI" },
        { 37, "XXXVII" },
        { 38, "XXXVIII" },
        { 39, "XXXIX" },
        { 40, "XL" },
        { 41, "XLI" },
        { 42, "XLII" },
        { 43, "XLIII" },
        { 44, "XLIV" },
        { 45, "XLV" },
        { 46, "XLVI" },
        { 47, "XLVII" },
        { 48, "XLVIII" },
        { 49, "XLIX" },
        { 50, "L" },
      };

      // act and assert
      for (int input = 1; input <= expected.Count; input++)
      {
        var actual = RomanNumeralConverter.Convert(input);
        Assert.Equal(expected[input], actual);
      }
    }
  }
}