using System.Linq;

namespace LeetCode1725
{
    public class Solution
    {
        public int CountGoodRectangles(int[][] rectangles)
        {
            var size = rectangles.Select(rectangle => rectangle.Min()).ToArray();
            var maxSize = size.Max();
            return size.Count(temp => temp == maxSize);
        }
    }
}
