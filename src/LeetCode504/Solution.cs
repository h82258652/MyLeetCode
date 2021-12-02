using System.Collections.Generic;
using System.Text;

namespace LeetCode504
{
    public class Solution
    {
        public string ConvertToBase7(int num)
        {
            if (num == 0)
            {
                return "0";
            }

            var isMinus = false;
            if (num < 0)
            {
                isMinus = true;
                num = -num;
            }

            var modStack = new Stack<int>();
            while (num > 0)
            {
                var mod = num % 7;
                modStack.Push(mod);
                num /= 7;
            }

            var result = new StringBuilder(modStack.Count);

            while (modStack.Count > 0)
            {
                result.Append(modStack.Pop());
            }

            if (isMinus)
            {
                return "-" + result;
            }

            return result.ToString();
        }
    }
}
