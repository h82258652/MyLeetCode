using FluentAssertions;
using Xunit;

namespace LeetCode507
{
    public class TestCases
    {
        [Theory]
        [InlineData(28, true)]
        [InlineData(6, true)]
        [InlineData(496, true)]
        [InlineData(8128, true)]
        [InlineData(2, false)]
        public void Test(int num, bool assertResult)
        {
            var solution = new Solution();
            var result = solution.CheckPerfectNumber(num);
            result.Should().Be(assertResult);
        }
    }
}
