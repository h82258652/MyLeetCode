using System;
using System.Numerics;

namespace LeetCode2259
{
    public class Solution
    {
        public string RemoveDigit(string number, char digit)
        {
            var max = BigInteger.Zero;

            for (var i = 0; i < number.Length; i++)
            {
                if (number[i] == digit)
                {
                    var value = BigInteger.Parse(number.Substring(0, i) + number.Substring(i + 1));
                    max = BigInteger.Max(max, value);
                }
            }

            return max.ToString();
        }
    }
}
