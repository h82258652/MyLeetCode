namespace JianZhi12
{
    public class Solution
    {
        /// <summary>
        /// 时间复杂度 O(width*height*3^length)，遍历格子需要width*height，每次3个方向查找word的字符
        /// 空间复杂度 O(width*height)，从第一个格子走遍所有格子所需要的堆栈
        /// </summary>
        /// <param name="board"></param>
        /// <param name="word"></param>
        /// <returns></returns>
        public bool Exist(char[][] board, string word)
        {
            var height = board.Length;
            var width = board[0].Length;
            var wordLength = word.Length;
            for (var i = 0; i < height; i++)
            {
                for (var j = 0; j < width; j++)
                {
                    var exist = Dfs(board, i, j, height, width, word, 0, wordLength);
                    if (exist)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        private bool Dfs(char[][] board, int i, int j, int height, int width, string word, int wordIndex, int wordLength)
        {
            if (wordIndex >= wordLength)
            {
                return false;
            }

            if (i < 0 || i >= height || j < 0 || j >= width)
            {
                return false;
            }

            if (board[i][j] != word[wordIndex])
            {
                return false;
            }

            // 到达最后一个字符且匹配
            if (wordIndex == wordLength - 1)
            {
                return true;
            }

            try
            {
                // 因为只包含大小写字符，用 \0 标记这个格子已经走过
                board[i][j] = '\0';
                return Dfs(board, i - 1, j, height, width, word, wordIndex + 1, wordLength) ||
                       Dfs(board, i + 1, j, height, width, word, wordIndex + 1, wordLength) ||
                       Dfs(board, i, j - 1, height, width, word, wordIndex + 1, wordLength) ||
                       Dfs(board, i, j + 1, height, width, word, wordIndex + 1, wordLength);
            }
            finally
            {
                // 恢复格子，相当于退栈
                board[i][j] = word[wordIndex];
            }
        }
    }
}
