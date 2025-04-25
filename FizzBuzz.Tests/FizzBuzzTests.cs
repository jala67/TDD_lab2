using Xunit;
using FizzBuzz;

namespace FizzBuzz.Tests
{
    public class FizzBuzzTests
    {
        [Theory]
        [InlineData(33, "FizzFizz")]      // durch 3 teilbar + enth�lt 3
        [InlineData(53, "FizzBuzz")]      // enth�lt 3 und 5
        [InlineData(35, "FizzBuzzBuzz")]  // enth�lt 3 + durch 5 teilbar + enth�lt 5
        [InlineData(51, "FizzBuzz")]      // durch 3 + enth�lt 5
        public void GetValue_ReturnsExtendedFizzBuzz(int input, string expected)
        {
            var result = FizzBuzz.GetValue(input);
            Assert.Equal(expected, result);
        }
    }
}