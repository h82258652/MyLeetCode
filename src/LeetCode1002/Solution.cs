using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode1002
{
    public class Solution
    {
        public IList<string> CommonChars(string[] words)
        {
            var wordsLength = words.Length;
            if (wordsLength == 1)
            {
                return words[0].Select(temp => temp.ToString()).ToList();
            }

            var firstWord = words[0];
            var charCounts = new int[26];
            foreach (var c in firstWord)
            {
                charCounts[c - 'a']++;
            }

            var result = new List<string>();

            for (var i = 0; i < charCounts.Length; i++)
            {
                var charCount = charCounts[i];
                if (charCount <= 0)
                {
                    continue;
                }

                var maxCount = int.MaxValue;
                for (var j = 1; j < wordsLength; j++)
                {
                    var word = words[j];
                    var count = word.Count(temp => temp == ('a' + i));
                    maxCount = Math.Min(maxCount, count);
                }

                maxCount = Math.Min(maxCount, charCount);

                for (var j = 0; j < maxCount; j++)
                {
                    var temp = (char)('a' + i);
                    result.Add(temp.ToString());
                }
            }

            return result;
        }
    }
}
