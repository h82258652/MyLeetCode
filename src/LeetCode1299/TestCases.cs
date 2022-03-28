using FluentAssertions;
using Xunit;

namespace LeetCode1299
{
    public class TestCases
    {
        [Fact]
        public void Test1()
        {
            var solution = new Solution();
            var arr = new[] { 17, 18, 5, 4, 6, 1 };
            var result = solution.ReplaceElements(arr);
            result.Should().Equal(18, 6, 6, 6, 1, -1);
        }

        [Fact]
        public void Test2()
        {
            var solution = new Solution();
            var arr = new[] { 400 };
            var result = solution.ReplaceElements(arr);
            result.Should().Equal(-1);
        }
    }
}
