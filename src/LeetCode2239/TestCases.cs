using FluentAssertions;
using Xunit;

namespace LeetCode2239
{
    public class TestCases
    {
        [Fact]
        public void Test1()
        {
            var solution = new Solution();
            var result = solution.FindClosestNumber(new int[] { -4, -2, 1, 4, 8 });
            result.Should().Be(1);
        }

        [Fact]
        public void Test2()
        {
            var solution = new Solution();
            var result = solution.FindClosestNumber(new int[] { 2, -1, 1 });
            result.Should().Be(1);
        }
    }
}
