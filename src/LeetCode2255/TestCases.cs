using FluentAssertions;
using Xunit;

namespace LeetCode2255
{
    public class TestCases
    {
        [Fact]
        public void Test1()
        {
            var solution = new Solution();
            var words = new string[] { "a", "b", "c", "ab", "bc", "abc" };
            var s = "abc";
            var result = solution.CountPrefixes(words, s);
            result.Should().Be(3);
        }

        [Fact]
        public void Test2()
        {
            var solution = new Solution();
            var words = new string[] { "a", "a" };
            var s = "aa";
            var result = solution.CountPrefixes(words, s);
            result.Should().Be(2);
        }
    }
}
