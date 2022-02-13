using System;

namespace LeetCode1189
{
    public class Solution
    {
        public int MaxNumberOfBalloons(string text)
        {
            int[] charCount = new int[26];
            foreach (var c in text)
            {
                charCount[c - 'a']++;
            }

            int result = int.MaxValue;
            result = Math.Min(result, charCount[1]);// b
            result = Math.Min(result, charCount[0]);// a
            result = Math.Min(result, charCount[11] / 2);// l
            result = Math.Min(result, charCount[14] / 2);// o
            result = Math.Min(result, charCount[13]);// n
            return result;
        }
    }
}
