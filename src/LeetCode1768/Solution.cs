using System.Text;

namespace LeetCode1768
{
    public class Solution
    {
        public string MergeAlternately(string word1, string word2)
        {
            var word1Length = word1.Length;
            var word2Length = word2.Length;

            var result = new StringBuilder();

            var word1Index = 0;
            var word2Index = 0;

            while (word1Index < word1Length && word2Index < word2Length)
            {
                result.Append(word1[word1Index]);
                result.Append(word2[word2Index]);
                word1Index++;
                word2Index++;
            }

            while (word1Index < word1Length)
            {
                result.Append(word1[word1Index]);
                word1Index++;
            }

            while (word2Index < word2Length)
            {
                result.Append(word2[word2Index]);
                word2Index++;
            }

            return result.ToString();
        }
    }
}
