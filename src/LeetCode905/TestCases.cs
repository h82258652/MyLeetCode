using System.Linq;
using FluentAssertions;
using Xunit;

namespace LeetCode905
{
    public class TestCases
    {
        [Fact]
        public void Test1()
        {
            var solution = new Solution();
            var result = solution.SortArrayByParity(new[] { 3, 1, 2, 4 });
            (result.SequenceEqual(new[] { 2, 4, 3, 1 }) ||
             result.SequenceEqual(new[] { 4, 2, 3, 1 }) ||
             result.SequenceEqual(new[] { 2, 4, 1, 3 }) ||
             result.SequenceEqual(new[] { 4, 2, 1, 3 }))
                .Should()
                .BeTrue();
        }
    }
}
