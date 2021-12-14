using FluentAssertions;
using Xunit;

namespace LeetCode567
{
    public class TestCases
    {
        [Theory]
        [InlineData("ab", "eidbaooo", true)]
        [InlineData("ab", "eidboaoo", false)]
        public void Test(string s1, string s2, bool expected)
        {
            var solution = new Solution();
            var result = solution.CheckInclusion(s1, s2);
            result.Should().Be(expected);
        }
    }
}
