using System;

namespace LeetCode807
{
    public class Solution
    {
        public int MaxIncreaseKeepingSkyline(int[][] grid)
        {
            var size = grid.Length;

            var vertical = new int[size];
            for (var j = 0; j < size; j++)
            {
                var max = int.MinValue;
                for (var i = 0; i < size; i++)
                {
                    var high = grid[i][j];
                    max = Math.Max(max, high);
                }

                vertical[j] = max;
            }

            var horizontal = new int[size];
            for (var i = 0; i < size; i++)
            {
                var max = int.MinValue;
                var line = grid[i];
                for (var j = 0; j < size; j++)
                {
                    var high = line[j];
                    max = Math.Max(max, high);
                }

                horizontal[i] = max;
            }

            var result = 0;
            for (var i = 0; i < size; i++)
            {
                for (var j = 0; j < size; j++)
                {
                    var high = grid[i][j];
                    var canAddHigh = Math.Min(vertical[j], horizontal[i]) - high;
                    result += canAddHigh;
                }
            }

            return result;
        }
    }
}
