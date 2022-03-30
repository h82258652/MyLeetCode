using System.Collections.Generic;
using System.Linq;

namespace LeetCode2138
{
    public class Solution
    {
        public string[] DivideString(string s, int k, char fill)
        {
            var chars = s.ToCharArray();
            var result = new List<string>();
            for (var i = 0; i < chars.Length; i += k)
            {
                var temp = new List<char>(chars.Skip(i).Take(k));
                while (temp.Count < k)
                {
                    temp.Add(fill);
                }
                result.Add(new string(temp.ToArray()));
            }

            return result.ToArray();
        }
    }
}
