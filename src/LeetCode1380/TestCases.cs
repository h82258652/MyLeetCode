using FluentAssertions;
using Xunit;

namespace LeetCode1380
{
    public class TestCases
    {
        [Fact]
        public void Test1()
        {
            var solution = new Solution();
            var result = solution.LuckyNumbers(new[]
            {
                new[] { 3, 7, 8 },
                new[] { 9, 11, 13 },
                new[] { 15, 16, 17 }
            });
            result.Should().Equal(15);
        }

        [Fact]
        public void Test2()
        {
            var solution = new Solution();
            var result = solution.LuckyNumbers(new[]
            {
                new[] { 1, 10, 4, 2 },
                new[] { 9, 3, 8, 7 },
                new[] { 15, 16, 17, 12 }
            });
            result.Should().Equal(12);
        }

        [Fact]
        public void Test3()
        {
            var solution = new Solution();
            var result = solution.LuckyNumbers(new[]
            {
                new[] { 7, 8 },
                new[] { 1, 2 }
            });
            result.Should().Equal(7);
        }
    }
}
