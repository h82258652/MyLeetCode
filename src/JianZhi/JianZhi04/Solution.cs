namespace JianZhi04
{
    public class Solution
    {
        /// <summary>
        /// 时间复杂度 O(m+n)
        /// 空间复杂度 O(1)
        /// </summary>
        /// <param name="matrix"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public bool FindNumberIn2DArray(int[][] matrix, int target)
        {
            var m = matrix.Length;
            if (m <= 0)// 一行都没有
            {
                return false;
            }

            var n = matrix[0].Length;
            if (n <= 0)// 一列都没有
            {
                return false;
            }

            // 从右上角开始找
            var i = 0;
            var j = n - 1;
            while (i < m && j >= 0)
            {
                var num = matrix[i][j];
                if (num == target)
                {
                    return true;
                }

                if (num < target)
                {
                    // 当前数字比目标小，往下一行找
                    i++;
                }
                else
                {
                    // 当前数字比目标大，往左一列找
                    j--;
                }
            }

            return false;
        }
    }
}
