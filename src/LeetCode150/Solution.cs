using System.Collections.Generic;

namespace LeetCode150
{
    public class Solution
    {
        public int EvalRPN(string[] tokens)
        {
            var stack = new Stack<int>();
            foreach (var token in tokens)
            {
                switch (token)
                {
                    case "+":
                        {
                            var b = stack.Pop();
                            var a = stack.Pop();
                            stack.Push(a + b);
                            break;
                        }
                    case "-":
                        {
                            var b = stack.Pop();
                            var a = stack.Pop();
                            stack.Push(a - b);
                            break;
                        }
                    case "*":
                        {
                            var b = stack.Pop();
                            var a = stack.Pop();
                            stack.Push(a * b);
                            break;
                        }
                    case "/":
                        {
                            var b = stack.Pop();
                            var a = stack.Pop();
                            stack.Push(a / b);
                            break;
                        }
                    default:
                        stack.Push(int.Parse(token));
                        break;
                }
            }

            return stack.Peek();
        }
    }
}
