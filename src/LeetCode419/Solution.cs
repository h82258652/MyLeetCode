namespace LeetCode419
{
    public class Solution
    {
        public int CountBattleships(char[][] board)
        {
            var m = board.Length;
            var n = board[0].Length;

            var visited = new bool[m][];

            for (var i = 0; i < m; i++)
            {
                visited[i] = new bool[n];
            }

            var result = 0;
            for (var i = 0; i < m; i++)
            {
                for (var j = 0; j < n; j++)
                {
                    if (visited[i][j])
                    {
                        continue;
                    }

                    if (board[i][j] == '.')
                    {
                        continue;
                    }

                    result++;
                    Dfs(board, i, j, m, n, visited);
                }
            }

            return result;
        }

        private void Dfs(char[][] board, int i, int j, int m, int n, bool[][] visited)
        {
            if (i < 0 || j < 0 || i >= m || j >= n)
            {
                return;
            }

            if (visited[i][j])
            {
                return;
            }

            visited[i][j] = true;
            if (board[i][j] == '.')
            {
                return;
            }

            Dfs(board, i - 1, j, m, n, visited);
            Dfs(board, i + 1, j, m, n, visited);
            Dfs(board, i, j - 1, m, n, visited);
            Dfs(board, i, j + 1, m, n, visited);
        }
    }
}
