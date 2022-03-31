namespace LeetCode2124
{
    public class Solution
    {
        public bool CheckString(string s)
        {
            var aIndex = s.LastIndexOf('a');
            if (aIndex == -1)
            {
                return true;
            }

            var bIndex = s.IndexOf('b');
            if (bIndex == -1)
            {
                return true;
            }

            return aIndex < bIndex;
        }
    }
}
