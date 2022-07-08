using FluentAssertions;
using Xunit;

namespace LeetCode1217
{
    public class TestCases
    {
        [Fact]
        public void Test1()
        {
            var solution = new Solution();
            var position = new int[] { 1, 2, 3 };
            var result = solution.MinCostToMoveChips(position);
            result.Should().Be(1);
        }

        [Fact]
        public void Test2()
        {
            var solution = new Solution();
            var position = new int[] { 2, 2, 2, 3, 3 };
            var result = solution.MinCostToMoveChips(position);
            result.Should().Be(2);
        }

        [Fact]
        public void Test3()
        {
            var solution = new Solution();
            var position = new int[] { 1, 1000000000 };
            var result = solution.MinCostToMoveChips(position);
            result.Should().Be(1);
        }
    }
}
