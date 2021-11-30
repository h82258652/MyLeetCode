using System.Collections.Generic;

namespace LeetCode728
{
    public class Solution
    {
        public IList<int> SelfDividingNumbers(int left, int right)
        {
            var result = new List<int>();
            for (var i = left; i <= right; i++)
            {
                if (IsDividingNumber(i))
                {
                    result.Add(i);
                }
            }

            return result;
        }

        private bool IsDividingNumber(int num)
        {
            var temp = num;
            while (temp > 0)
            {
                var mod = temp % 10;
                if (mod == 0)
                {
                    return false;
                }

                if (num % mod != 0)
                {
                    return false;
                }

                temp /= 10;
            }

            return true;
        }
    }
}
