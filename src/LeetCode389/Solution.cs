using System;

namespace LeetCode389
{
    public class Solution
    {
        public char FindTheDifference(string s, string t)
        {
            var tArray = BuildCharCountArray(t);
            var sArray = BuildCharCountArray(s);
            for (var i = 0; i < 26; i++)
            {
                if (tArray[i] != sArray[i])
                {
                    return (char)(i + 'a');
                }
            }

            throw new InvalidOperationException();
        }

        private int[] BuildCharCountArray(string s)
        {
            var charCountArray = new int[26];
            foreach (var c in s)
            {
                charCountArray[c - 'a']++;
            }

            return charCountArray;
        }
    }
}
