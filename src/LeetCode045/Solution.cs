using System;

namespace LeetCode045
{
    public class Solution
    {
        public int Jump(int[] nums)
        {
            var length = nums.Length;
            var dp = new int[length];
            Array.Fill(dp, int.MaxValue);
            dp[0] = 0;
            for (var i = 0; i < length - 1; i++)
            {
                var num = nums[i];
                var currentStep = dp[i];
                for (var j = 1; j <= num && j < length - i; j++)
                {
                    dp[i + j] = Math.Min(dp[i + j], currentStep + 1);
                }
            }

            return dp[length - 1];
        }
    }
}
