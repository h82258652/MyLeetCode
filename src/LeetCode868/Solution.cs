using System;

namespace LeetCode868
{
    public class Solution
    {
        public int BinaryGap(int n)
        {
            int? firstIndex = null;

            var result = 0;

            var index = 0;
            while (n > 0)
            {
                if (n % 2 == 1)
                {
                    if (!firstIndex.HasValue)
                    {
                        firstIndex = index;
                    }
                    else
                    {
                        result = Math.Max(result, index - firstIndex.Value);
                        firstIndex = index;
                    }
                }

                n /= 2;
                index++;
            }

            return result;
        }
    }
}
