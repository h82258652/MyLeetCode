using FluentAssertions;
using Xunit;

namespace LeetCode2108
{
    public class TestCases
    {
        [Fact]
        public void Test1()
        {
            var solution = new Solution();
            var words = new[]
            {
                "abc",
                "car",
                "ada",
                "racecar",
                "cool"
            };
            var result = solution.FirstPalindrome(words);
            result.Should().Be("ada");
        }

        [Fact]
        public void Test2()
        {
            var solution = new Solution();
            var words = new[]
            {
                "notapalindrome",
                "racecar"
            };
            var result = solution.FirstPalindrome(words);
            result.Should().Be("racecar");
        }

        [Fact]
        public void Test3()
        {
            var solution = new Solution();
            var words = new[]
            {
                "def",
                "ghi"
            };
            var result = solution.FirstPalindrome(words);
            result.Should().Be("");
        }
    }
}
