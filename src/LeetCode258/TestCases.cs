using FluentAssertions;
using Xunit;

namespace LeetCode258
{
    public class TestCases
    {
        [Theory]
        [InlineData(38, 2)]
        [InlineData(0, 0)]
        public void Test(int num, int expected)
        {
            var solution = new Solution();
            var result = solution.AddDigits(num);
            result.Should().Be(expected);
        }
    }
}
