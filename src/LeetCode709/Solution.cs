using System.Text;

namespace LeetCode709
{
    public class Solution
    {
        public string ToLowerCase(string s)
        {
            var length = s.Length;
            var buffer = new StringBuilder(length);
            for (var i = 0; i < length; i++)
            {
                var c = s[i];
                c = char.ToLower(c);
                buffer.Append(c);
            }

            return buffer.ToString();
        }
    }
}
