using FluentAssertions;
using Xunit;

namespace LeetCode383
{
    public class TestCases
    {
        [Theory]
        [InlineData("a","b",false)]
        [InlineData("aa","ab",false)]
        [InlineData("aa","aab",true)]
        public void Test(string ransomNote, string magazine, bool assertResult)
        {
            var solution = new Solution();
            var result = solution.CanConstruct(ransomNote, magazine);
            result.Should().Be(assertResult);
        }
    }
}
