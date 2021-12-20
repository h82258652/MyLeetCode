using System;

namespace JianZhi57
{
    public class Solution
    {
        /// <summary>
        /// 时间复杂度 O(n)
        /// 空间复杂度 O(1)
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public int[] TwoSum(int[] nums, int target)
        {
            var left = 0;
            var right = nums.Length - 1;
            while (left < right)
            {
                var leftVal = nums[left];
                var rightVal = nums[right];
                var sum = leftVal + rightVal;
                if (sum == target)
                {
                    return new[] { leftVal, rightVal };
                }

                if (sum < target)
                {
                    left++;
                }
                else
                {
                    right--;
                }
            }

            throw new InvalidOperationException();
        }
    }
}
