namespace LeetCode383
{
    public class Solution
    {
        public bool CanConstruct(string ransomNote, string magazine)
        {
            var magazineCharCounts = new int[26];
            foreach (var c in magazine)
            {
                magazineCharCounts[c - 'a']++;
            }

            foreach (var c in ransomNote)
            {
                if (magazineCharCounts[c - 'a'] > 0)
                {
                    magazineCharCounts[c - 'a']--;
                }
                else
                {
                    return false;
                }
            }

            return true;
        }
    }
}
