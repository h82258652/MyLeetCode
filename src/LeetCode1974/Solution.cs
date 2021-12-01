using System;

namespace LeetCode1974
{
    public class Solution
    {
        public int MinTimeToType(string word)
        {
            var length = word.Length;
            var result = length;
            char previous = 'a';
            for (var i = 0; i < length; i++)
            {
                var current = word[i];
                var diff = Math.Abs(current - previous);
                if (diff >= 13)
                {
                    diff = 26 - diff;
                }

                result += diff;
                previous = current;
            }

            return result;
        }
    }
}
