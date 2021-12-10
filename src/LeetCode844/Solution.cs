using System.Collections.Generic;

namespace LeetCode844
{
    public class Solution
    {
        public bool BackspaceCompare(string s, string t)
        {
            var sLength = s.Length;
            var tLength = t.Length;

            var sStack = new Stack<char>(sLength);
            var tStack = new Stack<char>(tLength);

            for (var i = 0; i < sLength; i++)
            {
                var c = s[i];
                if (c == '#')
                {
                    sStack.TryPop(out _);
                }
                else
                {
                    sStack.Push(c);
                }
            }

            for (var i = 0; i < tLength; i++)
            {
                var c = t[i];
                if (c == '#')
                {
                    tStack.TryPop(out _);
                }
                else
                {
                    tStack.Push(c);
                }
            }

            if (sStack.Count != tStack.Count)
            {
                return false;
            }

            while (sStack.Count > 0 && tStack.Count > 0)
            {
                var sChar = sStack.Pop();
                var tChar = tStack.Pop();
                if (sChar != tChar)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
