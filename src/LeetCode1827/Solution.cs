namespace LeetCode1827
{
    public class Solution
    {
        public int MinOperations(int[] nums)
        {
            var result = 0;
            for (var i = 1; i < nums.Length; i++)
            {
                var previous = nums[i - 1];
                var current = nums[i];
                if (current > previous)
                {
                    continue;
                }

                result += previous + 1 - current;

                nums[i] = previous + 1;
            }

            return result;
        }
    }
}
