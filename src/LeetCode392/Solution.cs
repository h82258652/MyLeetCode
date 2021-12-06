namespace LeetCode392
{
    public class Solution
    {
        public bool IsSubsequence(string s, string t)
        {
            if (s == string.Empty)
            {
                return true;
            }

            var sIndex = 0;
            var sLength = s.Length;
            var tLength = t.Length;
            for (var i = 0; i < tLength; i++)
            {
                if (s[sIndex] == t[i])
                {
                    sIndex++;
                    if (sIndex == sLength)
                    {
                        return true;
                    }
                }
            }

            return false;
        }
    }
}
