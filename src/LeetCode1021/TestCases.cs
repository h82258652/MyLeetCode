using FluentAssertions;
using Xunit;

namespace LeetCode1021
{
    public class TestCases
    {
        [Fact]
        public void Test1()
        {
            var solution = new Solution();
            var result = solution.RemoveOuterParentheses("(()())(())");
            result.Should().Be("()()()");
        }

        [Fact]
        public void Test2()
        {
            var solution = new Solution();
            var result = solution.RemoveOuterParentheses("(()())(())(()(()))");
            result.Should().Be("()()()()(())");
        }

        [Fact]
        public void Test3()
        {
            var solution = new Solution();
            var result = solution.RemoveOuterParentheses("()()");
            result.Should().Be("");
        }
    }
}
