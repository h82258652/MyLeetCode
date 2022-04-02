using FluentAssertions;
using Xunit;

namespace LeetCode1047
{
    public class TestCases
    {
        [Fact]
        public void Test1()
        {
            var solution = new Solution();
            var result = solution.RemoveDuplicates("abbaca");
            result.Should().Be("ca");
        }
    }
}
