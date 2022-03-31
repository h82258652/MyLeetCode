using FluentAssertions;
using Xunit;

namespace LeetCode2176
{
    public class TestCases
    {
        [Fact]
        public void Test1()
        {
            var solution = new Solution();
            var nums = new[] { 3, 1, 2, 2, 2, 1, 3 };
            var k = 2;
            var result = solution.CountPairs(nums, k);
            result.Should().Be(4);
        }

        [Fact]
        public void Test2()
        {
            var solution = new Solution();
            var nums = new[] { 1, 2, 3, 4 };
            var k = 1;
            var result = solution.CountPairs(nums, k);
            result.Should().Be(0);
        }
    }
}
