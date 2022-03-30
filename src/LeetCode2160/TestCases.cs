using FluentAssertions;
using Xunit;

namespace LeetCode2160
{
    public class TestCases
    {
        [Theory]
        [InlineData(2932, 52)]
        [InlineData(4009, 13)]
        public void Test(int num, int excepted)
        {
            var solution = new Solution();
            var result = solution.MinimumSum(num);
            result.Should().Be(excepted);
        }
    }
}
