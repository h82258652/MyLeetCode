using FluentAssertions;
using Xunit;

namespace LeetCode1154
{
    public class TestCases
    {
        [Theory]
        [InlineData("2019-01-09", 9)]
        [InlineData("2019-02-10", 41)]
        [InlineData("2003-03-01", 60)]
        [InlineData("2004-03-01", 61)]
        public void Test(string date, int assertResult)
        {
            var solution = new Solution();
            var result = solution.DayOfYear(date);
            result.Should().Be(assertResult);
        }
    }
}
