using FluentAssertions;
using Xunit;

namespace LeetCode890
{
    public class TestCases
    {
        [Fact]
        public void Test1()
        {
            var solution = new Solution();
            var words = new string[] { "abc", "deq", "mee", "aqq", "dkd", "ccc" };
            var pattern = "abb";
            var result = solution.FindAndReplacePattern(words, pattern);
            result.Should().Equal("mee", "aqq");
        }
    }
}
