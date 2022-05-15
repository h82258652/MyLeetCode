using FluentAssertions;
using Xunit;

namespace LeetCode944
{
    public class TestCases
    {
        [Fact]
        public void Test1()
        {
            var solution = new Solution();
            var strs = new[] { "cba", "daf", "ghi" };
            var result = solution.MinDeletionSize(strs);
            result.Should().Be(1);
        }

        [Fact]
        public void Test2()
        {
            var solution = new Solution();
            var strs = new[] { "a", "b" };
            var result = solution.MinDeletionSize(strs);
            result.Should().Be(0);
        }

        [Fact]
        public void Test3()
        {
            var solution = new Solution();
            var strs = new[] { "zyx", "wvu", "tsr" };
            var result = solution.MinDeletionSize(strs);
            result.Should().Be(3);
        }
    }
}
