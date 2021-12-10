using FluentAssertions;
using Xunit;

namespace LeetCode748
{
    public class TestCases
    {
        [Theory]
        [InlineData("1s3 PSt", new[] { "step", "steps", "stripe", "stepple" }, "steps")]
        [InlineData("1s3 456", new[] { "looks", "pest", "stew", "show" }, "pest")]
        [InlineData("Ah71752", new[] { "suggest", "letter", "of", "husband", "easy", "education", "drug", "prevent", "writer", "old" }, "husband")]
        [InlineData("OgEu755", new[] { "enough", "these", "play", "wide", "wonder", "box", "arrive", "money", "tax", "thus" }, "enough")]
        [InlineData("iMSlpe4", new[] { "claim", "consumer", "student", "camera", "public", "never", "wonder", "simple", "thought", "use" }, "simple")]
        public void Test(string licensePlate, string[] words, string assertResult)
        {
            var solution = new Solution();
            var result = solution.ShortestCompletingWord(licensePlate, words);
            result.Should().Be(assertResult);
        }
    }
}
