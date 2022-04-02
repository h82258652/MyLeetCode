using System.Collections.Generic;
using System.Linq;

namespace LeetCode1047
{
    public class Solution
    {
        public string RemoveDuplicates(string s)
        {
            var stack = new Stack<char>();
            foreach (var c in s)
            {
                if (stack.Count > 0)
                {
                    if (stack.Peek() == c)
                    {
                        stack.Pop();
                        continue;
                    }
                }

                stack.Push(c);
            }

            return new string(stack.Reverse().ToArray());
        }
    }
}
