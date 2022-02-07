using FluentAssertions;
using Xunit;

namespace LeetCode1405
{
    public class TestCases
    {
        [Fact]
        public void Test1()
        {
            var solution = new Solution();
            var result = solution.LongestDiverseString(1, 1, 7);
            result.Should().Match(temp => temp == "ccaccbcc" || temp == "ccbccacc");
        }

        [Fact]
        public void Test2()
        {
            var solution = new Solution();
            var result = solution.LongestDiverseString(2, 2, 1);
            result.Should().Match(temp => temp == "aabbc");
        }

        [Fact]
        public void Test3()
        {
            var solution = new Solution();
            var result = solution.LongestDiverseString(7, 1, 0);
            result.Should().Match(temp => temp == "aabaa");
        }

        [Fact]
        public void Test4()
        {
            var solution = new Solution();
            var result = solution.LongestDiverseString(0, 8, 11);
            result.Should().Match(temp => temp == "ccbccbbccbbccbbccbc");
        }
    }
}
