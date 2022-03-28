using System.Collections.Generic;

namespace LeetCode1704
{
    public class Solution
    {
        private static readonly HashSet<char> Vowels = new HashSet<char> { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };

        public bool HalvesAreAlike(string s)
        {
            var count = 0;
            var length = s.Length;
            var halfLength = length >> 1;
            for (var i = 0; i < halfLength; i++)
            {
                if (Vowels.Contains(s[i]))
                {
                    count++;
                }
            }

            for (var i = halfLength; i < length; i++)
            {
                if (Vowels.Contains(s[i]))
                {
                    count--;
                }
            }

            return count == 0;
        }
    }
}
