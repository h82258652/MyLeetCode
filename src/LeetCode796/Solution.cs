using System;

namespace LeetCode796
{
    public class Solution
    {
        public bool RotateString(string s, string goal)
        {
            var sTwice = s + s;

            var index = sTwice.IndexOf(goal, StringComparison.Ordinal);
            if (index <= -1)
            {
                return false;
            }

            var left = sTwice.Substring(0, index);
            var right = sTwice.Substring(index + goal.Length);
            return left + right == s;
        }
    }
}
