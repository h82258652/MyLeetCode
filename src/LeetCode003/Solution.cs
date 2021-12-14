using System;
using System.Collections.Generic;

namespace LeetCode003
{
    public class Solution
    {
        public int LengthOfLongestSubstring(string s)
        {
            var length = s.Length;

            var result = 0;

            var currentChars = new List<char>();
            var currentLength = 0;

            for (var i = 0; i < length; i++)
            {
                var c = s[i];
                var existIndex = currentChars.IndexOf(c);
                if (existIndex <= -1)
                {
                    // 字符没有重复
                    currentLength++;
                    currentChars.Add(c);
                    continue;
                }

                // 字符重复，更新最大长度
                result = Math.Max(result, currentLength);

                // 清空重复字符和它之前的字符
                while (existIndex >= 0)
                {
                    currentChars.RemoveAt(0);
                    existIndex--;
                }

                currentChars.Add(c);
                currentLength = currentChars.Count;
            }

            result = Math.Max(result, currentLength);

            return result;
        }
    }
}
