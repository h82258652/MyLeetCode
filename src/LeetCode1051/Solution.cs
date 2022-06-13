using System;

namespace LeetCode1051
{
    public class Solution
    {
        public int HeightChecker(int[] heights)
        {
            var length = heights.Length;
            var copy = new int[length];
            Array.Copy(heights, copy, length);
            Array.Sort(copy);
            var result = 0;
            for (var i = 0; i < length; i++)
            {
                if (heights[i] != copy[i])
                {
                    result++;
                }
            }

            return result;
        }
    }
}
