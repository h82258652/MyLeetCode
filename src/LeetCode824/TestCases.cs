using FluentAssertions;
using Xunit;

namespace LeetCode824
{
    public class TestCases
    {
        [Fact]
        public void Test1()
        {
            var solution = new Solution();
            var result = solution.ToGoatLatin("I speak Goat Latin");
            result.Should().Be("Imaa peaksmaaa oatGmaaaa atinLmaaaaa");
        }

        [Fact]
        public void Test2()
        {
            var solution = new Solution();
            var result = solution.ToGoatLatin("The quick brown fox jumped over the lazy dog");
            result.Should().Be("heTmaa uickqmaaa rownbmaaaa oxfmaaaaa umpedjmaaaaaa overmaaaaaaa hetmaaaaaaaa azylmaaaaaaaaa ogdmaaaaaaaaaa");
        }
    }
}
