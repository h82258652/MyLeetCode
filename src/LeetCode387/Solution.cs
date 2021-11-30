namespace LeetCode387
{
    public class Solution
    {
        public int FirstUniqChar(string s)
        {
            var charCount = new int[26];
            foreach (var c in s)
            {
                charCount[c - 'a']++;
            }

            for (var i = 0; i < s.Length; i++)
            {
                var c = s[i];
                if (charCount[c - 'a'] > 1)
                {
                    continue;
                }

                return i;
            }

            return -1;
        }
    }
}
