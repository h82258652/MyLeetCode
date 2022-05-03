using FluentAssertions;
using Xunit;

namespace LeetCode2053
{
    public class TestCases
    {
        [Fact]
        public void Test1()
        {
            var solution = new Solution();
            var arr = new string[] { "d", "b", "c", "b", "c", "a" };
            var k = 2;
            var result = solution.KthDistinct(arr, k);
            result.Should().Be("a");
        }

        [Fact]
        public void Test2()
        {
            var solution = new Solution();
            var arr = new string[] { "aaa", "aa", "a" };
            var k = 1;
            var result = solution.KthDistinct(arr, k);
            result.Should().Be("aaa");
        }

        [Fact]
        public void Test3()
        {
            var solution = new Solution();
            var arr = new string[] { "a", "b", "a" };
            var k = 3;
            var result = solution.KthDistinct(arr, k);
            result.Should().Be("");
        }
    }
}
