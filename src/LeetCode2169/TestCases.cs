using FluentAssertions;
using Xunit;

namespace LeetCode2169
{
    public class TestCases
    {
        [Fact]
        public void Test1()
        {
            var solution = new Solution();
            var result = solution.CountOperations(2, 3);
            result.Should().Be(3);
        }

        [Fact]
        public void Test2()
        {
            var solution = new Solution();
            var result = solution.CountOperations(10, 10);
            result.Should().Be(1);
        }
    }
}
