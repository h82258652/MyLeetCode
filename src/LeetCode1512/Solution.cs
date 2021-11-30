namespace LeetCode1512
{
    public class Solution
    {
        public int NumIdenticalPairs(int[] nums)
        {
            var length = nums.Length;
            var result = 0;
            for (int i = 0; i < length; i++)
            {
                var num = nums[i];
                for (int j = i + 1; j < length; j++)
                {
                    if (num == nums[j])
                    {
                        result++;
                    }
                }
            }

            return result;
        }
    }
}
