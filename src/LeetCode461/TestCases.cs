using FluentAssertions;
using Xunit;

namespace LeetCode461
{
    public class TestCases
    {
        [Theory]
        [InlineData(1, 4, 2)]
        [InlineData(3, 1, 1)]
        public void Test(int x, int y, int assertResult)
        {
            var solution = new Solution();
            var result = solution.HammingDistance(x, y);
            result.Should().Be(assertResult);
        }
    }
}
