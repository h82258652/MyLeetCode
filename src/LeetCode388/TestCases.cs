using FluentAssertions;
using Xunit;

namespace LeetCode388
{
    public class TestCases
    {
        [Theory]
        [InlineData("dir\n\tsubdir1\n\tsubdir2\n\t\tfile.ext", 20)]
        [InlineData("dir\n\tsubdir1\n\t\tfile1.ext\n\t\tsubsubdir1\n\tsubdir2\n\t\tsubsubdir2\n\t\t\tfile2.ext", 32)]
        [InlineData("a", 0)]
        [InlineData("file1.txt\nfile2.txt\nlongfile.txt", 12)]
        public void Test(string input, int expected)
        {
            var solution = new Solution();
            var result = solution.LengthLongestPath(input);
            result.Should().Be(expected);
        }
    }
}
