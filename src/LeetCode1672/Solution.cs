using System.Linq;

namespace LeetCode1672
{
    public class Solution
    {
        public int MaximumWealth(int[][] accounts)
        {
            return accounts.Max(temp => temp.Sum());
        }
    }
}
