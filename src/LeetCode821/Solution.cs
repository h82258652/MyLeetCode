using System;

namespace LeetCode821
{
    public class Solution
    {
        public int[] ShortestToChar(string s, char c)
        {
            var length = s.Length;

            var leftResult = new int[length];
            var distance = int.MaxValue;
            for (var i = 0; i < length; i++)
            {
                if (s[i] == c)
                {
                    distance = 0;
                }
                else
                {
                    if (distance < int.MaxValue)
                    {
                        distance++;
                    }
                }

                leftResult[i] = distance;
            }

            var rightResult = new int[length];
            distance = int.MaxValue;
            for (var i = length - 1; i >= 0; i--)
            {
                if (s[i] == c)
                {
                    distance = 0;
                }
                else
                {
                    if (distance < int.MaxValue)
                    {
                        distance++;
                    }
                }

                rightResult[i] = distance;
            }

            var result = new int[length];
            for (var i = 0; i < length; i++)
            {
                result[i] = Math.Min(leftResult[i], rightResult[i]);
            }

            return result;
        }
    }
}
