﻿namespace LeetCode191
{
    public class Solution
    {
        public int HammingWeight(uint n)
        {
            var result = 0;
            for (var i = 0; i < 32; i++)
            {
                if ((n & 1) == 1)
                {
                    result++;
                }

                n >>= 1;
            }

            return result;
        }
    }
}
