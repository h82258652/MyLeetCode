namespace LeetCode1706
{
    public class Solution
    {
        public int[] FindBall(int[][] grid)
        {
            var m = grid.Length;
            var n = grid[0].Length;

            var balls = new int[n];
            for (var i = 0; i < n; i++)
            {
                balls[i] = i;
            }

            for (var rowIndex = 0; rowIndex < m; rowIndex++)
            {
                var row = grid[rowIndex];
                for (var columnIndex = 0; columnIndex < n; columnIndex++)
                {
                    var ball = balls[columnIndex];
                    if (ball == -1)
                    {
                        continue;
                    }

                    if (ball == 0)
                    {
                        if (row[0] == -1 || (n > 1 && row[1] == -1) || n == 1)
                        {
                            balls[columnIndex] = -1;
                        }
                        else
                        {
                            balls[columnIndex] = 1;
                        }
                    }
                    else if (ball == n - 1)
                    {
                        if (row[n - 1] == 1 || (n - 2 >= 0 && row[n - 2] == 1) || n == 1)
                        {
                            balls[columnIndex] = -1;
                        }
                        else
                        {
                            balls[columnIndex] = n - 2;
                        }
                    }
                    else
                    {
                        if (row[ball] == 1)
                        {
                            // 往右
                            if (row[ball + 1] == 1)
                            {
                                balls[columnIndex] = ball + 1;
                            }
                            else
                            {
                                balls[columnIndex] = -1;
                            }
                        }
                        else
                        {
                            // 往左
                            if (row[ball - 1] == -1)
                            {
                                balls[columnIndex] = ball - 1;
                            }
                            else
                            {
                                balls[columnIndex] = -1;
                            }
                        }
                    }
                }
            }

            return balls;
        }
    }
}
