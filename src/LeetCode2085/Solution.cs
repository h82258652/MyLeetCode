using System.Collections.Generic;

namespace LeetCode2085
{
    public class Solution
    {
        public int CountWords(string[] words1, string[] words2)
        {
            var word1Count = new Dictionary<string, int>();
            var word2Count = new Dictionary<string, int>();

            foreach (var word in words1)
            {
                word1Count.TryGetValue(word, out var count);
                word1Count[word] = count + 1;
            }

            foreach (var word in words2)
            {
                word2Count.TryGetValue(word, out var count);
                word2Count[word] = count + 1;
            }

            var result = 0;
            foreach (var (word, countInWord1) in word1Count)
            {
                if (countInWord1 != 1)
                {
                    continue;
                }

                if (word2Count.TryGetValue(word, out var countInWord2) &&
                    countInWord2 == 1)
                {
                    result++;
                }
            }

            return result;
        }
    }
}
