using System;

namespace LeetCode695
{
    public class Solution
    {
        public int MaxAreaOfIsland(int[][] grid)
        {
            var height = grid.Length;
            var width = grid[0].Length;

            var visited = new bool[height][];
            for (var i = 0; i < height; i++)
            {
                visited[i] = new bool[width];
            }

            var maxSize = 0;
            for (var i = 0; i < height; i++)
            {
                for (var j = 0; j < width; j++)
                {
                    var size = Dfs(grid, i, j, height, width, visited);
                    maxSize = Math.Max(maxSize, size);
                }
            }

            return maxSize;
        }

        private int Dfs(int[][] grid, int i, int j, int height, int width, bool[][] visited)
        {
            if (i < 0 || j < 0 || i >= height || j >= width)
            {
                return 0;
            }

            if (visited[i][j])
            {
                return 0;
            }

            visited[i][j] = true;
            if (grid[i][j] == 0)
            {
                return 0;
            }

            var size = 1;
            size += Dfs(grid, i - 1, j, height, width, visited);
            size += Dfs(grid, i + 1, j, height, width, visited);
            size += Dfs(grid, i, j - 1, height, width, visited);
            size += Dfs(grid, i, j + 1, height, width, visited);
            return size;
        }
    }
}
