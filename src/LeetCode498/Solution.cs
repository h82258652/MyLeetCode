namespace LeetCode498
{
    public class Solution
    {
        public int[] FindDiagonalOrder(int[][] mat)
        {
            var m = mat.Length;
            var n = mat[0].Length;

            var i = 0;
            var x = 0;
            var y = 0;
            var direction = Direction.TopRight;
            var result = new int[m * n];

            while (true)
            {
                if (x == m - 1 && y == n - 1)
                {
                    result[i] = mat[x][y];
                    break;
                }

                result[i] = mat[x][y];
                i++;

                if (direction == Direction.TopRight)
                {
                    if (y == n - 1)
                    {
                        x++;
                        direction = Direction.BottomLeft;
                    }
                    else if (x == 0)
                    {
                        y++;
                        direction = Direction.BottomLeft;
                    }
                    else
                    {
                        x--;
                        y++;
                    }
                }
                else
                {
                    if (x == m - 1)
                    {
                        y++;
                        direction = Direction.TopRight;
                    }
                    else if (y == 0)
                    {
                        x++;
                        direction = Direction.TopRight;
                    }
                    else
                    {
                        x++;
                        y--;
                    }
                }
            }

            return result;
        }

        public enum Direction
        {
            TopRight,
            BottomLeft
        }
    }
}
