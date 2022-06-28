using System;

namespace LeetCode324
{
    public class Solution
    {
        public void WiggleSort(int[] nums)
        {
            var length = nums.Length;
            Array.Sort(nums);
            var result = new int[length];

            if (length % 2 == 0)
            {
                var index = 1;
                for (var i = length - 1; i >= length / 2; i--)
                {
                    result[index] = nums[i];
                    index += 2;
                }

                index = 0;
                for (var i = length / 2 - 1; i >= 0; i--)
                {
                    result[index] = nums[i];
                    index += 2;
                }
            }
            else
            {
                var index = 1;
                for (var i = length - 1; i >= length / 2 + 1; i--)
                {
                    result[index] = nums[i];
                    index += 2;
                }

                index = 0;
                for (var i = length / 2; i >= 0; i--)
                {
                    result[index] = nums[i];
                    index += 2;
                }
            }

            Array.Copy(result, nums, length);
        }
    }
}
