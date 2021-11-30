namespace LeetCode268
{
    public class Solution
    {
        public int MissingNumber(int[] nums)
        {
            var length = nums.Length;
            var result = length * (length + 1) / 2;
            foreach (var num in nums)
            {
                result -= num;
            }

            return result;
        }
    }
}
