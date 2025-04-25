using Xunit;
using FizzBuzz;

namespace FizzBuzz.Tests
{
    public class FizzBuzzTests
    {
        [Theory]
        [InlineData(1, "1")]
        [InlineData(3, "Fizz")]
        [InlineData(5, "Buzz")]
        [InlineData(15, "FizzBuzz")]
        public void GetValue_ReturnsExpectedResult(int input, string expected)
        {
            var result = FizzBuzz.GetValue(input);
            Assert.Equal(expected, result);
        }
    }
}