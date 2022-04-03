using System.Linq;
using FluentAssertions;
using Xunit;

namespace LeetCode026
{
    public class TestCases
    {
        [Fact]
        public void Test1()
        {
            var solution = new Solution();
            var nums = new int[] { 1, 1, 2 };
            var result = solution.RemoveDuplicates(nums);
            result.Should().Be(2);
            nums.Take(result).Should().Equal(1, 2);
        }

        [Fact]
        public void Test2()
        {
            var solution = new Solution();
            var nums = new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
            var result = solution.RemoveDuplicates(nums);
            result.Should().Be(5);
            nums.Take(result).Should().Equal(0, 1, 2, 3, 4);
        }
    }
}
