using System.Collections.Generic;

namespace LeetCode290
{
    public class Solution
    {
        public bool WordPattern(string pattern, string s)
        {
            var words = s.Split(' ');
            if (pattern.Length != words.Length)
            {
                return false;
            }

            var patternWordMap = new Dictionary<char, string>();
            var wordPatternMap = new Dictionary<string, char>();

            var patternLength = pattern.Length;

            for (var i = 0; i < patternLength; i++)
            {
                var c = pattern[i];
                var word = words[i];

                if (patternWordMap.ContainsKey(c))
                {
                    if (patternWordMap[c] != word)
                    {
                        return false;
                    }
                }

                if (wordPatternMap.ContainsKey(word))
                {
                    if (wordPatternMap[word] != c)
                    {
                        return false;
                    }
                }

                patternWordMap[c] = word;
                wordPatternMap[word] = c;
            }

            return true;
        }
    }
}
