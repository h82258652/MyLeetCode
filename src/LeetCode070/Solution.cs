namespace LeetCode070
{
    public class Solution
    {
        public int ClimbStairs(int n)
        {
            if (n == 0)
            {
                return 0;
            }

            if (n == 1)
            {
                return 1;
            }

            if (n == 2)
            {
                return 2;
            }

            var nums = new int[n + 1];
            nums[0] = 0;
            nums[1] = 1;
            nums[2] = 2;
            for (var i = 3; i <= n; i++)
            {
                nums[i] = nums[i - 1] + nums[i - 2];
            }

            return nums[n];
        }
    }
}
