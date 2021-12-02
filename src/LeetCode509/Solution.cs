namespace LeetCode509
{
    public class Solution
    {
        public int Fib(int n)
        {
            if (n == 0)
            {
                return 0;
            }

            var nums = new int[n + 1];
            nums[0] = 0;
            nums[1] = 1;
            for (var i = 2; i <= n; i++)
            {
                nums[i] = nums[i - 1] + nums[i - 2];
            }

            return nums[n];
        }
    }
}
