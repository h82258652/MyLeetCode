namespace LeetCode896
{
    public class Solution
    {
        public bool IsMonotonic(int[] nums)
        {
            var length = nums.Length;
            if (length <= 2)
            {
                return true;
            }

            var div = nums[1] - nums[0];
            var sign = 0;
            if (div > 0)
            {
                sign = 1;
            }
            else if (div < 0)
            {
                sign = -1;
            }

            for (var i = 2; i < length; i++)
            {
                div = nums[i] - nums[i - 1];
                if (div == 0)
                {
                    continue;
                }

                if (div < 0)
                {
                    if (sign == 1)
                    {
                        return false;
                    }

                    sign = -1;
                }
                else
                {
                    if (sign == -1)
                    {
                        return false;
                    }

                    sign = 1;
                }
            }

            return true;
        }
    }
}
