using System;

namespace LeetCode746
{
    public class Solution
    {
        public int MinCostClimbingStairs(int[] cost)
        {
            var n = cost.Length;
            var totalCost = new int[n + 1];

            totalCost[0] = 0;
            totalCost[1] = 0;

            for (var i = 2; i <= n; i++)
            {
                totalCost[i] = Math.Min(totalCost[i - 1] + cost[i - 1], totalCost[i - 2] + cost[i - 2]);
            }

            return totalCost[n];
        }
    }
}
