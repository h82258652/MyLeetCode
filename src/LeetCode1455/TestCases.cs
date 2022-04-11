using FluentAssertions;
using Xunit;

namespace LeetCode1455
{
    public class TestCases
    {
        [Fact]
        public void Test1()
        {
            var solution = new Solution();
            var result = solution.IsPrefixOfWord("i love eating burger", "burg");
            result.Should().Be(4);
        }

        [Fact]
        public void Test2()
        {
            var solution = new Solution();
            var result = solution.IsPrefixOfWord("this problem is an easy problem", "pro");
            result.Should().Be(2);
        }

        [Fact]
        public void Test3()
        {
            var solution = new Solution();
            var result = solution.IsPrefixOfWord("i am tired", "you");
            result.Should().Be(-1);
        }
    }
}
