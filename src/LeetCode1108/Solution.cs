using System.Text;

namespace LeetCode1108
{
    public class Solution
    {
        public string DefangIPaddr(string address)
        {
            var length = address.Length;
            var result = new StringBuilder(length + 6);
            for (var i = 0; i < length; i++)
            {
                var c = address[i];
                if (c == '.')
                {
                    result.Append("[.]");
                }
                else
                {
                    result.Append(c);
                }
            }

            return result.ToString();
        }
    }
}
