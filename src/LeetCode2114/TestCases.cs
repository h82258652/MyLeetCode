using FluentAssertions;
using Xunit;

namespace LeetCode2114
{
    public class TestCases
    {
        [Fact]
        public void Test1()
        {
            var solution = new Solution();
            var result = solution.MostWordsFound(new[]
            {
                "alice and bob love leetcode",
                "i think so too",
                "this is great thanks very much"
            });
            result.Should().Be(6);
        }

        [Fact]
        public void Test2()
        {
            var solution = new Solution();
            var result = solution.MostWordsFound(new[]
            {
                "please wait",
                "continue to fight",
                "continue to win"
            });
            result.Should().Be(3);
        }
    }
}
