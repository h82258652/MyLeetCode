using FluentAssertions;
using Xunit;

namespace LeetCode2000
{
    public class TestCases
    {
        [Theory]
        [InlineData("abcdefd", 'd', "dcbaefd")]
        [InlineData("xyxzxe", 'z', "zxyxxe")]
        [InlineData("abcd", 'z', "abcd")]
        public void Test(string word, char ch, string expected)
        {
            var solution = new Solution();
            var result = solution.ReversePrefix(word, ch);
            result.Should().Be(expected);
        }
    }
}
