using System;

namespace LeetCode1758
{
    public class Solution
    {
        public int MinOperations(string s)
        {
            var length = s.Length;

            var zeroBaseCount = 0;
            var oneBaseCount = 0;
            for (var i = 0; i < length; i++)
            {
                var c = s[i];
                if (i % 2 == 0)
                {
                    if (c != '0')
                    {
                        zeroBaseCount++;
                    }
                    else
                    {
                        oneBaseCount++;
                    }
                }
                else
                {
                    if (c != '1')
                    {
                        zeroBaseCount++;
                    }
                    else
                    {
                        oneBaseCount++;
                    }
                }
            }

            return Math.Min(zeroBaseCount, oneBaseCount);
        }
    }
}
