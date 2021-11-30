using System.Linq;

namespace LeetCode977
{
    public class Solution
    {
        public int[] SortedSquares(int[] nums)
        {
            return nums.Select(temp => temp * temp).OrderBy(temp => temp).ToArray();
        }
    }
}
