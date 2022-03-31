using FluentAssertions;
using Xunit;

namespace LeetCode2139
{
    public class TestCases
    {
        [Theory]
        [InlineData(5, 0, 4)]
        [InlineData(19, 2, 7)]
        [InlineData(10, 4, 4)]
        [InlineData(999999997, 0, 999999996)]
        public void Test(int target, int maxDoubles, int excepted)
        {
            var solution = new Solution();
            var result = solution.MinMoves(target, maxDoubles);
            result.Should().Be(excepted);
        }
    }
}
