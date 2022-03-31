using FluentAssertions;
using Xunit;

namespace LeetCode2124
{
    public class TestCases
    {
        [Fact]
        public void Test1()
        {
            var solution = new Solution();
            var result = solution.CheckString("aaabbb");
            result.Should().BeTrue();
        }

        [Fact]
        public void Test2()
        {
            var solution = new Solution();
            var result = solution.CheckString("abab");
            result.Should().BeFalse();
        }

        [Fact]
        public void Test3()
        {
            var solution = new Solution();
            var result = solution.CheckString("bbb");
            result.Should().BeTrue();
        }
    }
}
