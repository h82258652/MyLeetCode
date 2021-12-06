using System.Text;

namespace LeetCode1816
{
    public class Solution
    {
        public string TruncateSentence(string s, int k)
        {
            var length = s.Length;

            var index = -1;
            for (var i = 0; i < length; i++)
            {
                if (i == length - 1)
                {
                    return s;
                }

                var c = s[i];
                if (c == ' ')
                {
                    k--;
                    index = i;

                    if (k == 0)
                    {
                        break;
                    }
                }
            }

            var builder = new StringBuilder();
            for (var i = 0; i < index; i++)
            {
                var c = s[i];
                builder.Append(c);
            }

            return builder.ToString();
        }
    }
}
