namespace LeetCode172
{
    public class Solution
    {
        public int TrailingZeroes(int n)
        {
            if (n == 0)
            {
                return 0;
            }

            var count = 0;
            for (var i = 5; i <= n; i += 5)
            {
                var temp = i;
                while (temp > 0)
                {
                    if (temp % 5 == 0)
                    {
                        count++;
                        temp /= 5;
                    }
                    else
                    {
                        break;
                    }
                }
            }

            return count;
        }
    }
}
