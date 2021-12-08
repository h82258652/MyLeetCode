using System;

namespace LeetCode064
{
    public class Solution
    {
        public int MinPathSum(int[][] grid)
        {
            var m = grid.Length;
            var n = grid[0].Length;

            // 初始化 dp 数组
            var dp = new int[m][];
            for (var j = 0; j < m; j++)
            {
                dp[j] = new int[n];
            }

            // 计算 dp 左上角
            dp[0][0] = grid[0][0];

            // 计算 dp 数组的第一行
            for (var i = 1; i < n; i++)
            {
                dp[0][i] = dp[0][i - 1] + grid[0][i];
            }

            // 计算 dp 数组的第一列
            for (var j = 1; j < m; j++)
            {
                dp[j][0] = dp[j - 1][0] + grid[j][0];
            }

            // 计算 dp 剩余的单元格
            for (var i = 1; i < n; i++)
            {
                for (var j = 1; j < m; j++)
                {
                    dp[j][i] = Math.Min(dp[j - 1][i], dp[j][i - 1]) + grid[j][i];
                }
            }

            return dp[m - 1][n - 1];
        }
    }
}
