namespace LeetCode2057
{
    public class Solution
    {
        public int SmallestEqual(int[] nums)
        {
            var length = nums.Length;
            for (int i = 0; i < length; i++)
            {
                if (i % 10 == nums[i])
                {
                    return i;
                }
            }

            return -1;
        }
    }
}
