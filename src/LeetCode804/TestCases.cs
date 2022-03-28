using FluentAssertions;
using Xunit;

namespace LeetCode804
{
    public class TestCases
    {
        [Fact]
        public void Test1()
        {
            var solution = new Solution();
            var words = new[] { "gin", "zen", "gig", "msg" };
            var result = solution.UniqueMorseRepresentations(words);
            result.Should().Be(2);
        }

        [Fact]
        public void Test2()
        {
            var solution = new Solution();
            var words = new[] { "a" };
            var result = solution.UniqueMorseRepresentations(words);
            result.Should().Be(1);
        }
    }
}
