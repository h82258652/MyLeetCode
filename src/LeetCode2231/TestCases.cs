using FluentAssertions;
using Xunit;

namespace LeetCode2231
{
    public class TestCases
    {
        [Fact]
        public void Test1()
        {
            var solution = new Solution();
            var result = solution.LargestInteger(1234);
            result.Should().Be(3412);
        }

        [Fact]
        public void Test2()
        {
            var solution = new Solution();
            var result = solution.LargestInteger(65875);
            result.Should().Be(87655);
        }
    }
}
