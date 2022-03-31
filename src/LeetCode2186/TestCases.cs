using FluentAssertions;
using Xunit;

namespace LeetCode2186
{
    public class TestCases
    {
        [Fact]
        public void Test1()
        {
            var solution = new Solution();
            var result = solution.MinSteps("leetcode", "coats");
            result.Should().Be(7);
        }

        [Fact]
        public void Test2()
        {
            var solution = new Solution();
            var result = solution.MinSteps("night", "thing");
            result.Should().Be(0);
        }
    }
}
