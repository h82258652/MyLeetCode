using FluentAssertions;
using Xunit;

namespace LeetCode953
{
    public class TestCases
    {
        [Fact]
        public void Test1()
        {
            var solution = new Solution();
            var words = new[] { "hello", "leetcode" };
            var order = "hlabcdefgijkmnopqrstuvwxyz";
            var result = solution.IsAlienSorted(words, order);
            result.Should().BeTrue();
        }

        [Fact]
        public void Test2()
        {
            var solution = new Solution();
            var words = new[] { "word", "world", "row" };
            var order = "worldabcefghijkmnpqstuvxyz";
            var result = solution.IsAlienSorted(words, order);
            result.Should().BeFalse();
        }

        [Fact]
        public void Test3()
        {
            var solution = new Solution();
            var words = new[] { "apple", "app" };
            var order = "abcdefghijklmnopqrstuvwxyz";
            var result = solution.IsAlienSorted(words, order);
            result.Should().BeFalse();
        }
    }
}
