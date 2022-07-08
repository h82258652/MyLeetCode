using System;

namespace LeetCode1217
{
    public class Solution
    {
        public int MinCostToMoveChips(int[] position)
        {
            var oddCount = 0;// 奇数的个数
            var evenCount = 0;// 偶数的个数
            foreach (var num in position)
            {
                if (num % 2 == 1)
                {
                    oddCount++;
                }
                else
                {
                    evenCount++;
                }
            }

            return Math.Min(oddCount, evenCount);
        }
    }
}
