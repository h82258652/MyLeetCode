using FluentAssertions;
using Xunit;

namespace LeetCode1832
{
    public class TestCases
    {
        [Theory]
        [InlineData("thequickbrownfoxjumpsoverthelazydog", true)]
        [InlineData("leetcode", false)]
        public void Test(string sentence, bool assertResult)
        {
            var solution = new Solution();
            var result = solution.CheckIfPangram(sentence);
            result.Should().Be(assertResult);
        }
    }
}
