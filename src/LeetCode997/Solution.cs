using System.Collections.Generic;

namespace LeetCode997
{
    public class Solution
    {
        public int FindJudge(int n, int[][] trust)
        {
            var judge = new int[n + 1];

            foreach (var temp in trust)
            {
                var a = temp[0];
                var b = temp[1];
                judge[a] = -1;
                if (judge[b] != -1)
                {
                    judge[b]++;
                }
            }

            var judgeList = new List<int>();
            for (var i = 1; i <= n; i++)
            {
                if (judge[i] == n - 1)
                {
                    judgeList.Add(i);
                }
            }

            if (judgeList.Count == 1)
            {
                return judgeList[0];
            }

            return -1;
        }
    }
}
