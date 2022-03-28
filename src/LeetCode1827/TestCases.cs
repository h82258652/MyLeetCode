using FluentAssertions;
using Xunit;

namespace LeetCode1827
{
    public class TestCases
    {
        [Fact]
        public void Test1()
        {
            var solution = new Solution();
            var nums = new[] { 1, 1, 1 };
            var result = solution.MinOperations(nums);
            result.Should().Be(3);
        }

        [Fact]
        public void Test2()
        {
            var solution = new Solution();
            var nums = new[] { 1, 5, 2, 4, 1 };
            var result = solution.MinOperations(nums);
            result.Should().Be(14);
        }

        [Fact]
        public void Test3()
        {
            var solution = new Solution();
            var nums = new[] { 8 };
            var result = solution.MinOperations(nums);
            result.Should().Be(0);
        }
    }
}
