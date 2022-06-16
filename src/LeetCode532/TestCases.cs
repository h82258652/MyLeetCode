using System;
using FluentAssertions;
using Xunit;

namespace LeetCode532
{
    public class TestCases
    {
        [Fact]
        public void Test1()
        {
            var solution = new Solution();
            var nums = new int[] { 3, 1, 4, 1, 5 };
            var k = 2;
            var result = solution.FindPairs(nums, k);
            result.Should().Be(2);
        }

        [Fact]
        public void Test2()
        {
            var solution = new Solution();
            var nums = new int[] { 1, 2, 3, 4, 5 };
            var k = 1;
            var result = solution.FindPairs(nums, k);
            result.Should().Be(4);
        }

        [Fact]
        public void Test3()
        {
            var solution = new Solution();
            var nums = new int[] { 1, 3, 1, 5, 4 };
            var k = 0;
            var result = solution.FindPairs(nums, k);
            result.Should().Be(1);
        }
    }
}
