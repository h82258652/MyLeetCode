using System;
using FluentAssertions;
using Xunit;

namespace LeetCode1447
{
    public class TestCases
    {
        [Fact]
        public void Test1()
        {
            var solution = new Solution();
            var result = solution.SimplifiedFractions(2);
            result.Should().BeEquivalentTo("1/2");
        }

        [Fact]
        public void Test2()
        {
            var solution = new Solution();
            var result = solution.SimplifiedFractions(3);
            result.Should().BeEquivalentTo("1/2", "1/3", "2/3");
        }

        [Fact]
        public void Test3()
        {
            var solution = new Solution();
            var result = solution.SimplifiedFractions(4);
            result.Should().BeEquivalentTo("1/2", "1/3", "1/4", "2/3", "3/4");
        }

        [Fact]
        public void Test4()
        {
            var solution = new Solution();
            var result = solution.SimplifiedFractions(1);
            result.Should().BeEquivalentTo(Array.Empty<string>());
        }
    }
}
