using System;

namespace JianZhi64
{
    public class Solution
    {
        /// <summary>
        /// 时间复杂度 O(1)
        /// 空间复杂度 O(1)
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public int SumNums(int n)
        {
            // sum = n * (n + 1) / 2
            // sum = (n * n + n) / 2
            // sum = (n * n + n) >> 1
            return ((int)Math.Pow(n, 2) + n) >> 1;
        }
    }
}
