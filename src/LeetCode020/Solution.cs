using System.Collections.Generic;

namespace LeetCode020
{
    public class Solution
    {
        public bool IsValid(string s)
        {
            var stack = new Stack<char>();
            foreach (var c in s)
            {
                if (c == '(' || c == '{' || c == '[')
                {
                    stack.Push(c);
                    continue;
                }

                if (!stack.TryPeek(out var top))
                {
                    return false;
                }

                if (c == ')' && top == '(')
                {
                    stack.Pop();
                }
                else if (c == '}' && top == '{')
                {
                    stack.Pop();
                }
                else if (c == ']' && top == '[')
                {
                    stack.Pop();
                }
                else
                {
                    return false;
                }
            }

            return stack.Count == 0;
        }
    }
}
