using FluentAssertions;
using Xunit;

namespace LeetCode709
{
    public class TestCases
    {
        [Theory]
        [InlineData("Hello", "hello")]
        [InlineData("here", "here")]
        [InlineData("LOVELY", "lovely")]
        public void Test(string s, string excepted)
        {
            var solution = new Solution();
            var result = solution.ToLowerCase(s);
            result.Should().Be(excepted);
        }
    }
}
