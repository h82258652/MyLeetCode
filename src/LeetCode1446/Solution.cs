using System;

namespace LeetCode1446
{
    public class Solution
    {
        public int MaxPower(string s)
        {
            var result = 1;
            var currentCount = 1;
            var previousChar = s[0];
            var sLength = s.Length;
            for (var i = 1; i < sLength; i++)
            {
                var c = s[i];
                if (c != previousChar)
                {
                    result = Math.Max(result, currentCount);
                    currentCount = 1;
                    previousChar = c;
                }
                else
                {
                    currentCount++;
                }
            }

            result = Math.Max(result, currentCount);

            return result;
        }
    }
}
