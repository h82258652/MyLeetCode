using FluentAssertions;
using Xunit;

namespace LeetCode686
{
    public class TestCases
    {
        [Theory]
        [InlineData("abcd", "cdabcdab", 3)]
        [InlineData("a", "aa", 2)]
        [InlineData("a", "a", 1)]
        [InlineData("abc", "wxyz", -1)]
        [InlineData("abc", "cabcabca", 4)]
        public void Test(string a, string b, int expected)
        {
            var solution = new Solution();
            var result = solution.RepeatedStringMatch(a, b);
            result.Should().Be(expected);
        }
    }
}
