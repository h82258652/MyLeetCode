using FluentAssertions;
using Xunit;

namespace LeetCode1051
{
    public class TestCases
    {
        [Fact]
        public void Test1()
        {
            var solution = new Solution();
            var heights = new int[] { 1, 1, 4, 2, 1, 3 };
            var result = solution.HeightChecker(heights);
            result.Should().Be(3);
        }

        [Fact]
        public void Test2()
        {
            var solution = new Solution();
            var heights = new int[] { 5, 1, 2, 3, 4 };
            var result = solution.HeightChecker(heights);
            result.Should().Be(5);
        }

        [Fact]
        public void Test3()
        {
            var solution = new Solution();
            var heights = new int[] { 1, 2, 3, 4, 5 };
            var result = solution.HeightChecker(heights);
            result.Should().Be(0);
        }
    }
}
