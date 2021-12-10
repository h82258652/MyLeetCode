using System;
using System.Collections.Generic;

namespace LeetCode2089
{
    public class Solution
    {
        public IList<int> TargetIndices(int[] nums, int target)
        {
            Array.Sort(nums);
            var result = new List<int>();
            var length = nums.Length;
            for (var i = 0; i < length; i++)
            {
                if (nums[i] == target)
                {
                    result.Add(i);
                }
            }

            return result;
        }
    }
}
