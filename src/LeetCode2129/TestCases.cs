using FluentAssertions;
using Xunit;

namespace LeetCode2129
{
    public class TestCases
    {
        [Theory]
        [InlineData("capiTalIze tHe title", "Capitalize The Title")]
        [InlineData("First leTTeR of EACH Word", "First Letter of Each Word")]
        [InlineData("i lOve leetcode", "i Love Leetcode")]
        public void Test(string title, string expected)
        {
            var solution = new Solution();
            var result = solution.CapitalizeTitle(title);
            result.Should().Be(expected);
        }
    }
}
