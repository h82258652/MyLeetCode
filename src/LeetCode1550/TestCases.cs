using FluentAssertions;
using Xunit;

namespace LeetCode1550
{
    public class TestCases
    {
        [Fact]
        public void Test1()
        {
            var solution = new Solution();
            var arr = new int[] { 2, 6, 4, 1 };
            var result = solution.ThreeConsecutiveOdds(arr);
            result.Should().BeFalse();
        }

        [Fact]
        public void Test2()
        {
            var solution = new Solution();
            var arr = new int[] { 1, 2, 34, 3, 4, 5, 7, 23, 12 };
            var result = solution.ThreeConsecutiveOdds(arr);
            result.Should().BeTrue();
        }
    }
}
