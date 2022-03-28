using FluentAssertions;
using Xunit;

namespace LeetCode1704
{
    public class TestCases
    {
        [Fact]
        public void Test1()
        {
            var solution = new Solution();
            var result = solution.HalvesAreAlike("book");
            result.Should().BeTrue();
        }

        [Fact]
        public void Test2()
        {
            var solution = new Solution();
            var result = solution.HalvesAreAlike("textbook");
            result.Should().BeFalse();
        }
    }
}
