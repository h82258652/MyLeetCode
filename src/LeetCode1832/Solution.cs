using System.Linq;

namespace LeetCode1832
{
    public class Solution
    {
        public bool CheckIfPangram(string sentence)
        {
            var charCount = new int[26];
            foreach (var c in sentence)
            {
                charCount[c - 'a']++;
            }

            return charCount.All(temp => temp > 0);
        }
    }
}
