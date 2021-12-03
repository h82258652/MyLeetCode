using System;
using System.Linq;

namespace LeetCode1005
{
    public class Solution
    {
        public int LargestSumAfterKNegations(int[] nums, int k)
        {
            Array.Sort(nums);
            var length = nums.Length;
            for (var i = 0; i < length; i++)
            {
                // 已经没有反转次数了，退出
                if (k <= 0)
                {
                    break;
                }

                var num = nums[i];
                if (num < 0)
                {
                    // 是负数，则反转为正数
                    nums[i] = -nums[i];
                    k--;
                    continue;
                }

                if (num == 0)
                {
                    // 找到一个是 0 的数，直接对它反转 k 次即可
                    k = 0;
                    break;
                }

                // 找到大于等于 0 的第一个数
                if (k % 2 == 0)
                {
                    // 剩余偶数次
                    k = 0;
                    break;
                }

                // 剩余奇数次

                if (i > 0)
                {
                    var previous = nums[i - 1];
                    if (previous < num)
                    {
                        nums[i - 1] = -nums[i - 1];
                        k = 0;
                        break;
                    }
                }

                nums[i] = -nums[i];
                k = 0;
                break;
            }

            var sum = 0;

            // 扫描完数组一遍之后仍有剩余反转次数，且为奇数次，则反转最小的那个数
            if (k > 0 && k % 2 == 1)
            {
                sum = sum - 2 * nums.Min();
            }

            sum = sum + nums.Sum();

            return sum;
        }
    }
}
