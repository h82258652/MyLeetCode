using FluentAssertions;
using Xunit;

namespace LeetCode1903
{
    public class TestCases
    {
        [Theory]
        [InlineData("52", "5")]
        [InlineData("4206", "")]
        [InlineData("35427", "35427")]
        public void Test(string num, string expected)
        {
            var solution = new Solution();
            var result = solution.LargestOddNumber(num);
            result.Should().Be(expected);
        }
    }
}
