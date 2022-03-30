using FluentAssertions;
using Xunit;

namespace LeetCode1837
{
    public class TestCases
    {
        [Fact]
        public void Test1()
        {
            var solution = new Solution();
            var result = solution.SumBase(34, 6);
            result.Should().Be(9);
        }

        [Fact]
        public void Test2()
        {
            var solution = new Solution();
            var result = solution.SumBase(10, 10);
            result.Should().Be(1);
        }
    }
}
