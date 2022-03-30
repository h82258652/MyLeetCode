using System.Collections.Generic;
using FluentAssertions;
using Xunit;

namespace LeetCode1200
{
    public class TestCases
    {
        [Fact]
        public void Test1()
        {
            var solution = new Solution();
            var arr = new[] { 4, 2, 1, 3 };
            var result = solution.MinimumAbsDifference(arr);
            result.Should().BeEquivalentTo(new List<IList<int>>
            {
                new List<int> { 1, 2 },
                new List<int> { 2, 3 },
                new List<int> { 3, 4 }
            }, options => options.WithStrictOrdering());
        }

        [Fact]
        public void Test2()
        {
            var solution = new Solution();
            var arr = new[] { 1, 3, 6, 10, 15 };
            var result = solution.MinimumAbsDifference(arr);
            result.Should().BeEquivalentTo(new List<IList<int>>
            {
                new List<int> { 1, 3 }
            }, options => options.WithStrictOrdering());
        }

        [Fact]
        public void Test3()
        {
            var solution = new Solution();
            var arr = new[] { 3, 8, -10, 23, 19, -4, -14, 27 };
            var result = solution.MinimumAbsDifference(arr);
            result.Should().BeEquivalentTo(new List<IList<int>>
            {
                new List<int> { -14, -10 },
                new List<int> { 19, 23 },
                new List<int> { 23, 27 }
            }, options => options.WithStrictOrdering());
        }
    }
}
