using System.Collections.Generic;
using FluentAssertions;
using Xunit;

namespace LeetCode648
{
    public class TestCases
    {
        [Fact]
        public void Test1()
        {
            var solution = new Solution();
            var dictionary = new List<string>() { "cat", "bat", "rat" };
            var sentence = "the cattle was rattled by the battery";
            var result = solution.ReplaceWords(dictionary, sentence);
            result.Should().Be("the cat was rat by the bat");
        }

        [Fact]
        public void Test2()
        {
            var solution = new Solution();
            var dictionary = new List<string>() { "a", "b", "c" };
            var sentence = "aadsfasf absbs bbab cadsfafs";
            var result = solution.ReplaceWords(dictionary, sentence);
            result.Should().Be("a a b c");
        }
    }
}
