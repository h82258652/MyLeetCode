using FluentAssertions;
using Xunit;

namespace LeetCode1672
{
    public class TestCases
    {
        [Fact]
        public void Test1()
        {
            var solution = new Solution();
            var accounts = new[]
            {
                new[] { 1, 2, 3 },
                new[] { 3, 2, 1 }
            };
            var result = solution.MaximumWealth(accounts);
            result.Should().Be(6);
        }

        [Fact]
        public void Test2()
        {
            var solution = new Solution();
            var accounts = new[]
            {
                new[] { 1, 5 },
                new[] { 7, 3 },
                new[] { 3, 5 }
            };
            var result = solution.MaximumWealth(accounts);
            result.Should().Be(10);
        }

        [Fact]
        public void Test3()
        {
            var solution = new Solution();
            var accounts = new[]
            {
                new[] { 2, 8, 7 },
                new[] { 7, 1, 3 },
                new[] { 1, 9, 5 }
            };
            var result = solution.MaximumWealth(accounts);
            result.Should().Be(17);
        }
    }
}
