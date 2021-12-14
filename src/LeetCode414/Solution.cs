using System.Linq;

namespace LeetCode414
{
    public class Solution
    {
        public int ThirdMax(int[] nums)
        {
            nums = nums.Distinct().OrderByDescending(temp => temp).ToArray();
            if (nums.Length < 3)
            {
                return nums[0];
            }

            return nums[2];
        }
    }
}
