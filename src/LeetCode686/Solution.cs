using System;
using System.Text;

namespace LeetCode686
{
    public class Solution
    {
        public int RepeatedStringMatch(string a, string b)
        {
            var repeatCount = (int)Math.Ceiling(b.Length * 1d / a.Length);
            var builder = new StringBuilder();
            for (var i = 0; i < repeatCount; i++)
            {
                builder.Append(a);
            }

            if (builder.ToString().Contains(b))
            {
                return repeatCount;
            }

            builder.Append(a);

            if (builder.ToString().Contains(b))
            {
                return repeatCount + 1;
            }

            return -1;
        }
    }
}
