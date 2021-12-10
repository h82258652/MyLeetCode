using FluentAssertions;
using Xunit;

namespace LeetCode2094
{
    public class TestCases
    {
        [Theory]
        [InlineData(new[] { 2, 1, 3, 0 }, new[] { 102, 120, 130, 132, 210, 230, 302, 310, 312, 320 })]
        [InlineData(new[] { 2, 2, 8, 8, 2 }, new[] { 222, 228, 282, 288, 822, 828, 882 })]
        [InlineData(new[] { 3, 7, 5 }, new int[] { })]
        [InlineData(new[] { 0, 2, 0, 0 }, new[] { 200 })]
        [InlineData(new[] { 0, 0, 0 }, new int[] { })]
        public void Test(int[] digits, int[] excepted)
        {
            var solution = new Solution();
            var result = solution.FindEvenNumbers(digits);
            result.Should().Equal(excepted);
        }
    }
}
