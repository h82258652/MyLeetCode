using System;
using FluentAssertions;
using Xunit;

namespace LeetCode2248
{
    public class TestCases
    {
        [Fact]
        public void Test1()
        {
            var solution = new Solution();
            var nums = new int[][]
            {
                new int[] { 3, 1, 2, 4, 5 },
                new int[] { 1, 2, 3, 4 },
                new int[] { 3, 4, 5, 6 }
            };
            var result = solution.Intersection(nums);
            result.Should().Equal(3, 4);
        }

        [Fact]
        public void Test2()
        {
            var solution = new Solution();
            var nums = new int[][]
            {
                new int[] { 1, 2, 3 },
                new int[] { 4, 5, 6 }
            };
            var result = solution.Intersection(nums);
            result.Should().Equal(Array.Empty<int>());
        }
    }
}
