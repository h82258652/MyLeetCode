using FluentAssertions;
using Xunit;

namespace LeetCode1528
{
    public class TestCases
    {
        [Fact]
        public void Test1()
        {
            var solution = new Solution();
            var result = solution.RestoreString("codeleet", new[] { 4, 5, 6, 7, 0, 2, 1, 3 });
            result.Should().Be("leetcode");
        }

        [Fact]
        public void Test2()
        {
            var solution = new Solution();
            var result = solution.RestoreString("abc", new[] { 0, 1, 2 });
            result.Should().Be("abc");
        }
    }
}
