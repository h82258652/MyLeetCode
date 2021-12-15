using System.Collections.Generic;

namespace LeetCode036
{
    public class Solution
    {
        public bool IsValidSudoku(char[][] board)
        {
            // 检查行列
            for (var i = 0; i < 9; i++)
            {
                var lineSet = new HashSet<char>();
                var columnSet = new HashSet<char>();

                for (var j = 0; j < 9; j++)
                {
                    var lineChar = board[i][j];
                    if (lineChar != '.')
                    {
                        if (lineSet.Contains(lineChar))
                        {
                            return false;
                        }

                        lineSet.Add(lineChar);
                    }

                    var columnChar = board[j][i];
                    if (columnChar != '.')
                    {
                        if (columnSet.Contains(columnChar))
                        {
                            return false;
                        }

                        columnSet.Add(columnChar);
                    }
                }
            }

            // 检查每个 3x3
            return Check(board, 0, 0) && Check(board, 0, 3) && Check(board, 0, 6) &&
                   Check(board, 3, 0) && Check(board, 3, 3) && Check(board, 3, 6) &&
                   Check(board, 6, 0) && Check(board, 6, 3) && Check(board, 6, 6);
        }

        private bool Check(char[][] board, int x, int y)
        {
            var set = new HashSet<char>();
            for (var i = x; i < x + 3; i++)
            {
                for (var j = y; j < y + 3; j++)
                {
                    var c = board[i][j];
                    if (c == '.')
                    {
                        continue;
                    }

                    if (set.Contains(c))
                    {
                        return false;
                    }

                    set.Add(c);
                }
            }

            return true;
        }
    }
}
