using FluentAssertions;
using Xunit;

namespace LeetCode2119
{
    public class TestCases
    {
        [Fact]
        public void Test1()
        {
            var solution = new Solution();
            var result = solution.IsSameAfterReversals(526);
            result.Should().BeTrue();
        }

        [Fact]
        public void Test2()
        {
            var solution = new Solution();
            var result = solution.IsSameAfterReversals(1800);
            result.Should().BeFalse();
        }

        [Fact]
        public void Test3()
        {
            var solution = new Solution();
            var result = solution.IsSameAfterReversals(0);
            result.Should().BeTrue();
        }
    }
}
