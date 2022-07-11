using FluentAssertions;
using Xunit;

namespace LeetCode676
{
    public class TestCases
    {
        [Fact]
        public void Test1()
        {
            var magicDictionary = new MagicDictionary();
            var dictionary = new string[] { "hello", "leetcode" };
            magicDictionary.BuildDict(dictionary);
            magicDictionary.Search("hello").Should().BeFalse();
            magicDictionary.Search("hhllo").Should().BeTrue();
            magicDictionary.Search("hell").Should().BeFalse();
            magicDictionary.Search("leetcoded").Should().BeFalse();
        }
    }
}
