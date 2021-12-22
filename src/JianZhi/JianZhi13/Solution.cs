namespace JianZhi13
{
    public class Solution
    {
        /// <summary>
        /// 时间复杂度 O(m*n)
        /// 空间复杂度 O(m*n)，用于存放 visited 数组
        /// </summary>
        /// <param name="m"></param>
        /// <param name="n"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public int MovingCount(int m, int n, int k)
        {
            var visited = new bool[n][];
            for (var j = 0; j < n; j++)
            {
                visited[j] = new bool[m];
            }

            var count = 0;
            // 从0,0开始
            Dfs(0, 0, m, n, k, visited, ref count);

            return count;
        }

        private void Dfs(int i, int j, int m, int n, int k, bool[][] visited, ref int count)
        {
            // 越界
            if (i < 0 || j < 0 || i >= m || j >= n)
            {
                return;
            }

            // 已访问，剪枝
            if (visited[j][i])
            {
                return;
            }

            visited[j][i] = true;
            // 超过允许范围，比 i 大或者比 j 大的都不用访问了
            if (GetBitSum(j, i) > k)
            {
                return;
            }

            count++;

            Dfs(i + 1, j, m, n, k, visited, ref count);
            Dfs(i, j + 1, m, n, k, visited, ref count);
        }

        private int GetBitSum(int m, int n)
        {
            var sum = 0;
            while (m > 0)
            {
                sum += m % 10;
                m /= 10;
            }

            while (n > 0)
            {
                sum += n % 10;
                n /= 10;
            }

            return sum;
        }
    }
}
