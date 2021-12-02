using FluentAssertions;
using Xunit;

namespace LeetCode504
{
    public class TestCases
    {
        [Theory]
        [InlineData(100, "202")]
        [InlineData(-7, "-10")]
        public void Test(int num, string assertResult)
        {
            var solution = new Solution();
            var result = solution.ConvertToBase7(num);
            result.Should().Be(assertResult);
        }
    }
}
