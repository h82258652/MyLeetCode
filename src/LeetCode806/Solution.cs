namespace LeetCode806
{
    public class Solution
    {
        public int[] NumberOfLines(int[] widths, string s)
        {
            var lineCount = 0;
            var lastLineWidth = 0;
            foreach (var c in s)
            {
                var width = widths[c - 'a'];
                if (lastLineWidth + width > 100)
                {
                    lineCount++;
                    lastLineWidth = width;
                }
                else
                {
                    lastLineWidth += width;
                }
            }

            return new[] { lineCount + 1, lastLineWidth };
        }
    }
}
