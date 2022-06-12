using System.Collections.Generic;

namespace LeetCode890
{
    public class Solution
    {
        public IList<string> FindAndReplacePattern(string[] words, string pattern)
        {
            var length = pattern.Length;
            var result = new List<string>();
            foreach (var word in words)
            {
                if (MatchPattern(word, pattern, length))
                {
                    result.Add(word);
                }
            }

            return result;
        }

        private bool MatchPattern(string word, string pattern, int length)
        {
            var patternToWord = new Dictionary<char, char>();
            var wordToPattern = new Dictionary<char, char>();

            for (var i = 0; i < length; i++)
            {
                var patternCharacter = pattern[i];
                var wordCharacter = word[i];
                if (patternToWord.ContainsKey(patternCharacter))
                {
                    if (patternToWord[patternCharacter] != wordCharacter)
                    {
                        return false;
                    }
                }
                else
                {
                    patternToWord[patternCharacter] = wordCharacter;
                }

                if (wordToPattern.ContainsKey(wordCharacter))
                {
                    if (wordToPattern[wordCharacter] != patternCharacter)
                    {
                        return false;
                    }
                }
                else
                {
                    wordToPattern[wordCharacter] = patternCharacter;
                }
            }

            return true;
        }
    }
}
