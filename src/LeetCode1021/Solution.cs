using System.Collections.Generic;
using System.Text;

namespace LeetCode1021
{
    public class Solution
    {
        public string RemoveOuterParentheses(string s)
        {
            var builder = new StringBuilder();
            var list = new List<char>();
            var level = 0;

            foreach (var c in s)
            {
                if (c == '(')
                {
                    list.Add(c);
                    level++;
                }
                else
                {
                    list.Add(c);
                    level--;

                    if (level == 0)
                    {
                        for (var i = 1; i < list.Count - 1; i++)
                        {
                            builder.Append(list[i]);
                        }
                        list.Clear();
                    }
                }
            }

            return builder.ToString();
        }
    }
}
