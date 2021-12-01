using System;

namespace LeetCode633
{
    public class Solution
    {
        public bool JudgeSquareSum(int c)
        {
            if (c == 0)
            {
                return true;
            }

            long left = 0;
            long right = (int)Math.Sqrt(c);
            while (left <= right)
            {
                var sum = left * left + right * right;
                if (sum == c)
                {
                    return true;
                }

                if (sum < c)
                {
                    left++;
                }
                else
                {
                    right--;
                }
            }

            return false;
        }
    }
}
