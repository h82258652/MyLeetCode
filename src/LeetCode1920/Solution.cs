namespace LeetCode1920
{
    public class Solution
    {
        public int[] BuildArray(int[] nums)
        {
            var length = nums.Length;
            var result = new int[length];
            for (var i = 0; i < length; i++)
            {
                result[i] = nums[nums[i]];
            }

            return result;
        }
    }
}
