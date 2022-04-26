using System;

namespace LeetCode883
{
    public class Solution
    {
        public int ProjectionArea(int[][] grid)
        {
            var n = grid.Length;

            var xy = 0;
            var yz = 0;
            var zx = 0;
            for (var i = 0; i < n; i++)
            {
                var x = 0;
                var y = 0;
                for (var j = 0; j < n; j++)
                {
                    x = Math.Max(x, grid[j][i]);
                    y = Math.Max(y, grid[i][j]);
                    if (grid[i][j] > 0)
                    {
                        xy++;
                    }
                }

                yz += x;
                zx += y;
            }

            return xy + yz + zx;
        }
    }
}
