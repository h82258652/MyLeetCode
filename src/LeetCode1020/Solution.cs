namespace LeetCode1020
{
    public class Solution
    {
        public int NumEnclaves(int[][] grid)
        {
            var m = grid.Length;
            var n = grid[0].Length;
            for (var i = 0; i < m; i++)
            {
                var line = grid[i];
                for (var j = 0; j < n; j++)
                {
                    if (i == 0 || i == m - 1 || j == 0 || j == n - 1)
                    {
                        var cell = line[j];
                        if (cell == 1)
                        {
                            Dfs(grid, i, j, m, n);
                        }
                    }
                }
            }

            var count = 0;
            for (var i = 0; i < m; i++)
            {
                var line = grid[i];
                for (var j = 0; j < n; j++)
                {
                    var cell = line[j];
                    if (cell == 1)
                    {
                        count++;
                    }
                }
            }

            return count;
        }

        private void Dfs(int[][] grid, int i, int j, int m, int n)
        {
            if (i < 0 || i >= m || j < 0 || j >= n)
            {
                return;
            }

            var cell = grid[i][j];
            if (cell == 0 || cell == 2)
            {
                return;
            }

            grid[i][j] = 2;
            Dfs(grid, i - 1, j, m, n);
            Dfs(grid, i + 1, j, m, n);
            Dfs(grid, i, j - 1, m, n);
            Dfs(grid, i, j + 1, m, n);
        }
    }
}
