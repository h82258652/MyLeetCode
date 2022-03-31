using System.Collections.Generic;
using System.Text;

namespace LeetCode2109
{
    public class Solution
    {
        public string AddSpaces(string s, int[] spaces)
        {
            var builder = new StringBuilder();
            var sp = new HashSet<int>(spaces);
            for (var i = 0; i < s.Length; i++)
            {
                if (sp.Contains(i))
                {
                    builder.Append(' ');
                }

                builder.Append(s[i]);
            }

            return builder.ToString();
        }
    }
}
