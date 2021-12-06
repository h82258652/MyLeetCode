using System;

namespace LeetCode055
{
    public class Solution
    {
        public bool CanJump(int[] nums)
        {
            var length = nums.Length;
            var reach = 0;// 每次能到达的最大 index
            for (var i = 0; i < length - 1; i++)
            {
                if (reach < i)
                {
                    // 已经到不了当前 index
                    return false;
                }

                reach = Math.Max(reach, i + nums[i]);
            }

            return reach >= length - 1;
        }
    }
}
