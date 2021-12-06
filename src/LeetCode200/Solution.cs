namespace LeetCode200
{
    public class Solution
    {
        public int NumIslands(char[][] grid)
        {
            var m = grid.Length;
            var n = grid[0].Length;

            var result = 0;
            for (var j = 0; j < m; j++)
            {
                var line = grid[j];
                for (var i = 0; i < n; i++)
                {
                    var c = line[i];
                    if (c == '1')
                    {
                        result++;
                        SetDownIsland(grid, i, j, m, n);
                    }
                }
            }

            return result;
        }

        private void SetDownIsland(char[][] grid, int i, int j, int m, int n)
        {
            if (i < 0 || j < 0)
            {
                return;
            }

            if (i >= n || j >= m)
            {
                return;
            }

            if (grid[j][i] == '0')
            {
                return;
            }

            grid[j][i] = '0';
            SetDownIsland(grid, i, j - 1, m, n);
            SetDownIsland(grid, i + 1, j, m, n);
            SetDownIsland(grid, i, j + 1, m, n);
            SetDownIsland(grid, i - 1, j, m, n);
        }
    }
}
