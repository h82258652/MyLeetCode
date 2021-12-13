using FluentAssertions;
using Xunit;

namespace LeetCode1796
{
    public class TestCases
    {
        [Theory]
        [InlineData("dfa12321afd", 2)]
        [InlineData("abc1111", -1)]
        public void Test(string s, int expected)
        {
            var solution = new Solution();
            var result = solution.SecondHighest(s);
            result.Should().Be(expected);
        }
    }
}
