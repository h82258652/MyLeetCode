using System.Collections.Generic;

namespace LeetCode1441
{
    public class Solution
    {
        public IList<string> BuildArray(int[] target, int n)
        {
            var result = new List<string>();

            var targetLength = target.Length;
            var targetIndex = 0;
            for (var i = 1; i <= n; i++)
            {
                if (target[targetIndex] == i)
                {
                    result.Add("Push");
                    targetIndex++;

                    if (targetIndex == targetLength)
                    {
                        break;
                    }
                }
                else
                {
                    result.Add("Push");
                    result.Add("Pop");
                }
            }

            return result;
        }
    }
}
