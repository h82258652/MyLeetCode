using FluentAssertions;
using Xunit;

namespace LeetCode1046
{
    public class TestCases
    {
        [Fact]
        public void Test1()
        {
            var solution = new Solution();
            var stones = new[] { 2, 7, 4, 1, 8, 1 };
            var result = solution.LastStoneWeight(stones);
            result.Should().Be(1);
        }
    }
}
