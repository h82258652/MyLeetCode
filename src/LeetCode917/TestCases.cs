using System;
using FluentAssertions;
using Xunit;

namespace LeetCode917
{
    public class TestCases
    {
        [Theory]
        [InlineData("ab-cd", "dc-ba")]
        [InlineData("a-bC-dEf-ghIj", "j-Ih-gfE-dCba")]
        [InlineData("Test1ng-Leet=code-Q!", "Qedo1ct-eeLg=ntse-T!")]
        public void Test(string s, string assertResult)
        {
            var solution = new Solution();
            var result = solution.ReverseOnlyLetters(s);
            result.Should().Be(assertResult);
        }
    }
}
