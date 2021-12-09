namespace LeetCode794
{
    public class Solution
    {
        public bool ValidTicTacToe(string[] board)
        {
            var xCount = 0;
            var oCount = 0;
            foreach (var s in board)
            {
                foreach (var c in s)
                {
                    switch (c)
                    {
                        case 'X':
                            xCount++;
                            break;

                        case 'O':
                            oCount++;
                            break;
                    }
                }
            }

            if (xCount - oCount != 1 && // X 下了，O 还没下
                xCount - oCount != 0)// X 下了，O 也下了，现在轮到 X
            {
                return false;
            }

            var isXWin = IsWin(board, 'X');
            if (isXWin)
            {
                // 如果 X 赢了，X 的数量必须比 O 大 1
                if (xCount - oCount != 1)
                {
                    return false;
                }
            }

            var isOWin = IsWin(board, 'O');
            if (isOWin)
            {
                // 如果 O 赢了，O 和 X 的数量必须相同
                if (oCount != xCount)
                {
                    return false;
                }
            }

            return true;
        }

        private bool IsWin(string[] board, char c)
        {
            for (var i = 0; i < 2; i++)
            {
                // 行
                if (board[i][0] == c && board[i][1] == c && board[i][2] == c)
                {
                    return true;
                }

                // 列
                if (board[0][i] == c && board[1][i] == c && board[2][i] == c)
                {
                    return true;
                }
            }

            // 对角线
            if (board[1][1] == c && ((board[0][0] == c && board[2][2] == c) || (board[0][2] == c && board[2][0] == c)))
            {
                return true;
            }

            return false;
        }
    }
}
