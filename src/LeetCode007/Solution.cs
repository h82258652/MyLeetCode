using System;

namespace LeetCode007
{
    public class Solution
    {
        public int Reverse(int x)
        {
            if (x == int.MinValue || x == 0)
            {
                return 0;
            }

            int flag = x > 0 ? 1 : -1;
            x = Math.Abs(x);

            int result = 0;
            while (x > 0)
            {
                // 溢出检测
                if (result > int.MaxValue / 10)
                {
                    return 0;
                }

                result *= 10;
                var mod = x % 10;

                // 溢出检测
                if (result > int.MaxValue - mod)
                {
                    return 0;
                }

                result += mod;
                x /= 10;
            }

            return result * flag;
        }
    }
}
